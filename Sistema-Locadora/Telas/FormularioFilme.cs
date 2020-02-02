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
using Sistema_Locadora.Data;
using Sistema_Locadora.Entities;

namespace Sistema_Locadora.Telas
{
    public partial class FormularioFilme : Form
    {
        public FormularioFilme()
        {
            InitializeComponent();
        }

        private void FormularioFilme_Load(object sender, EventArgs e)
        {
            this.addGeneroCmb1.DataSource = HelperMethod.EnumToList<Generos>();
            addGeneroCmb1.SelectedItem = null;
            addGeneroCmb1.SelectedText = "Selecione um gênero";
        }

        private bool CheckCamposPreenchidos()
        {
            if (string.IsNullOrEmpty(addTituloTextBox.Text) &&
                string.IsNullOrEmpty(addQuantidade.Text) &&
               string.IsNullOrEmpty(addAtor_PrincipalTextBox.Text) &&
               addGeneroCmb1.SelectedItem == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void NovConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckCamposPreenchidos())
                {
                    MessageBox.Show("Há campos obrigatórios não preenchidos!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Filme novoFilme = new Filme();
                    novoFilme.AnoDeProducao = addAnoDeProducaoDateTimePicker.Value;
                    novoFilme.Ator_Principal = addAtor_PrincipalTextBox.Text;
                    novoFilme.Classificacao = addClassificacaoTextBox.Text;
                    novoFilme.Fornecedor = addFornecedorTextBox.Text;
                    novoFilme.Idioma = addIdiomaTextBox.Text;
                    novoFilme.Legenda = addLegendaTextBox.Text;
                    novoFilme.Localizacao = addLocalizacaoTextBox.Text;
                    novoFilme.Quantidade = Convert.ToInt32(addQuantidade.Text);
                    novoFilme.Titulo = addTituloTextBox.Text;
                    novoFilme.Titulo_Original = addTitulo_OriginalTextBox.Text;

                    novoFilme.Genero = (Generos)this.addGeneroCmb1.SelectedItem;


                    FilmeCrud fcrud = new FilmeCrud();
                    if (fcrud.Insert(novoFilme))
                    {
                        MessageBox.Show("Filme inserido com sucesso!");
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Erro! Tente novamente!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
