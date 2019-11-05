namespace MySQL_Reports
{
    partial class Pantalla2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pantalla2));
            this.dataExpences = new System.Windows.Forms.DataGridView();
            this.SAVE = new System.Windows.Forms.Button();
            this.SALIR = new System.Windows.Forms.PictureBox();
            this.MINIMIZAR = new System.Windows.Forms.PictureBox();
            this.shape = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lbltitle = new System.Windows.Forms.Label();
            this.btntable = new System.Windows.Forms.Button();
            this.btndata = new System.Windows.Forms.Button();
            this.cmbdata = new System.Windows.Forms.ComboBox();
            this.cmbtable = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataExpences)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SALIR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MINIMIZAR)).BeginInit();
            this.SuspendLayout();
            // 
            // dataExpences
            // 
            this.dataExpences.AllowUserToAddRows = false;
            this.dataExpences.AllowUserToDeleteRows = false;
            this.dataExpences.AllowUserToResizeColumns = false;
            this.dataExpences.AllowUserToResizeRows = false;
            this.dataExpences.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataExpences.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataExpences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataExpences.Location = new System.Drawing.Point(34, 288);
            this.dataExpences.Name = "dataExpences";
            this.dataExpences.ReadOnly = true;
            this.dataExpences.RowHeadersVisible = false;
            this.dataExpences.RowHeadersWidth = 51;
            this.dataExpences.RowTemplate.Height = 24;
            this.dataExpences.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataExpences.Size = new System.Drawing.Size(1179, 263);
            this.dataExpences.TabIndex = 77;
            this.dataExpences.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataExpences_CellContentClick);
            // 
            // SAVE
            // 
            this.SAVE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.SAVE.FlatAppearance.BorderSize = 0;
            this.SAVE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.SAVE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SAVE.ForeColor = System.Drawing.Color.Gainsboro;
            this.SAVE.Location = new System.Drawing.Point(1003, 579);
            this.SAVE.Name = "SAVE";
            this.SAVE.Size = new System.Drawing.Size(210, 37);
            this.SAVE.TabIndex = 78;
            this.SAVE.Text = "SAVE";
            this.SAVE.UseVisualStyleBackColor = false;
            // 
            // SALIR
            // 
            this.SALIR.Image = ((System.Drawing.Image)(resources.GetObject("SALIR.Image")));
            this.SALIR.Location = new System.Drawing.Point(1152, 27);
            this.SALIR.Name = "SALIR";
            this.SALIR.Size = new System.Drawing.Size(61, 46);
            this.SALIR.TabIndex = 80;
            this.SALIR.TabStop = false;
            // 
            // MINIMIZAR
            // 
            this.MINIMIZAR.Image = ((System.Drawing.Image)(resources.GetObject("MINIMIZAR.Image")));
            this.MINIMIZAR.Location = new System.Drawing.Point(1106, 27);
            this.MINIMIZAR.Name = "MINIMIZAR";
            this.MINIMIZAR.Size = new System.Drawing.Size(76, 46);
            this.MINIMIZAR.TabIndex = 79;
            this.MINIMIZAR.TabStop = false;
            // 
            // shape
            // 
            this.shape.BorderColor = System.Drawing.Color.DimGray;
            this.shape.Location = new System.Drawing.Point(34, 67);
            this.shape.Name = "shape";
            this.shape.Size = new System.Drawing.Size(316, 53);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.shape});
            this.shapeContainer1.Size = new System.Drawing.Size(1251, 652);
            this.shapeContainer1.TabIndex = 81;
            this.shapeContainer1.TabStop = false;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Candara Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.DimGray;
            this.lbltitle.Location = new System.Drawing.Point(80, 76);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(203, 35);
            this.lbltitle.TabIndex = 82;
            this.lbltitle.Text = "MYSQL REPORT";
            // 
            // btntable
            // 
            this.btntable.BackColor = System.Drawing.Color.Transparent;
            this.btntable.FlatAppearance.BorderSize = 0;
            this.btntable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btntable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btntable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntable.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntable.ForeColor = System.Drawing.Color.DimGray;
            this.btntable.Location = new System.Drawing.Point(-36, 208);
            this.btntable.Name = "btntable";
            this.btntable.Size = new System.Drawing.Size(210, 37);
            this.btntable.TabIndex = 83;
            this.btntable.Text = "TABLES";
            this.btntable.UseVisualStyleBackColor = false;
            // 
            // btndata
            // 
            this.btndata.BackColor = System.Drawing.Color.Transparent;
            this.btndata.FlatAppearance.BorderSize = 0;
            this.btndata.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btndata.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btndata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndata.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndata.ForeColor = System.Drawing.Color.DimGray;
            this.btndata.Location = new System.Drawing.Point(-19, 165);
            this.btndata.Name = "btndata";
            this.btndata.Size = new System.Drawing.Size(210, 37);
            this.btndata.TabIndex = 84;
            this.btndata.Text = "DATABASES";
            this.btndata.UseVisualStyleBackColor = false;
            this.btndata.Click += new System.EventHandler(this.Btndata_Click);
            // 
            // cmbdata
            // 
            this.cmbdata.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbdata.FormattingEnabled = true;
            this.cmbdata.Location = new System.Drawing.Point(162, 174);
            this.cmbdata.Name = "cmbdata";
            this.cmbdata.Size = new System.Drawing.Size(189, 24);
            this.cmbdata.TabIndex = 85;
            // 
            // cmbtable
            // 
            this.cmbtable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtable.FormattingEnabled = true;
            this.cmbtable.Location = new System.Drawing.Point(162, 208);
            this.cmbtable.Name = "cmbtable";
            this.cmbtable.Size = new System.Drawing.Size(189, 24);
            this.cmbtable.TabIndex = 86;
            // 
            // Pantalla2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1251, 652);
            this.Controls.Add(this.cmbtable);
            this.Controls.Add(this.cmbdata);
            this.Controls.Add(this.btndata);
            this.Controls.Add(this.btntable);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.SALIR);
            this.Controls.Add(this.MINIMIZAR);
            this.Controls.Add(this.SAVE);
            this.Controls.Add(this.dataExpences);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pantalla2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla2";
            this.Load += new System.EventHandler(this.Pantalla2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataExpences)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SALIR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MINIMIZAR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataExpences;
        private System.Windows.Forms.Button SAVE;
        private System.Windows.Forms.PictureBox SALIR;
        private System.Windows.Forms.PictureBox MINIMIZAR;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape shape;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Button btntable;
        private System.Windows.Forms.Button btndata;
        private System.Windows.Forms.ComboBox cmbdata;
        private System.Windows.Forms.ComboBox cmbtable;
    }
}