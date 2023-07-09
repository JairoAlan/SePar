namespace Ventas_Jairo
{
    partial class FrmPagos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumCli = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_limCred = new System.Windows.Forms.Label();
            this.Buscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pagos Del Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero de Cliente";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNumCli
            // 
            this.txtNumCli.Location = new System.Drawing.Point(198, 55);
            this.txtNumCli.Name = "txtNumCli";
            this.txtNumCli.Size = new System.Drawing.Size(100, 22);
            this.txtNumCli.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Limite de Credito Del Cliente";
            // 
            // lbl_limCred
            // 
            this.lbl_limCred.AutoSize = true;
            this.lbl_limCred.Location = new System.Drawing.Point(245, 108);
            this.lbl_limCred.Name = "lbl_limCred";
            this.lbl_limCred.Size = new System.Drawing.Size(17, 16);
            this.lbl_limCred.TabIndex = 4;
            this.lbl_limCred.Text = "\"\"";
            this.lbl_limCred.Click += new System.EventHandler(this.lbl_limCred_Click);
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(353, 58);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 23);
            this.Buscar.TabIndex = 5;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // FrmPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.lbl_limCred);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumCli);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmPagos";
            this.Text = "FrmPagos";
            this.Load += new System.EventHandler(this.FrmPagos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumCli;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_limCred;
        private System.Windows.Forms.Button Buscar;
    }
}