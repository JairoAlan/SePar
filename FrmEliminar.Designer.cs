namespace Ventas_Jairo
{
    partial class FrmEliminar
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
            this.lbllDFab = new System.Windows.Forms.Label();
            this.lbllDProd = new System.Windows.Forms.Label();
            this.lblExi = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbIDFab = new System.Windows.Forms.ComboBox();
            this.cmbIDProd = new System.Windows.Forms.ComboBox();
            this.IbIStatus = new System.Windows.Forms.Label();
            this.btmEliminar = new System.Windows.Forms.Button();
            this.nudExi = new System.Windows.Forms.NumericUpDown();
            this.lblPre = new System.Windows.Forms.Label();
            this.nudPre = new System.Windows.Forms.NumericUpDown();
            this.lbllDes = new System.Windows.Forms.Label();
            this.txtDes = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudExi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPre)).BeginInit();
            this.SuspendLayout();
            // 
            // lbllDFab
            // 
            this.lbllDFab.AutoSize = true;
            this.lbllDFab.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllDFab.Location = new System.Drawing.Point(91, 48);
            this.lbllDFab.Name = "lbllDFab";
            this.lbllDFab.Size = new System.Drawing.Size(234, 28);
            this.lbllDFab.TabIndex = 0;
            this.lbllDFab.Text = "Clave del Fabricante";
            // 
            // lbllDProd
            // 
            this.lbllDProd.AutoSize = true;
            this.lbllDProd.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllDProd.Location = new System.Drawing.Point(91, 102);
            this.lbllDProd.Name = "lbllDProd";
            this.lbllDProd.Size = new System.Drawing.Size(216, 28);
            this.lbllDProd.TabIndex = 1;
            this.lbllDProd.Text = "Clave del Producto";
            // 
            // lblExi
            // 
            this.lblExi.AutoSize = true;
            this.lblExi.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExi.Location = new System.Drawing.Point(91, 260);
            this.lblExi.Name = "lblExi";
            this.lblExi.Size = new System.Drawing.Size(138, 28);
            this.lblExi.TabIndex = 4;
            this.lblExi.Text = "Existencias";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(91, 312);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(86, 28);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Estado";
            // 
            // cmbIDFab
            // 
            this.cmbIDFab.FormattingEnabled = true;
            this.cmbIDFab.Location = new System.Drawing.Point(359, 51);
            this.cmbIDFab.Name = "cmbIDFab";
            this.cmbIDFab.Size = new System.Drawing.Size(121, 24);
            this.cmbIDFab.TabIndex = 6;
            this.cmbIDFab.SelectedIndexChanged += new System.EventHandler(this.cmbIDFab_SelectedIndexChanged);
            // 
            // cmbIDProd
            // 
            this.cmbIDProd.FormattingEnabled = true;
            this.cmbIDProd.Location = new System.Drawing.Point(359, 105);
            this.cmbIDProd.Name = "cmbIDProd";
            this.cmbIDProd.Size = new System.Drawing.Size(121, 24);
            this.cmbIDProd.TabIndex = 7;
            this.cmbIDProd.SelectedIndexChanged += new System.EventHandler(this.cmbIDProd_SelectedIndexChanged);
            // 
            // IbIStatus
            // 
            this.IbIStatus.AutoSize = true;
            this.IbIStatus.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IbIStatus.Location = new System.Drawing.Point(359, 323);
            this.IbIStatus.Name = "IbIStatus";
            this.IbIStatus.Size = new System.Drawing.Size(32, 28);
            this.IbIStatus.TabIndex = 11;
            this.IbIStatus.Text = "\"\"";
            // 
            // btmEliminar
            // 
            this.btmEliminar.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmEliminar.Location = new System.Drawing.Point(320, 408);
            this.btmEliminar.Name = "btmEliminar";
            this.btmEliminar.Size = new System.Drawing.Size(343, 43);
            this.btmEliminar.TabIndex = 12;
            this.btmEliminar.Text = "Eliminar Registro";
            this.btmEliminar.UseVisualStyleBackColor = true;
            this.btmEliminar.Click += new System.EventHandler(this.btmEliminar_Click);
            // 
            // nudExi
            // 
            this.nudExi.Location = new System.Drawing.Point(359, 265);
            this.nudExi.Name = "nudExi";
            this.nudExi.Size = new System.Drawing.Size(120, 22);
            this.nudExi.TabIndex = 10;
            // 
            // lblPre
            // 
            this.lblPre.AutoSize = true;
            this.lblPre.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPre.Location = new System.Drawing.Point(91, 207);
            this.lblPre.Name = "lblPre";
            this.lblPre.Size = new System.Drawing.Size(81, 28);
            this.lblPre.TabIndex = 3;
            this.lblPre.Text = "Precio";
            // 
            // nudPre
            // 
            this.nudPre.Location = new System.Drawing.Point(359, 212);
            this.nudPre.Name = "nudPre";
            this.nudPre.Size = new System.Drawing.Size(120, 22);
            this.nudPre.TabIndex = 9;
            // 
            // lbllDes
            // 
            this.lbllDes.AutoSize = true;
            this.lbllDes.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllDes.Location = new System.Drawing.Point(91, 159);
            this.lbllDes.Name = "lbllDes";
            this.lbllDes.Size = new System.Drawing.Size(141, 28);
            this.lbllDes.TabIndex = 2;
            this.lbllDes.Text = "Descripcion";
            // 
            // txtDes
            // 
            this.txtDes.Location = new System.Drawing.Point(359, 165);
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(369, 22);
            this.txtDes.TabIndex = 8;
            // 
            // FrmEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 519);
            this.Controls.Add(this.btmEliminar);
            this.Controls.Add(this.IbIStatus);
            this.Controls.Add(this.nudExi);
            this.Controls.Add(this.nudPre);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.cmbIDProd);
            this.Controls.Add(this.cmbIDFab);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblExi);
            this.Controls.Add(this.lblPre);
            this.Controls.Add(this.lbllDes);
            this.Controls.Add(this.lbllDProd);
            this.Controls.Add(this.lbllDFab);
            this.Name = "FrmEliminar";
            this.Text = "FrmEliminar";
            this.Load += new System.EventHandler(this.FrmEliminar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudExi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbllDFab;
        private System.Windows.Forms.Label lbllDProd;
        private System.Windows.Forms.Label lblExi;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbIDFab;
        private System.Windows.Forms.ComboBox cmbIDProd;
        private System.Windows.Forms.Label IbIStatus;
        private System.Windows.Forms.Button btmEliminar;
        private System.Windows.Forms.NumericUpDown nudExi;
        private System.Windows.Forms.Label lblPre;
        private System.Windows.Forms.NumericUpDown nudPre;
        private System.Windows.Forms.Label lbllDes;
        private System.Windows.Forms.TextBox txtDes;
    }
}