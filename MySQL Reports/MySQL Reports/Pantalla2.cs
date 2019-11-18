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
            PrintDocument doc = new PrintDocument();
            doc.DefaultPageSettings.Landscape = true;
            doc.PrinterSettings.PrinterName = "Microsoft Print to PDF";

            PrintPreviewDialog ppd = new PrintPreviewDialog { Document = doc };
            ((Form)ppd).WindowState = FormWindowState.Maximized;

            doc.PrintPage += delegate (object ev, PrintPageEventArgs ep)
            {
                const int DGV_ALTO = 35;
                int left = ep.MarginBounds.Left, top = ep.MarginBounds.Top;

                foreach (DataGridViewColumn col in dataExpences.Columns)
                {
                    ep.Graphics.DrawString(col.HeaderText, new Font("Segoe UI", 16, FontStyle.Bold), Brushes.DeepSkyBlue, left, top);
                    left += col.Width;

                    if (col.Index < dataExpences.ColumnCount - 1)
                        ep.Graphics.DrawLine(Pens.Gray, left - 5, top, left - 5, top + 43 + (dataExpences.RowCount - 1) * DGV_ALTO);
                }
                left = ep.MarginBounds.Left;
                ep.Graphics.FillRectangle(Brushes.Black, left, top + 40, ep.MarginBounds.Right - left, 3);
                top += 43;

                foreach (DataGridViewRow row in dataExpences.Rows)
                {
                    if (row.Index == dataExpences.RowCount - 1) break;
                    left = ep.MarginBounds.Left;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        ep.Graphics.DrawString(Convert.ToString(cell.Value), new Font("Segoe UI", 13), Brushes.Black, left, top + 4);
                        left += cell.OwningColumn.Width;
                    }
                    top += DGV_ALTO;
                    ep.Graphics.DrawLine(Pens.Gray, ep.MarginBounds.Left, top, ep.MarginBounds.Right, top);
                }
            };
            ppd.ShowDialog();
        }

    }
}
