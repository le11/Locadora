using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Sistema_Locadora.Data;
using Sistema_Locadora.Entities;


namespace Sistema_Locadora.Telas
{
    public partial class UcLocacao : UserControl
    {
        Filme filmeEscolhido;
        Login atualLogin;
        public UcLocacao()
        {
            InitializeComponent();

        }

        private void UcLocacao_Load(object sender, EventArgs e)
        {
            locacaoDataGridView.SetBounds(24, 50, 911, 566);
            CarregaGrid();
        }


        private void CarregaGrid()
        {
            LocadoraContext db = new LocadoraContext();

            var query = from i in db.Locacoes
                        orderby i.Codigo
                        select new { i.Codigo, Filme = i.Filme.Titulo, Cliente = i.Cliente.Nome, Colaborador = i.Colaborador.Nome, Data_de_Retirada = i.DataRetirada, Data_Prevista_Devolucao = i.DataPrevDevolucao, i.Devolucao, i.Status };

            locacaoDataGridView.DataSource = query.ToList();
        }

        private void searchToolStripButton_Click(object sender, EventArgs e)
        {
            if (searchPanel.Enabled)
            {
                locacaoDataGridView.SetBounds(24, 50, 911, 566);
                searchPanel.Enabled = false;
            }
            else
            {
                locacaoDataGridView.SetBounds(24, 202, 911, 414);
                searchPanel.Enabled = true;
            }
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            FormularioLocacao formularioLocacao = new FormularioLocacao();
            formularioLocacao.ShowDialog();
            CarregaGrid();
        }

        private void filtroFilme_Click(object sender, EventArgs e)
        {
            EscolhaFilme escolhaFilme = new EscolhaFilme();
            escolhaFilme.ShowDialog();

            filmeEscolhido = escolhaFilme.retornaFilme();
            if (filmeEscolhido != null)
            {
                searchLocacaoFilme.Text = filmeEscolhido.Titulo;
            }
            /*else
            {
                searchLocacaoFilme.Text = null;
            }*/
        }

