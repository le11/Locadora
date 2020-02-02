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
using Sistema_Locadora.Entities;
using Sistema_Locadora.Data;
using Sistema_Locadora.Enums;

namespace Sistema_Locadora.Telas
{
    public partial class UcCliente : UserControl
    {
        public UcCliente()
        {
            InitializeComponent();
        }

        private void UcCliente_Load(object sender, EventArgs e)
        {
            clientesDataGridView1.SetBounds(24, 50, 911, 566);

            CarregaGrid();
        }
        private void CarregaGrid()
        {
            //carregando o grid

            LocadoraContext db = new LocadoraContext();
            clientesDataGridView1.DataSource = db.Clientes.ToList();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            FormularioCliente formularioCliente = new FormularioCliente();
            formularioCliente.ShowDialog();
            CarregaGrid();
        }

        private void editToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                int linhaSelecionada = Convert.ToInt32(clientesDataGridView1.CurrentRow.Cells[0].Value.ToString());
                EditCliente editCliente = new EditCliente(linhaSelecionada);
                editCliente.ShowDialog();
                CarregaGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                int linhaSelecionada = Convert.ToInt32(clientesDataGridView1.CurrentRow.Cells[0].Value.ToString());
                ClienteCrud crud = new ClienteCrud();

                if (MessageBox.Show("Confirma a exclusão do cliente?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if ((crud.Delete(linhaSelecionada)))
                    {

                        MessageBox.Show("Cliente deletado!");
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
            LocadoraContext db = new LocadoraContext();

            clientesDataGridView1.DataSource = db.Clientes.ToList();

            CarregaGrid();
        }

        private void searchToolStripButton_Click(object sender, EventArgs e)
        {
            if (searchPanel.Enabled)
            {
                clientesDataGridView1.SetBounds(24, 50, 911, 566);
                searchPanel.Enabled = false;
            }
            else
            {
                clientesDataGridView1.SetBounds(24, 202, 911, 414);
                searchPanel.Enabled = true;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            clientesDataGridView1.DataSource = Busca();
        }

        private List<Cliente> Busca()
        {
            LocadoraContext db = new LocadoraContext();
            IQueryable<Cliente> query = db.Clientes;

            //Nome
            if (!String.IsNullOrEmpty(searchClientName.Text))
            {
                query = query.Where(n => n.Nome.ToUpper().Contains(searchClientName.Text.ToUpper()));
            }

            //Email
            if (!String.IsNullOrEmpty(searchEmailClient.Text))
            {
                query = query.Where(n => n.Email.ToUpper().Contains(searchEmailClient.Text.ToUpper()));
            }

            //Telefone
            if (!String.IsNullOrEmpty(searchTelClient.Text))
            {
                query = query.Where(n => n.Telefone.Contains(searchTelClient.Text));
            }

            //CPF
            if (!String.IsNullOrEmpty(searchCpfClient.Text))
            {
                query = query.Where(n => n.Cpf.Contains(searchCpfClient.Text));
            }

            List<Cliente> resultado = query.ToList();

            return resultado;
        }
    }
}
