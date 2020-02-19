using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Locadora.Data;
using Sistema_Locadora.Entities;

namespace Sistema_Locadora.Telas
{
    public partial class EscolhaFilme : Form
    {
        public EscolhaFilme()
        {
            InitializeComponent();
        }

        private void EscolhaFilme_Load(object sender, EventArgs e)
        {
            LocadoraContext db = new LocadoraContext();
            escolhaFilmeDataGridView.DataSource = db.Filmes.ToList();
        }

        private List<Filme> Busca()
        {
            LocadoraContext db = new LocadoraContext();
            IQueryable<Filme> query = db.Filmes;

            //Titulo
            if (!string.IsNullOrEmpty(escolhaTituloTextBox.Text))
            {
                query = query.Where(n => n.Titulo.ToUpper().Contains(escolhaTituloTextBox.Text.ToUpper()));
            }

            List<Filme> resultado = query.ToList();

            return resultado;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            escolhaFilmeDataGridView.DataSource = Busca();
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public Filme retornaFilme()
        {
            if (escolhaFilmeDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum filme foi selecionado!");
                return null;
            }
            else
            {
                string codFilmeSelecionado = escolhaFilmeDataGridView.CurrentRow.Cells[0].Value.ToString();
                FilmeCrud filmeCrud = new FilmeCrud();

                return filmeCrud.ObterFilme(Convert.ToInt32(codFilmeSelecionado));
            }
        }
    }
}
