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
using System.Security.Cryptography;
using Sistema_Locadora.Entities;
using Sistema_Locadora.Telas;

namespace Sistema_Locadora
{
    public partial class TelaLogin : Form
    {
        Login atualLogin;
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {
            // this.BackColor = Color.FromArgb(53, 64, 81);
            this.BackColor = Color.AliceBlue;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            LocadoraContext db = new LocadoraContext();
            Login l = new Login();
            Hash h = new Hash(SHA512.Create());
            try
            {
                if (!l.checkUser(txtUser.Text))
                {
                    MessageBox.Show("Usuário inválido!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    string passw = (from u in db.Login where u.Usuario == txtUser.Text select u.Senha).FirstOrDefault().ToString();

                    if (!h.VerificarSenha(txtSenha.Text.ToString(), passw))
                    {
                        MessageBox.Show("Senha inválida!");

                    }
                    else
                    {
                        //Guardando usuario logado
                        LoginCrud loginCrud = new LoginCrud();
                        atualLogin = loginCrud.ObterLogin(txtUser.Text);
                        //
                        Principal p1 = new Principal(atualLogin);
                        p1.Show();
                        this.Hide();

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
