using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Locadora.Enums;
using Sistema_Locadora.Entities;
using Sistema_Locadora.Data;
using Sistema_Locadora.Adicionais;

namespace Sistema_Locadora.Telas
{
    public partial class EditCliente : Form
    {
        Cliente cliente;
        public EditCliente(int codCliente)
        {
            InitializeComponent();
            try
            {
                ClienteCrud crud = new ClienteCrud();

                cliente = crud.ObterCliente(codCliente);

                editClientName.Text = cliente.Nome;
                editCpfTxtmsk.Text = cliente.Cpf;
                editClientEmail.Text = cliente.Email;
                editTelmkTxt.Text = cliente.Telefone;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditCliente_Load(object sender, EventArgs e)
        {

        }

        private void editClientBtn_Click(object sender, EventArgs e)
        {
            ClienteCrud crud = new ClienteCrud();

            Cliente novoCliente = new Cliente();

            try
            {
                //impedindo inserção de CPF repetido
                LocadoraContext db = new LocadoraContext();


                if (!ValidaCpf.IsCpf(editCpfTxtmsk.Text))
                {
                    MessageBox.Show("CPF inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    string testeCpf = (from cliente in db.Clientes where cliente.Cpf == editCpfTxtmsk.Text select cliente.Cpf).SingleOrDefault();

                    if (testeCpf != null && testeCpf != cliente.Cpf)
                    {
                        MessageBox.Show("CPF já cadastrado no sistema!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    else
                    {
                        novoCliente.Cpf = editCpfTxtmsk.Text;
                    }

                }

                novoCliente.Email = editClientEmail.Text;
                novoCliente.Nome = editClientName.Text;
                novoCliente.Telefone = editTelmkTxt.Text;



                if (crud.Atualizar(cliente, novoCliente))
                {
                    MessageBox.Show("Cliente atualizado!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Ocorreu um erro!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
