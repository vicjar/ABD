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
    public partial class Pantalla2 : Form
    {
        public Pantalla2()
        {
            InitializeComponent();
            DBConn conn = new DBConn();

         //   conn.OpenConn("127.0.0.1", "3306", "root","taquitos02","sakila");

        }

        private void DataExpences_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Pantalla2_Load(object sender, EventArgs e)
        {

        }

        private void Btndata_Click(object sender, EventArgs e)
        {

        }
    }
}
