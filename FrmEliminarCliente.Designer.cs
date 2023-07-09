namespace Ventas_Jairo
{
    partial class FrmEliminarCliente
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
            this.label4 = new System.Windows.Forms.Label();
            this.Num_Rep = new System.Windows.Forms.TextBox();
            this.txtNumClie = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(490, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresa Los datos para eliminar a un cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero del Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Numero de Representante";
            // 
            // Num_Rep
            // 
            this.Num_Rep.Location = new System.Drawing.Point(309, 290);
            this.Num_Rep.Name = "Num_Rep";
            this.Num_Rep.Size = new System.Drawing.Size(166, 22);
            this.Num_Rep.TabIndex = 4;
            this.Num_Rep.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNumClie
            // 
            this.txtNumClie.Location = new System.Drawing.Point(309, 224);
            this.txtNumClie.Name = "txtNumClie";
            this.txtNumClie.Size = new System.Drawing.Size(166, 22);
            this.txtNumClie.TabIndex = 5;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(376, 379);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(325, 56);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // FrmEliminarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 492);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtNumClie);
            this.Controls.Add(this.Num_Rep);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmEliminarCliente";
            this.Text = "FrmEliminarCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Num_Rep;
        private System.Windows.Forms.TextBox txtNumClie;
        private System.Windows.Forms.Button btnEliminar;
    }
}