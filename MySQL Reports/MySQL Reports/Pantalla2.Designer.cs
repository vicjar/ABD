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
            this.btnprint = new System.Windows.Forms.Button();
            this.SALIR = new System.Windows.Forms.PictureBox();
            this.MINIMIZAR = new System.Windows.Forms.PictureBox();
            this.lbltitle = new System.Windows.Forms.Label();
            this.btntable = new System.Windows.Forms.Button();
            this.btndata = new System.Windows.Forms.Button();
            this.cmbdata = new System.Windows.Forms.ComboBox();
            this.cmbtable = new System.Windows.Forms.ComboBox();
            this.cmbcolumns = new System.Windows.Forms.ComboBox();
            this.COLUMNS = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.txtFiltrar = new System.Windows.Forms.TextBox();
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
            this.dataExpences.Location = new System.Drawing.Point(35, 311);
            this.dataExpences.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataExpences.Name = "dataExpences";
            this.dataExpences.ReadOnly = true;
            this.dataExpences.RowHeadersVisible = false;
            this.dataExpences.RowHeadersWidth = 51;
            this.dataExpences.RowTemplate.Height = 24;
            this.dataExpences.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataExpences.Size = new System.Drawing.Size(1191, 263);
            this.dataExpences.TabIndex = 77;
            this.dataExpences.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataExpences_CellContentClick);
            // 
            // btnprint
            // 
            this.btnprint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnprint.FlatAppearance.BorderSize = 0;
            this.btnprint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnprint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprint.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnprint.Location = new System.Drawing.Point(1015, 589);
            this.btnprint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(211, 37);
            this.btnprint.TabIndex = 78;
            this.btnprint.Text = "PRINT";
            this.btnprint.UseVisualStyleBackColor = false;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // SALIR
            // 
            this.SALIR.Image = ((System.Drawing.Image)(resources.GetObject("SALIR.Image")));
            this.SALIR.Location = new System.Drawing.Point(1186, 13);
            this.SALIR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SALIR.Name = "SALIR";
            this.SALIR.Size = new System.Drawing.Size(61, 46);
            this.SALIR.TabIndex = 80;
            this.SALIR.TabStop = false;
            this.SALIR.Click += new System.EventHandler(this.SALIR_Click);
            // 
            // MINIMIZAR
            // 
            this.MINIMIZAR.Image = ((System.Drawing.Image)(resources.GetObject("MINIMIZAR.Image")));
            this.MINIMIZAR.Location = new System.Drawing.Point(1141, 13);
            this.MINIMIZAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MINIMIZAR.Name = "MINIMIZAR";
            this.MINIMIZAR.Size = new System.Drawing.Size(76, 46);
            this.MINIMIZAR.TabIndex = 79;
            this.MINIMIZAR.TabStop = false;
            this.MINIMIZAR.Click += new System.EventHandler(this.MINIMIZAR_Click);
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lbltitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbltitle.Location = new System.Drawing.Point(571, 70);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(154, 23);
            this.lbltitle.TabIndex = 82;
            this.lbltitle.Text = "MYSQL REPORT";
            // 
            // btntable
            // 
            this.btntable.AutoSize = true;
            this.btntable.BackColor = System.Drawing.Color.Transparent;
            this.btntable.FlatAppearance.BorderSize = 0;
            this.btntable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btntable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btntable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntable.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntable.ForeColor = System.Drawing.Color.DimGray;
            this.btntable.Location = new System.Drawing.Point(-28, 157);
            this.btntable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btntable.Name = "btntable";
            this.btntable.Size = new System.Drawing.Size(211, 37);
            this.btntable.TabIndex = 83;
            this.btntable.Text = "TABLES";
            this.btntable.UseVisualStyleBackColor = false;
            this.btntable.Click += new System.EventHandler(this.Btntable_Click);
            // 
            // btndata
            // 
            this.btndata.AutoSize = true;
            this.btndata.BackColor = System.Drawing.Color.Transparent;
            this.btndata.FlatAppearance.BorderSize = 0;
            this.btndata.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btndata.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btndata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndata.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndata.ForeColor = System.Drawing.Color.DimGray;
            this.btndata.Location = new System.Drawing.Point(-9, 114);
            this.btndata.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btndata.Name = "btndata";
            this.btndata.Size = new System.Drawing.Size(211, 37);
            this.btndata.TabIndex = 84;
            this.btndata.Text = "DATABASES";
            this.btndata.UseVisualStyleBackColor = false;
            this.btndata.Click += new System.EventHandler(this.Btndata_Click);
            // 
            // cmbdata
            // 
            this.cmbdata.BackColor = System.Drawing.Color.Black;
            this.cmbdata.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbdata.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbdata.ForeColor = System.Drawing.Color.White;
            this.cmbdata.FormattingEnabled = true;
            this.cmbdata.Location = new System.Drawing.Point(208, 122);
            this.cmbdata.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbdata.Name = "cmbdata";
            this.cmbdata.Size = new System.Drawing.Size(189, 28);
            this.cmbdata.TabIndex = 85;
            this.cmbdata.Visible = false;
            this.cmbdata.SelectedIndexChanged += new System.EventHandler(this.cmbdata_SelectedIndexChanged);
            // 
            // cmbtable
            // 
            this.cmbtable.BackColor = System.Drawing.Color.Black;
            this.cmbtable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtable.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbtable.ForeColor = System.Drawing.Color.White;
            this.cmbtable.FormattingEnabled = true;
            this.cmbtable.Location = new System.Drawing.Point(208, 160);
            this.cmbtable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbtable.Name = "cmbtable";
            this.cmbtable.Size = new System.Drawing.Size(189, 28);
            this.cmbtable.TabIndex = 86;
            this.cmbtable.Visible = false;
            this.cmbtable.SelectedIndexChanged += new System.EventHandler(this.cmbtable_SelectedIndexChanged);
            // 
            // cmbcolumns
            // 
            this.cmbcolumns.BackColor = System.Drawing.Color.Black;
            this.cmbcolumns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcolumns.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcolumns.ForeColor = System.Drawing.Color.White;
            this.cmbcolumns.FormattingEnabled = true;
            this.cmbcolumns.Location = new System.Drawing.Point(208, 198);
            this.cmbcolumns.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbcolumns.Name = "cmbcolumns";
            this.cmbcolumns.Size = new System.Drawing.Size(189, 28);
            this.cmbcolumns.TabIndex = 89;
            this.cmbcolumns.Visible = false;
            this.cmbcolumns.SelectedIndexChanged += new System.EventHandler(this.cmbcolumns_SelectedIndexChanged);
            // 
            // COLUMNS
            // 
            this.COLUMNS.AutoSize = true;
            this.COLUMNS.BackColor = System.Drawing.Color.Transparent;
            this.COLUMNS.FlatAppearance.BorderSize = 0;
            this.COLUMNS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.COLUMNS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.COLUMNS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.COLUMNS.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COLUMNS.ForeColor = System.Drawing.Color.DimGray;
            this.COLUMNS.Location = new System.Drawing.Point(-17, 198);
            this.COLUMNS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.COLUMNS.Name = "COLUMNS";
            this.COLUMNS.Size = new System.Drawing.Size(211, 37);
            this.COLUMNS.TabIndex = 88;
            this.COLUMNS.Text = "COLUMNS";
            this.COLUMNS.UseVisualStyleBackColor = false;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1251, 652);
            this.shapeContainer1.TabIndex = 90;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.rectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape1.Location = new System.Drawing.Point(-9, 53);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(1138, 29);
            this.rectangleShape1.Click += new System.EventHandler(this.RectangleShape1_Click);
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtFiltrar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFiltrar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltrar.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtFiltrar.Location = new System.Drawing.Point(35, 263);
            this.txtFiltrar.Multiline = true;
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(362, 29);
            this.txtFiltrar.TabIndex = 92;
            this.txtFiltrar.Text = " FILTER";
            this.txtFiltrar.TextChanged += new System.EventHandler(this.TxtFiltrar_TextChanged);
            this.txtFiltrar.Enter += new System.EventHandler(this.TxtFiltrar_Enter);
            this.txtFiltrar.Leave += new System.EventHandler(this.TxtFiltrar_Leave);
            // 
            // Pantalla2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1251, 652);
            this.Controls.Add(this.txtFiltrar);
            this.Controls.Add(this.cmbcolumns);
            this.Controls.Add(this.COLUMNS);
            this.Controls.Add(this.cmbtable);
            this.Controls.Add(this.cmbdata);
            this.Controls.Add(this.btndata);
            this.Controls.Add(this.btntable);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.SALIR);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.dataExpences);
            this.Controls.Add(this.MINIMIZAR);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Pantalla2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Pantalla2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataExpences)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SALIR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MINIMIZAR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataExpences;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.PictureBox SALIR;
        private System.Windows.Forms.PictureBox MINIMIZAR;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Button btntable;
        private System.Windows.Forms.Button btndata;
        private System.Windows.Forms.ComboBox cmbdata;
        private System.Windows.Forms.ComboBox cmbtable;
        private System.Windows.Forms.ComboBox cmbcolumns;
        private System.Windows.Forms.Button COLUMNS;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.TextBox txtFiltrar;
    }
}