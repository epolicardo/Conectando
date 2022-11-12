using Frontend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conectando
{
    public partial class frmMenu : Form
    {
        private string usuario { get; set; }
        public frmMenu(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario; 
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            lblUsuario.Text= usuario; 
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void salirbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void alumnobtn_Click(object sender, EventArgs e)
        {
            AltaAlumno menu = new AltaAlumno();
            menu.Show();
        }
    }
}
