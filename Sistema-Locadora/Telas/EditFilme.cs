using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Locadora.Entities;
using Sistema_Locadora.Data;
using Sistema_Locadora.Adicionais;
using Sistema_Locadora.Enums;

namespace Sistema_Locadora.Telas
{
    public partial class EditFilme : Form
    {
        Filme filme;
        public EditFilme(int codFilme)
        {
            InitializeComponent();
            try
            {
                FilmeCrud crud = new FilmeCrud();
                filme = crud.ObterFilme(codFilme);

                tituloTextBox.Text = filme.Titulo;
                titulo_OriginalTextBox.Text = filme.Titulo_Original;
                editQuantidade.Text = filme.Quantidade.ToString();
                localizacaoTextBox.Text = filme.Localizacao;
                idiomaTextBox.Text = filme.Idioma;
                legendaTextBox.Text = filme.Legenda;
                anoDeProducaoDateTimePicker.Value = filme.AnoDeProducao;
                ator_PrincipalTextBox.Text = filme.Ator_Principal;
                classificacaoTextBox.Text = filme.Classificacao;
                fornecedorTextBox.Text = filme.Fornecedor;
                generoCmb1.SelectedItem = filme.Genero;

                this.generoCmb1.DataSource = HelperMethod.EnumToList<Generos>();

                generoCmb1.SelectedItem = null;
                generoCmb1.SelectedText = "Selecione um gênero";


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void quantidadeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void EditConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                Filme novoFilme = new Filme();

                FilmeCrud crud = new FilmeCrud();

                novoFilme.Titulo = tituloTextBox.Text;
                novoFilme.Idioma = idiomaTextBox.Text;
                novoFilme.Titulo_Original = titulo_OriginalTextBox.Text;
                novoFilme.Legenda = legendaTextBox.Text;
                novoFilme.Localizacao = localizacaoTextBox.Text;
                novoFilme.Quantidade = Convert.ToInt32(editQuantidade.Text);
                novoFilme.AnoDeProducao = anoDeProducaoDateTimePicker.Value;
                novoFilme.Classificacao = classificacaoTextBox.Text;
                novoFilme.Fornecedor = fornecedorTextBox.Text;
                novoFilme.Genero = (Generos)generoCmb1.SelectedItem;
                novoFilme.Ator_Principal = ator_PrincipalTextBox.Text;

                if (crud.Atualizar(filme, novoFilme))
                {
                    MessageBox.Show("Filme atualizado!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
