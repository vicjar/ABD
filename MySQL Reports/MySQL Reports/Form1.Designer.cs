namespace MySQL_Reports
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SALIR = new System.Windows.Forms.PictureBox();
            this.MINIMIZAR = new System.Windows.Forms.PictureBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.btnlog = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.line2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.line = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shape = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.lbltitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SALIR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MINIMIZAR)).BeginInit();
            this.SuspendLayout();
            // 
            // SALIR
            // 
            this.SALIR.Image = ((System.Drawing.Image)(resources.GetObject("SALIR.Image")));
            this.SALIR.Location = new System.Drawing.Point(763, 12);
            this.SALIR.Name = "SALIR";
            this.SALIR.Size = new System.Drawing.Size(58, 46);
            this.SALIR.TabIndex = 34;
            this.SALIR.TabStop = false;
            this.SALIR.Click += new System.EventHandler(this.SALIR_Click);
            // 
            // MINIMIZAR
            // 
            this.MINIMIZAR.Image = ((System.Drawing.Image)(resources.GetObject("MINIMIZAR.Image")));
            this.MINIMIZAR.Location = new System.Drawing.Point(717, 12);
            this.MINIMIZAR.Name = "MINIMIZAR";
            this.MINIMIZAR.Size = new System.Drawing.Size(73, 46);
            this.MINIMIZAR.TabIndex = 32;
            this.MINIMIZAR.TabStop = false;
            this.MINIMIZAR.Click += new System.EventHandler(this.MINIMIZAR_Click);
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpass.Font = new System.Drawing.Font("Candara Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.ForeColor = System.Drawing.Color.DimGray;
            this.txtpass.Location = new System.Drawing.Point(106, 257);
            this.txtpass.Multiline = true;
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(481, 30);
            this.txtpass.TabIndex = 37;
            this.txtpass.Text = "PASSWORD";
            this.txtpass.Enter += new System.EventHandler(this.Tatpass_Enter);
            this.txtpass.Leave += new System.EventHandler(this.Tatpass_Leave);
            // 
            // txtuser
            // 
            this.txtuser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtuser.Font = new System.Drawing.Font("Candara Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.ForeColor = System.Drawing.Color.DimGray;
            this.txtuser.Location = new System.Drawing.Point(106, 193);
            this.txtuser.Multiline = true;
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(481, 30);
            this.txtuser.TabIndex = 36;
            this.txtuser.Text = "USER";
            this.txtuser.Enter += new System.EventHandler(this.Txtuser_Enter);
            this.txtuser.Leave += new System.EventHandler(this.Txtuser_Leave);
            // 
            // btnlog
            // 
            this.btnlog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnlog.FlatAppearance.BorderSize = 0;
            this.btnlog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnlog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnlog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlog.ForeColor = System.Drawing.Color.DimGray;
            this.btnlog.Location = new System.Drawing.Point(599, 372);
            this.btnlog.Name = "btnlog";
            this.btnlog.Size = new System.Drawing.Size(207, 37);
            this.btnlog.TabIndex = 35;
            this.btnlog.Text = "LOG IN";
            this.btnlog.UseVisualStyleBackColor = false;
            this.btnlog.Click += new System.EventHandler(this.Btnlog_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.line2,
            this.line,
            this.shape});
            this.shapeContainer1.Size = new System.Drawing.Size(859, 459);
            this.shapeContainer1.TabIndex = 38;
            this.shapeContainer1.TabStop = false;
            // 
            // line2
            // 
            this.line2.BorderColor = System.Drawing.Color.DimGray;
            this.line2.Name = "line2";
            this.line2.X1 = 438;
            this.line2.X2 = 80;
            this.line2.Y1 = 234;
            this.line2.Y2 = 234;
            // 
            // line
            // 
            this.line.BorderColor = System.Drawing.Color.DimGray;
            this.line.Name = "line";
            this.line.X1 = 438;
            this.line.X2 = 80;
            this.line.Y1 = 181;
            this.line.Y2 = 181;
            // 
            // shape
            // 
            this.shape.BorderColor = System.Drawing.Color.DimGray;
            this.shape.Location = new System.Drawing.Point(43, 46);
            this.shape.Name = "shape";
            this.shape.Size = new System.Drawing.Size(165, 53);
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Candara Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.DimGray;
            this.lbltitle.Location = new System.Drawing.Point(121, 72);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(104, 35);
            this.lbltitle.TabIndex = 70;
            this.lbltitle.Text = "LOG IN ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(859, 459);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.btnlog);
            this.Controls.Add(this.SALIR);
            this.Controls.Add(this.MINIMIZAR);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.SALIR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MINIMIZAR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox SALIR;
        private System.Windows.Forms.PictureBox MINIMIZAR;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Button btnlog;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape line2;
        private Microsoft.VisualBasic.PowerPacks.LineShape line;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape shape;
        private System.Windows.Forms.Label lbltitle;
    }
}

