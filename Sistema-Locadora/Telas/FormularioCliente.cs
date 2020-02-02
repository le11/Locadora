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
using Sistema_Locadora.Adicionais;
using Sistema_Locadora.Entities;

namespace Sistema_Locadora.Telas
{
    public partial class FormularioCliente : Form
    {
        public FormularioCliente()
        {
            InitializeComponent();
        }

        private void addClientBtn_Click(object sender, EventArgs e)
        {
            if (!CheckCamposPreenchidos())
            {
                MessageBox.Show("Há campos obrigatórios não preenchidos!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                Cliente novoCliente = new Cliente
                {
                    Nome = addClientName.Text,
                    Email = addClientEmail.Text,
                    Telefone = AddTelmkTxt.Text
                };

                //impedindo inserção de CPF repetido
                LocadoraContext db = new LocadoraContext();

                try
                {
                    if (!ValidaCpf.IsCpf(addCpfTxtmsk.Text))
                    {
                        MessageBox.Show("CPF inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        string testeCpf = (from cliente in db.Clientes where cliente.Cpf == addCpfTxtmsk.Text select cliente.Cpf).SingleOrDefault();

                        if (testeCpf != null)
                        {
                            MessageBox.Show("CPF já cadastrado no sistema!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        else
                        {
                            novoCliente.Cpf = addCpfTxtmsk.Text;
                        }
                        /////////////////////////////////////

                    }
                    ClienteCrud clCrud = new ClienteCrud();

                    if (clCrud.Insert(novoCliente))
                    {
                        MessageBox.Show("Cliente inserido com sucesso!");
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro! Tente novamente");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private bool CheckCamposPreenchidos()
        {
            if (string.IsNullOrEmpty(addClientName.Text) ||
                string.IsNullOrEmpty(addCpfTxtmsk.Text) ||
                !AddTelmkTxt.MaskCompleted)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
