namespace Ventas_Jairo
{
    partial class FrmEliminarOficina
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
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOficina = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNum_Rep_Dir = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btmEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(299, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 28);
            this.label7.TabIndex = 7;
            this.label7.Text = "Eliminar Oficina";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(519, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ingresa Los siguientes datos para ELIMINAR la oficina.";
            // 
            // txtOficina
            // 
            this.txtOficina.Location = new System.Drawing.Point(304, 117);
            this.txtOficina.Name = "txtOficina";
            this.txtOficina.Size = new System.Drawing.Size(100, 22);
            this.txtOficina.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(172, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Numero de Oficina";
            // 
            // txtNum_Rep_Dir
            // 
            this.txtNum_Rep_Dir.Location = new System.Drawing.Point(359, 177);
            this.txtNum_Rep_Dir.Name = "txtNum_Rep_Dir";
            this.txtNum_Rep_Dir.Size = new System.Drawing.Size(100, 22);
            this.txtNum_Rep_Dir.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Numero Representante Dir.";
            // 
            // btmEliminar
            // 
            this.btmEliminar.Location = new System.Drawing.Point(304, 250);
            this.btmEliminar.Name = "btmEliminar";
            this.btmEliminar.Size = new System.Drawing.Size(212, 45);
            this.btmEliminar.TabIndex = 17;
            this.btmEliminar.Text = "ELIMINAR";
            this.btmEliminar.UseVisualStyleBackColor = true;
            this.btmEliminar.Click += new System.EventHandler(this.btmEliminar_Click);
            // 
            // FrmEliminarOficina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 356);
            this.Controls.Add(this.btmEliminar);
            this.Controls.Add(this.txtNum_Rep_Dir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOficina);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Name = "FrmEliminarOficina";
            this.Text = "FrmEliminarOficina";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOficina;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNum_Rep_Dir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btmEliminar;
    }
}