        private void refreshToolStripButton_Click(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void deleteToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                int linhaSelecionada = Convert.ToInt32(locacaoDataGridView.CurrentRow.Cells[0].Value.ToString());
                LocacaoCrud crud = new LocacaoCrud();
                Locacao atual = crud.ObterLocacao(linhaSelecionada);

                if (MessageBox.Show("Confirma a exclusão desta locação?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (crud.Delete(linhaSelecionada))
                    {
                        //buscando o filme que foi locado
                        FilmeCrud filmeCrud = new FilmeCrud();
                        Filme locFilme = filmeCrud.ObterFilme(atual.FilmeId);
                        //

                        filmeRetornou(atual);
                        MessageBox.Show("Locação excluída!");
                        CarregaGrid();
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private Locacao locacaoSelecionada()
        {
            LocacaoCrud crud = new LocacaoCrud();
            Locacao locacao = crud.ObterLocacao(Convert.ToInt32(locacaoDataGridView.CurrentRow.Cells[0].Value.ToString()));
            return locacao;
        }

        private void locacaoDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value.Equals("Locado"))
            {
                e.CellStyle.BackColor = Color.LightGoldenrodYellow;
            }
            else if (e.Value.Equals("Cancelado"))
            {
                e.CellStyle.BackColor = Color.Gray;
            }
            else if (e.Value.Equals("Concluido"))
            {
                e.CellStyle.BackColor = Color.Green;
            }
        }

        private void concluidoBtnToolStip_Click(object sender, EventArgs e)
        {
            if (locacaoSelecionada().Status == "Cancelado")
            {
                MessageBox.Show("Registro de locação já foi cancelado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (locacaoSelecionada().Status == "Concluido")
            {
                return;
            }
            else
            {
                if (MessageBox.Show("Confirma mudança de status para CONCLUÍDO?", "Confirmação de mudança", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    LocacaoCrud crud = new LocacaoCrud();
                    Locacao locSelecionada = locacaoSelecionada();
                    Locacao mudaStatus = locSelecionada;
                    mudaStatus.Status = "Concluido";
                    mudaStatus.Devolucao = DateTime.Now;


                    if (crud.Atualizar(locSelecionada, mudaStatus) && filmeRetornou(locSelecionada))
                    {
                        MessageBox.Show("Status alterado");
                        CarregaGrid();
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else
                {
                    return;
                }
            }
        }

        private void canceladoBtnToolStrip_Click(object sender, EventArgs e)
        {
            try
            {
                if (locacaoSelecionada().Status == "Locado")
                {
                    if (MessageBox.Show("Confirma mudança de status para CANCELADO?", "Confirmação de mudança", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        LocacaoCrud crud = new LocacaoCrud();
                        int linhaSelecionada = Convert.ToInt32(locacaoDataGridView.CurrentRow.Cells[0].Value.ToString());
                        Locacao locSelecionada = crud.ObterLocacao(linhaSelecionada);
                        Locacao mudaStatus = new Locacao();
                        mudaStatus = locSelecionada;
                        mudaStatus.Status = "Cancelado";


                        if (filmeRetornou(locSelecionada))
                        {
                            if (crud.Atualizar(locSelecionada, mudaStatus))
                            {
                                MessageBox.Show("Status alterado");
                                CarregaGrid();
                            }
                            else
                            {
                                MessageBox.Show("Ocorreu um erro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }
                        else
                        {
                            MessageBox.Show("Não há unidades locadas", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        return;
                    }
                }
                else if (locacaoSelecionada().Status == "Concluido")
                {
                    if (MessageBox.Show("Confirma mudança de status para CANCELADO?", "Confirmação de mudança", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        LocacaoCrud crud = new LocacaoCrud();
                        int linhaSelecionada = Convert.ToInt32(locacaoDataGridView.CurrentRow.Cells[0].Value.ToString());
                        Locacao locSelecionada = crud.ObterLocacao(linhaSelecionada);
                        Locacao mudaStatus = new Locacao();
                        mudaStatus = locSelecionada;
                        mudaStatus.Status = "Cancelado";

                        if (crud.Atualizar(locSelecionada, mudaStatus))
                        {
                            MessageBox.Show("Status alterado");
                            CarregaGrid();
                        }
                        else
                        {
                            MessageBox.Show("Ocorreu um erro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private List<Locacao> Busca()
        {
            LocadoraContext db = new LocadoraContext();
            IQueryable<Locacao> query = db.Locacoes;



            if (!string.IsNullOrEmpty(searchDataDevolucao.Text))
            {
                query = query.Where(n => n.DataPrevDevolucao.ToString().Contains(searchDataDevolucao.Text));
            }

            if (!string.IsNullOrEmpty(searchDataRetirada.Text))
            {
                query = query.Where(n => n.DataRetirada.ToString().Contains(searchDataRetirada.Text));
            }

            if (!string.IsNullOrEmpty(searchLocacaoClient.Text))
            {
                query = query.Where(n => n.Cliente.Nome.ToUpper().ToString().Contains(searchLocacaoClient.Text.ToUpper().ToString()));
            }

            if (!string.IsNullOrEmpty(searchLocacaoFilme.Text))
            {
                query = query.Where(n => n.Filme.Titulo.ToUpper().ToString().Contains(searchLocacaoFilme.Text.ToUpper().ToString()));
            }

            if (!string.IsNullOrEmpty(searchStatuscomboBox.Text))
            {
                query = query.Where(n => n.Status.ToUpper().Contains(searchStatuscomboBox.Text.ToString().ToUpper()));
            }

            if (!string.IsNullOrEmpty(searchLocacaoCod.Text))
            {
                int codSearch = Convert.ToInt32(searchLocacaoCod.Text);
                query = query.Where(n => n.Codigo == codSearch);
            }

            List<Locacao> resultado = query.ToList();

            return resultado;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            List<Locacao> locacaos = Busca();

            LocadoraContext db = new LocadoraContext();

            var resultado = from locacao in locacaos
                            join filme in db.Filmes on locacao.FilmeId equals filme.Codigo
                            join cliente in db.Clientes on locacao.ClienteId equals cliente.Codigo
                            join colaborador in db.Login on locacao.ColaboradorId equals colaborador.Codigo
                            select new
                            {
                                Codigo = locacao.Codigo,
                                Filme = filme.Titulo,
                                Cliente = cliente.Nome,
                                Colaborador = colaborador.Nome,
                                Data_de_Retirada = locacao.DataRetirada,
                                Data_Prevista_Devolucao = locacao.DataPrevDevolucao,
                                Devolucao = locacao.Devolucao,
                                Status = locacao.Status
                            };

            locacaoDataGridView.DataSource = resultado.ToList();
        }

        private void filtroCliente_Click(object sender, EventArgs e)
        {

        }

        private bool filmeRetornou(Locacao locSelecionada)
        {
            FilmeCrud filmeCrud = new FilmeCrud();
            Filme locFilme = filmeCrud.ObterFilme(locSelecionada.FilmeId);
            //
            if (locFilme.Locado < 1)
            {
                return false;
            }
            else
            {
                Filme novoFilme = locFilme;
                novoFilme.Quantidade = locFilme.Quantidade + 1;
                novoFilme.Locado = locFilme.Locado - 1;

                return (filmeCrud.Atualizar(locFilme, novoFilme)) ? true : false;
            }
        }

        private void locacaoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
