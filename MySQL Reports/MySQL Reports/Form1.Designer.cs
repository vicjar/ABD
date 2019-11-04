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
            this.MAXIMIZAR = new System.Windows.Forms.PictureBox();
            this.MINIMIZAR = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SALIR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MAXIMIZAR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MINIMIZAR)).BeginInit();
            this.SuspendLayout();
            // 
            // SALIR
            // 
            this.SALIR.Image = ((System.Drawing.Image)(resources.GetObject("SALIR.Image")));
            this.SALIR.Location = new System.Drawing.Point(1167, 33);
            this.SALIR.Name = "SALIR";
            this.SALIR.Size = new System.Drawing.Size(58, 46);
            this.SALIR.TabIndex = 34;
            this.SALIR.TabStop = false;
            this.SALIR.Click += new System.EventHandler(this.SALIR_Click);
            // 
            // MAXIMIZAR
            // 
            this.MAXIMIZAR.Image = ((System.Drawing.Image)(resources.GetObject("MAXIMIZAR.Image")));
            this.MAXIMIZAR.Location = new System.Drawing.Point(1098, 33);
            this.MAXIMIZAR.Name = "MAXIMIZAR";
            this.MAXIMIZAR.Size = new System.Drawing.Size(63, 46);
            this.MAXIMIZAR.TabIndex = 33;
            this.MAXIMIZAR.TabStop = false;
            this.MAXIMIZAR.Click += new System.EventHandler(this.MAXIMIZAR_Click);
            // 
            // MINIMIZAR
            // 
            this.MINIMIZAR.Image = ((System.Drawing.Image)(resources.GetObject("MINIMIZAR.Image")));
            this.MINIMIZAR.Location = new System.Drawing.Point(1038, 33);
            this.MINIMIZAR.Name = "MINIMIZAR";
            this.MINIMIZAR.Size = new System.Drawing.Size(73, 46);
            this.MINIMIZAR.TabIndex = 32;
            this.MINIMIZAR.TabStop = false;
            this.MINIMIZAR.Click += new System.EventHandler(this.MINIMIZAR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1256, 638);
            this.Controls.Add(this.SALIR);
            this.Controls.Add(this.MAXIMIZAR);
            this.Controls.Add(this.MINIMIZAR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.SALIR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MAXIMIZAR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MINIMIZAR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox SALIR;
        private System.Windows.Forms.PictureBox MAXIMIZAR;
        private System.Windows.Forms.PictureBox MINIMIZAR;
    }
}

