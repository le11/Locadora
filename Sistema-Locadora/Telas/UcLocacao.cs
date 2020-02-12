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
                        select new { i.Codigo, i.Filme.Titulo, Cliente = i.Cliente.Nome, i.Colaborador.Nome, i.DataRetirada, i.DataDevolucao };

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
            searchLocacaoFilme.Text = filmeEscolhido.Titulo;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void refreshToolStripButton_Click(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void locacaoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        /*private List<Locacao> Busca()
         {
             LocadoraContext db = new LocadoraContext();
             IQueryable<Locacao> query = db.Locacoes;


         }*/
    }
}
