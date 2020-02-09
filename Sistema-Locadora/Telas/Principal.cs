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

namespace Sistema_Locadora.Telas
{
    public partial class Principal : Form
    {
        public static Login atualUsuario;
        public Principal(Login atualLogin)
        {
            InitializeComponent();
            atualUsuario = atualLogin;
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            UsuarioConectadolbl.Text = atualUsuario.Nome;
        }
        private void btnEstoque_Click(object sender, EventArgs e)
        {
            ucFilme1.BringToFront();
        }

        private void btnNovClient_Click(object sender, EventArgs e)
        {
            ucCliente1.BringToFront();
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnNovLoc_Click(object sender, EventArgs e)
        {
            ucLocacao1.BringToFront();
        }
 
    }
}
