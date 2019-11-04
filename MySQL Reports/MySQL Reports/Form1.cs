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
            DBConn conn = new DBConn();

            conn.OpenConn("127.0.0.1", "3306", "root","taquitos02","sakila");
            
        }

        private void SALIR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MAXIMIZAR_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void MINIMIZAR_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
