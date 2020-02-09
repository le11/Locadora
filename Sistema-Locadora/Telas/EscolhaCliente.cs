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
    public partial class EscolhaCliente : Form
    {
        public EscolhaCliente()
        {
            InitializeComponent();
        }

        private void EscolhaCliente_Load(object sender, EventArgs e)
        {
            LocadoraContext db = new LocadoraContext();
            escolhaClienteDataGridView.DataSource = db.Clientes.ToList();
        }

        private List<Cliente> Busca()
        {
            LocadoraContext db = new LocadoraContext();
            IQueryable<Cliente> query = db.Clientes;

            //Nome

            if (!string.IsNullOrEmpty(escolhaClienteTextBox.Text))
            {
                query = query.Where(n => n.Nome.ToUpper().Contains(escolhaClienteTextBox.Text.ToUpper()));
            }

            List<Cliente> resultado = query.ToList();

            return resultado;




        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            escolhaClienteDataGridView.DataSource = Busca();
        }

        public Cliente retornaCliente()
        {
            string codFilmeSelecionado = escolhaClienteDataGridView.CurrentRow.Cells[0].Value.ToString();
            ClienteCrud clienteCrud = new ClienteCrud();

            return clienteCrud.ObterCliente(Convert.ToInt32(codFilmeSelecionado));

        }
    }
}
