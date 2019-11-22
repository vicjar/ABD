using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySQL_Reports
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btnlog_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtuser.Text) || string.IsNullOrWhiteSpace(txtpass.Text))
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
            else
            {
                //if ((txtuser.Text == "CYNTHIA") || (txtuser.Text == "VICTOR") & (txtpass.Text == "1234"))
               // {
                    
                     Pantalla2 H = new Pantalla2(txtuser.Text, txtpass.Text);
                     H.Show();
                     this.Hide();
                    
                //}
               /* else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                }*/
            }
        }

        private void Txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "USER")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.White;
            }
        }

        private void Txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "USER";
                txtuser.ForeColor = Color.DimGray;
            }
        }

        private void Tatpass_Enter(object sender, EventArgs e)
        {

            if (txtpass.Text == "PASSWORD")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.DimGray;
                txtpass.PasswordChar = '*';
            }
        }

        private void Tatpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "PASSWORD";
                txtpass.ForeColor = Color.DimGray;
            }

        }
        private void SALIR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MINIMIZAR_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void RectangleShape1_Click(object sender, EventArgs e)
        {

        }

        private void Txtuser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
