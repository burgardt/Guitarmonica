namespace ArmonicaAGuitarra
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTab = new System.Windows.Forms.Label();
            this.txtArmoAcord = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnNivel2 = new System.Windows.Forms.Button();
            this.btnNivel1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTab
            // 
            this.lblTab.AutoSize = true;
            this.lblTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTab.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTab.Location = new System.Drawing.Point(16, 114);
            this.lblTab.Name = "lblTab";
            this.lblTab.Size = new System.Drawing.Size(32, 24);
            this.lblTab.TabIndex = 1;
            this.lblTab.Text = "e-";
            // 
            // txtArmoAcord
            // 
            this.txtArmoAcord.Location = new System.Drawing.Point(180, 13);
            this.txtArmoAcord.Multiline = true;
            this.txtArmoAcord.Name = "txtArmoAcord";
            this.txtArmoAcord.Size = new System.Drawing.Size(697, 17);
            this.txtArmoAcord.TabIndex = 2;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(13, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(161, 16);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Ingrese acordes armónica:";
            // 
            // btnNivel2
            // 
            this.btnNivel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNivel2.Location = new System.Drawing.Point(103, 54);
            this.btnNivel2.Name = "btnNivel2";
            this.btnNivel2.Size = new System.Drawing.Size(71, 43);
            this.btnNivel2.TabIndex = 4;
            this.btnNivel2.Text = "Nivel 2 [Agudo]";
            this.btnNivel2.UseVisualStyleBackColor = true;
            this.btnNivel2.Click += new System.EventHandler(this.btnNivel2_Click);
            // 
            // btnNivel1
            // 
            this.btnNivel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNivel1.Location = new System.Drawing.Point(16, 54);
            this.btnNivel1.Name = "btnNivel1";
            this.btnNivel1.Size = new System.Drawing.Size(81, 43);
            this.btnNivel1.TabIndex = 5;
            this.btnNivel1.Text = "Nivel 1\r\n[Grave]";
            this.btnNivel1.UseVisualStyleBackColor = true;
            this.btnNivel1.Click += new System.EventHandler(this.btnNivel1_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(889, 292);
            this.Controls.Add(this.btnNivel1);
            this.Controls.Add(this.btnNivel2);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtArmoAcord);
            this.Controls.Add(this.lblTab);
            this.Name = "frmPrincipal";
            this.Text = "Armonica a Guitarra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private System.Windows.Forms.Label lblPrueba;
        private System.Windows.Forms.Label lblTab;
        private System.Windows.Forms.TextBox txtArmoAcord;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnNivel2;
        private System.Windows.Forms.Button btnNivel1;
    }
}

