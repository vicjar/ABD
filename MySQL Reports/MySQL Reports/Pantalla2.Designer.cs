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
            this.dataExpences = new System.Windows.Forms.DataGridView();
            this.CDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCANT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SAVE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataExpences)).BeginInit();
            this.SuspendLayout();
            // 
            // dataExpences
            // 
            this.dataExpences.AllowUserToAddRows = false;
            this.dataExpences.AllowUserToDeleteRows = false;
            this.dataExpences.AllowUserToResizeColumns = false;
            this.dataExpences.AllowUserToResizeRows = false;
            this.dataExpences.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataExpences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataExpences.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CDATE,
            this.CDES,
            this.CCANT});
            this.dataExpences.Location = new System.Drawing.Point(68, 254);
            this.dataExpences.Name = "dataExpences";
            this.dataExpences.ReadOnly = true;
            this.dataExpences.RowHeadersVisible = false;
            this.dataExpences.RowHeadersWidth = 51;
            this.dataExpences.RowTemplate.Height = 24;
            this.dataExpences.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataExpences.Size = new System.Drawing.Size(884, 294);
            this.dataExpences.TabIndex = 77;
            // 
            // CDATE
            // 
            this.CDATE.HeaderText = "DATE";
            this.CDATE.MinimumWidth = 6;
            this.CDATE.Name = "CDATE";
            this.CDATE.ReadOnly = true;
            this.CDATE.Width = 180;
            // 
            // CDES
            // 
            this.CDES.HeaderText = "DESCRIPTION";
            this.CDES.MinimumWidth = 6;
            this.CDES.Name = "CDES";
            this.CDES.ReadOnly = true;
            this.CDES.Width = 400;
            // 
            // CCANT
            // 
            this.CCANT.HeaderText = "AMOUNT";
            this.CCANT.MinimumWidth = 6;
            this.CCANT.Name = "CCANT";
            this.CCANT.ReadOnly = true;
            this.CCANT.Width = 300;
            // 
            // SAVE
            // 
            this.SAVE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.SAVE.FlatAppearance.BorderSize = 0;
            this.SAVE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.SAVE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SAVE.ForeColor = System.Drawing.Color.Gainsboro;
            this.SAVE.Location = new System.Drawing.Point(941, 568);
            this.SAVE.Name = "SAVE";
            this.SAVE.Size = new System.Drawing.Size(210, 37);
            this.SAVE.TabIndex = 78;
            this.SAVE.Text = "SAVE";
            this.SAVE.UseVisualStyleBackColor = false;
            // 
            // Pantalla2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 631);
            this.Controls.Add(this.SAVE);
            this.Controls.Add(this.dataExpences);
            this.Name = "Pantalla2";
            this.Text = "Pantalla2";
            ((System.ComponentModel.ISupportInitialize)(this.dataExpences)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataExpences;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDES;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCANT;
        private System.Windows.Forms.Button SAVE;
    }
}