using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MySQL_Reports
{
    public partial class Pantalla2 : Form
    {
        DBConn conn = new DBConn();
        public Pantalla2()
        {
            InitializeComponent();
            conn.OpenConn("127.0.0.1", "3306", "root", "taquitos02", "sakila");
        }

        private void Btndata_Click(object sender, EventArgs e)
        {
            cmbdata.Visible = true;
        }
        private void Btntable_Click(object sender, EventArgs e)
        {
            cmbtable.Visible = true;
        }

        private void SALIR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MINIMIZAR_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void DataExpences_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Pantalla2_Load(object sender, EventArgs e)
        {

        }

        private void connect_Click(object sender, EventArgs e)
        {
            cmbtable.Items.Clear();
            MessageBox.Show("se agregaron las bases de datos al combo box");
            string[] bds = conn.ShowDataBases().Split(',');

            foreach (var bd in bds)
            {
                cmbdata.Items.Add(bd);
            }
            cmbdata.Visible = true;
        }

        private void cmbdata_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbtable.Items.Clear();
            MessageBox.Show("se agregaron las tablas al combo box" + cmbdata.SelectedItem.ToString());
            conn.Use(cmbdata.SelectedItem.ToString());
            string[] tables = conn.ShowTables(cmbdata.SelectedItem.ToString()).Split(',');

            foreach (var table in tables)
            {
                cmbtable.Items.Add(table);
            }
            cmbtable.Visible = true;
        }

        private void cmbtable_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbcolumns.Items.Clear();
            MessageBox.Show("se agregaron las tablas al combo box" + cmbtable.SelectedItem.ToString());
            conn.Use(cmbdata.SelectedItem.ToString());
            string[] columns = conn.ShowColumns(cmbdata.SelectedItem.ToString(), cmbtable.SelectedItem.ToString()).Split(',');

            foreach (var column in columns)
            {
                cmbcolumns.Items.Add(column);
            }
            cmbcolumns.Visible = true;
        }

        private void cmbcolumns_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.FillGrid(dataExpences, cmbtable.SelectedItem.ToString());
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Reporte";
            printer.SubTitle = string.Format("Dia: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dataExpences);
        }

    }
}
