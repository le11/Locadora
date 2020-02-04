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

namespace Sistema_Locadora.Telas
{
    public partial class UcLocacao : UserControl
    {
        Filme filmeEscolhido;
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
            locacaoDataGridView.DataSource = db.Locacoes.ToList();
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

        }

        private void filtroFilme_Click(object sender, EventArgs e)
        {
            EscolhaFilme escolhaFilme = new EscolhaFilme();
            escolhaFilme.ShowDialog();
            int codFilme = Convert.ToInt32(escolhaFilme.retornaFilme());

            FilmeCrud filmeCrud = new FilmeCrud();

            filmeEscolhido = filmeCrud.ObterFilme(codFilme);
            searchLocacaoFilme.Text = filmeEscolhido.Titulo;
        }

       /* private List<Locacao> Busca()
        {
            LocadoraContext db = new LocadoraContext();
            IQueryable<Locacao> query = db.Locacoes;

            
        }*/
    }
}
