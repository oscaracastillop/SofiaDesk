using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            // Close the application when the cancel button is clicked
            //Application.Exit();
            this.Close();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            Inicio form = new Inicio();
            form.Show();
            // Hide the login form after showing the main form  
            this.Hide();

            form.FormClosing += new FormClosingEventHandler(frm_closing);
        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            textdocumento.Text = "";
            textclave.Text = "";
            this.Show();
        }
    }
}
