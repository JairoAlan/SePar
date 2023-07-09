namespace Ventas_Jairo
{
    partial class FrmAltaProductos
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
            this.lblIDFab = new System.Windows.Forms.Label();
            this.txtIDFab = new System.Windows.Forms.TextBox();
            this.txtExi = new System.Windows.Forms.NumericUpDown();
            this.lblIDProd = new System.Windows.Forms.Label();
            this.lblIDes = new System.Windows.Forms.Label();
            this.lblPre = new System.Windows.Forms.Label();
            this.lblExi = new System.Windows.Forms.Label();
            this.txtIDProd = new System.Windows.Forms.TextBox();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.txtPre = new System.Windows.Forms.NumericUpDown();
            this.btnIns = new System.Windows.Forms.Button();
            this.btnProc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtExi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPre)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIDFab
            // 
            this.lblIDFab.AutoSize = true;
            this.lblIDFab.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDFab.Location = new System.Drawing.Point(112, 78);
            this.lblIDFab.Name = "lblIDFab";
            this.lblIDFab.Size = new System.Drawing.Size(241, 28);
            this.lblIDFab.TabIndex = 0;
            this.lblIDFab.Text = "Clave del Fabricante:";
            // 
            // txtIDFab
            // 
            this.txtIDFab.Location = new System.Drawing.Point(393, 84);
            this.txtIDFab.Name = "txtIDFab";
            this.txtIDFab.Size = new System.Drawing.Size(216, 22);
            this.txtIDFab.TabIndex = 1;
            // 
            // txtExi
            // 
            this.txtExi.Location = new System.Drawing.Point(310, 316);
            this.txtExi.Name = "txtExi";
            this.txtExi.Size = new System.Drawing.Size(120, 22);
            this.txtExi.TabIndex = 2;
            // 
            // lblIDProd
            // 
            this.lblIDProd.AutoSize = true;
            this.lblIDProd.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDProd.Location = new System.Drawing.Point(111, 144);
            this.lblIDProd.Name = "lblIDProd";
            this.lblIDProd.Size = new System.Drawing.Size(223, 28);
            this.lblIDProd.TabIndex = 3;
            this.lblIDProd.Text = "Clave del Producto:";
            // 
            // lblIDes
            // 
            this.lblIDes.AutoSize = true;
            this.lblIDes.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDes.Location = new System.Drawing.Point(112, 205);
            this.lblIDes.Name = "lblIDes";
            this.lblIDes.Size = new System.Drawing.Size(148, 28);
            this.lblIDes.TabIndex = 4;
            this.lblIDes.Text = "Descripcion:";
            this.lblIDes.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblPre
            // 
            this.lblPre.AutoSize = true;
            this.lblPre.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPre.Location = new System.Drawing.Point(112, 260);
            this.lblPre.Name = "lblPre";
            this.lblPre.Size = new System.Drawing.Size(88, 28);
            this.lblPre.TabIndex = 5;
            this.lblPre.Text = "Precio:";
            // 
            // lblExi
            // 
            this.lblExi.AutoSize = true;
            this.lblExi.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExi.Location = new System.Drawing.Point(112, 310);
            this.lblExi.Name = "lblExi";
            this.lblExi.Size = new System.Drawing.Size(145, 28);
            this.lblExi.TabIndex = 6;
            this.lblExi.Text = "Existencias:";
            // 
            // txtIDProd
            // 
            this.txtIDProd.Location = new System.Drawing.Point(393, 144);
            this.txtIDProd.Name = "txtIDProd";
            this.txtIDProd.Size = new System.Drawing.Size(216, 22);
            this.txtIDProd.TabIndex = 7;
            // 
            // txtDes
            // 
            this.txtDes.Location = new System.Drawing.Point(310, 205);
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(379, 22);
            this.txtDes.TabIndex = 8;
            // 
            // txtPre
            // 
            this.txtPre.Location = new System.Drawing.Point(310, 260);
            this.txtPre.Name = "txtPre";
            this.txtPre.Size = new System.Drawing.Size(120, 22);
            this.txtPre.TabIndex = 9;
            this.txtPre.ValueChanged += new System.EventHandler(this.txtPre_ValueChanged);
            // 
            // btnIns
            // 
            this.btnIns.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIns.Location = new System.Drawing.Point(206, 384);
            this.btnIns.Name = "btnIns";
            this.btnIns.Size = new System.Drawing.Size(262, 37);
            this.btnIns.TabIndex = 10;
            this.btnIns.Text = " Guardar con Insert";
            this.btnIns.UseVisualStyleBackColor = true;
            this.btnIns.Click += new System.EventHandler(this.btnIns_Click);
            // 
            // btnProc
            // 
            this.btnProc.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProc.Location = new System.Drawing.Point(559, 384);
            this.btnProc.Name = "btnProc";
            this.btnProc.Size = new System.Drawing.Size(406, 37);
            this.btnProc.TabIndex = 11;
            this.btnProc.Text = " Guardar con Procedimiento";
            this.btnProc.UseVisualStyleBackColor = true;
            this.btnProc.Click += new System.EventHandler(this.btnProc_Click);
            // 
            // FrmAltaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 450);
            this.Controls.Add(this.btnProc);
            this.Controls.Add(this.btnIns);
            this.Controls.Add(this.txtPre);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.txtIDProd);
            this.Controls.Add(this.lblExi);
            this.Controls.Add(this.lblPre);
            this.Controls.Add(this.lblIDes);
            this.Controls.Add(this.lblIDProd);
            this.Controls.Add(this.txtExi);
            this.Controls.Add(this.txtIDFab);
            this.Controls.Add(this.lblIDFab);
            this.Name = "FrmAltaProductos";
            this.Text = "Inventario Productos";
            this.Load += new System.EventHandler(this.FrmAltaProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtExi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIDFab;
        private System.Windows.Forms.TextBox txtIDFab;
        private System.Windows.Forms.NumericUpDown txtExi;
        private System.Windows.Forms.Label lblIDProd;
        private System.Windows.Forms.Label lblIDes;
        private System.Windows.Forms.Label lblPre;
        private System.Windows.Forms.Label lblExi;
        private System.Windows.Forms.TextBox txtIDProd;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.NumericUpDown txtPre;
        private System.Windows.Forms.Button btnIns;
        private System.Windows.Forms.Button btnProc;
    }
}

