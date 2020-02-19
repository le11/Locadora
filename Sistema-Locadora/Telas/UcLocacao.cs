using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Locadora.Data;
using Sistema_Locadora.Entities;
using System.Globalization;

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
                        select new { i.Codigo, i.Filme.Titulo, Cliente = i.Cliente.Nome, i.Colaborador.Nome, i.DataRetirada, i.DataPrevDevolucao, i.Devolucao, i.Status };

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

                        Filme novoFilme = new Filme
                        {
                            Quantidade = locFilme.Quantidade + 1,
                            Locado = locFilme.Locado - 1,
                            Titulo = locFilme.Titulo,
                            Titulo_Original = locFilme.Titulo_Original,
                            AnoDeProducao = locFilme.AnoDeProducao,
                            Ator_Principal = locFilme.Ator_Principal,
                            Classificacao = locFilme.Classificacao,
                            Fornecedor = locFilme.Fornecedor,
                            Idioma = locFilme.Idioma,
                            Legenda = locFilme.Legenda,
                            Localizacao = locFilme.Localizacao,
                            Genero = locFilme.Genero
                        };

                        //atualizando a quantidade do filme em estoque
                        filmeCrud.Atualizar(locFilme, novoFilme);
                        //
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
                    _ = new Locacao();
                    Locacao mudaStatus = locSelecionada;
                    mudaStatus.Status = "Concluido";
                    mudaStatus.Devolucao = DateTime.Now;
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
        }

        private void canceladoBtnToolStrip_Click(object sender, EventArgs e)
        {
            if (locacaoSelecionada().Status == "Cancelado")
            {
                return;
            }
            else
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
                query = query.Where(n => n.Cliente.ToString().ToUpper().Contains(searchLocacaoClient.Text));
            }

            if (!string.IsNullOrEmpty(searchLocacaoFilme.Text))
            {
                query = query.Where(n => n.Filme.ToString().ToUpper().Contains(searchLocacaoFilme.Text));
            }

            if (!string.IsNullOrEmpty(searchStatuscomboBox.SelectedItem.ToString()))
            {
                query = query.Where(n => n.Status.ToUpper().Contains(searchStatuscomboBox.SelectedItem.ToString()));
            }

            if (!string.IsNullOrEmpty(searchLocacaoCod.Text))
            {
                query = query.Where(n => n.Codigo.ToString().Contains(searchLocacaoCod.Text));
            }

            List<Locacao> resultado = query.ToList();

            return resultado;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            locacaoDataGridView.DataSource = Busca();
        }
    }
}
/*private List<Locacao> Busca()
{
LocadoraContext db = new LocadoraContext();
IQueryable<Locacao> query = db.Locacoes;


}*/


