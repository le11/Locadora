using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Locadora.Adicionais;
using Sistema_Locadora.Data;
using Sistema_Locadora.Entities;

namespace Sistema_Locadora.Telas
{
    public partial class UcFilme : UserControl
    {
        public UcFilme()
        {
            InitializeComponent();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            FormularioFilme formFilme = new FormularioFilme();
            formFilme.ShowDialog();
            CarregaGrid();
        }

        private void UcFilme_Load(object sender, EventArgs e)
        {
            filmesDataGridView.SetBounds(24, 50, 911, 566);
            CarregaGrid();
        }

        private void CarregaGrid()
        {
            LocadoraContext db = new LocadoraContext();
            filmesDataGridView.DataSource = db.Filmes.ToList();
        }

        private void editToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                int linhaSelecionada = Convert.ToInt32(filmesDataGridView.CurrentRow.Cells[0].Value.ToString());
                EditFilme editFilme = new EditFilme(linhaSelecionada);
                editFilme.ShowDialog();
                CarregaGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                int linhaSelecionada = Convert.ToInt32(filmesDataGridView.CurrentRow.Cells[0].Value.ToString());
                FilmeCrud crud = new FilmeCrud();
                Filme exclusao = crud.ObterFilme(linhaSelecionada);

                if (MessageBox.Show("Confirma a exclusão do filme?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (exclusao.Locado > 0)
                    {
                        MessageBox.Show("Este filme está registrado em locações", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    else if (crud.Delete(linhaSelecionada))
                    {
                        MessageBox.Show("Filme excluído!");
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

        private void refreshToolStripButton_Click(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void searchToolStripButton_Click(object sender, EventArgs e)
        {
            if (searchPanel.Enabled)
            {
                filmesDataGridView.SetBounds(24, 50, 911, 566);
                searchPanel.Enabled = false;
            }
            else
            {
                filmesDataGridView.SetBounds(24, 202, 911, 414);
                searchPanel.Enabled = true;
            }
        }

        private List<Filme> Busca()
        {
            LocadoraContext db = new LocadoraContext();
            IQueryable<Filme> query = db.Filmes;

            //Titulo
            if (!string.IsNullOrEmpty(searchFilmeTitulo.Text))
            {
                query = query.Where(n => n.Titulo.ToUpper().Contains(searchFilmeTitulo.Text.ToUpper()));
            }

            //Classificacao
            if (!string.IsNullOrEmpty(searchClassifFilme.Text))
            {
                query = query.Where(n => n.Classificacao.ToUpper().Contains(searchClassifFilme.Text.ToUpper()));
            }

            //Ator Principal
            if (!string.IsNullOrEmpty(searchAtorPrincipal.Text))
            {
                query = query.Where(n => n.Ator_Principal.ToUpper().Contains(searchAtorPrincipal.Text.ToUpper()));
            }

            List<Filme> resultado = query.ToList();

            return resultado;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            filmesDataGridView.DataSource = Busca();
        }
    }
}
