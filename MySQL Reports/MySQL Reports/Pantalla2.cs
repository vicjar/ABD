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
        string user, pass;
        public Pantalla2(string user, string pass)
        {
            InitializeComponent();
            this.user = user;
            this.pass = pass;
            conexion(user, pass);
            
        }

        private void conexion(string user, string pass)
        {
            conn.OpenConn("127.0.0.1", "3306", user, pass, "sakila");

            cmbtable.Items.Clear();

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
            conn.FillGrid(dataExpences, cmbtable.SelectedItem.ToString(), cmbcolumns.SelectedItem.ToString());
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
        private void Btntable_Click(object sender, EventArgs e)
        {
        }
        private void Btndata_Click(object sender, EventArgs e)
        {
            cmbdata.Visible = true;
        }

        private void TxtFiltrar_TextChanged(object sender, EventArgs e)
        {
            if (txtFiltrar.Text != "")
            {
                dataExpences.CurrentCell = null;

                foreach (DataGridViewRow r in dataExpences.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dataExpences.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString().ToUpper()).IndexOf(txtFiltrar.Text.ToUpper()) == 0)
                        {
                            r.Visible = true;
                            break;
                        }

                    }
                }
            }
        }

        private void TxtFiltrar_Enter(object sender, EventArgs e)
        {
            if (txtFiltrar.Text == " FILTER")
            {
                txtFiltrar.Text = "";
                txtFiltrar.ForeColor = Color.White;
            }
        }

        private void TxtFiltrar_Leave(object sender, EventArgs e)
        {
            if (txtFiltrar.Text == "")
            {
                txtFiltrar.Text = " FILTER";
                txtFiltrar.ForeColor = Color.DimGray;
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

        private void DataExpences_CellContentClick(object sender, DataGridViewCellEventArgs e) {

            dataExpences.Columns.RemoveAt(e.ColumnIndex);
        }
        private void Pantalla2_Load(object sender, EventArgs e)  { }
        private void RectangleShape1_Click(object sender, EventArgs e) { }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            conn.refresh(dataExpences, cmbtable.SelectedItem.ToString());
            
        }
    }
}
