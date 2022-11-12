using System.Data.SqlClient;
using System.Configuration;
using Backend;
using Backend.Modelos;
using Conectando.Resources;
using Microsoft.EntityFrameworkCore;
using Conectando.Data;
using Conectando.Repositorios;

namespace Conectando
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        private void btningresar_Click(object sender, EventArgs e)
        {

            RepositorioUsuarios repositorio = new RepositorioUsuarios();

            Usuario user = repositorio.LoginUsuario(usuariotxt.Text);
            if (user != null && user.TipoUsuario == "Administrador")
            {
                frmMenu menu = new frmMenu(user.Nombre);
                menu.Show(this);
            }
            else
            {
                MessageBox.Show("Usuario o contrase?a incorrectos");
            }


        }

        private void txtclave_TextChanged(object sender, EventArgs e)
        {
            if (txtclave.Text != " ")
            {
                txtclave.UseSystemPasswordChar = true;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Minimized;
            else if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Minimized;

        }

    }
}