namespace Ventas_Jairo
{
    partial class FrmActualizarClientes
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnumClie = new System.Windows.Forms.TextBox();
            this.txtEmp = new System.Windows.Forms.TextBox();
            this.txtNum_Rep = new System.Windows.Forms.TextBox();
            this.txtLim = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero del Cliente";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Empresa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero de Representante";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Limite de Credito";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(93, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(722, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ingresa los siguientes datos para actualizar los datos del cliente:";
            // 
            // txtnumClie
            // 
            this.txtnumClie.Location = new System.Drawing.Point(315, 193);
            this.txtnumClie.Name = "txtnumClie";
            this.txtnumClie.Size = new System.Drawing.Size(236, 22);
            this.txtnumClie.TabIndex = 5;
            // 
            // txtEmp
            // 
            this.txtEmp.Location = new System.Drawing.Point(315, 250);
            this.txtEmp.Name = "txtEmp";
            this.txtEmp.Size = new System.Drawing.Size(236, 22);
            this.txtEmp.TabIndex = 6;
            // 
            // txtNum_Rep
            // 
            this.txtNum_Rep.Location = new System.Drawing.Point(315, 311);
            this.txtNum_Rep.Name = "txtNum_Rep";
            this.txtNum_Rep.Size = new System.Drawing.Size(236, 22);
            this.txtNum_Rep.TabIndex = 7;
            // 
            // txtLim
            // 
            this.txtLim.Location = new System.Drawing.Point(315, 386);
            this.txtLim.Name = "txtLim";
            this.txtLim.Size = new System.Drawing.Size(125, 22);
            this.txtLim.TabIndex = 8;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(388, 502);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(352, 48);
            this.btnActualizar.TabIndex = 9;
            this.btnActualizar.Text = "Actualizar Cliente";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // FrmActualizarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 661);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtLim);
            this.Controls.Add(this.txtNum_Rep);
            this.Controls.Add(this.txtEmp);
            this.Controls.Add(this.txtnumClie);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmActualizarClientes";
            this.Text = "FrmActualizarClientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnumClie;
        private System.Windows.Forms.TextBox txtEmp;
        private System.Windows.Forms.TextBox txtNum_Rep;
        private System.Windows.Forms.TextBox txtLim;
        private System.Windows.Forms.Button btnActualizar;
    }
}