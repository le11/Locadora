using System;
using System.Windows.Forms;
using Sistema_Locadora.Entities;
using Sistema_Locadora.Data;

namespace Sistema_Locadora.Telas
{
    public partial class FormularioLocacao : Form
    {
        Filme filmeEscolhido;

        Cliente clienteEscolhido;
        public FormularioLocacao()
        {
            InitializeComponent();
            addColabTxt.Text = Principal.atualUsuario.Nome;
        }


        private void filtroFilme_Click(object sender, EventArgs e)
        {
            EscolhaFilme escolhaFilme = new EscolhaFilme();
            escolhaFilme.ShowDialog();

            filmeEscolhido = escolhaFilme.retornaFilme();
            addFilmeTxt.Text = filmeEscolhido.Titulo;
        }

        private bool camposPreenchidos()
        {

            if (string.IsNullOrEmpty(addFilmeTxt.Text) || string.IsNullOrEmpty(addClientTxt.Text)
                || RetiradadateTimePicker.Value == null || DevolucaodateTimePicker.Value == null
                || string.IsNullOrEmpty(addColabTxt.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void NovLocConfirm_Click(object sender, EventArgs e)
        {

            if (!camposPreenchidos())
            {
                MessageBox.Show("Há campos não preenchidos!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Confirma dados inseridos?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    LocacaoCrud locacaoCrud = new LocacaoCrud();

                    Locacao novaLocacao = new Locacao
                    {
                        //Filme = filmeEscolhido,
                        FilmeId = filmeEscolhido.Codigo,

                        //Cliente = clienteEscolhido,
                        ClienteId = clienteEscolhido.Codigo,

                        DataRetirada = RetiradadateTimePicker.Value,
                        DataDevolucao = DevolucaodateTimePicker.Value,

                        //Colaborador = Principal.atualUsuario,
                        ColaboradorId = Principal.atualUsuario.Codigo
                    };

                    if (locacaoCrud.Insert(novaLocacao))
                    {
                        MessageBox.Show("Locação inserida!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao inserir!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }



                }

            }

        }


        private void filtroCliente_Click(object sender, EventArgs e)
        {
            EscolhaCliente escolhaCliente = new EscolhaCliente();
            escolhaCliente.ShowDialog();

            clienteEscolhido = escolhaCliente.retornaCliente();

            addClientTxt.Text = clienteEscolhido.Nome;
        }

        private void FormularioLocacao_Load(object sender, EventArgs e)
        {

        }
    }
}
