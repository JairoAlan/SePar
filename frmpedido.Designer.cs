namespace Ventas_Jairo
{
    partial class frmpedido
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
            this.lblnumpedido = new System.Windows.Forms.Label();
            this.txtnumped = new System.Windows.Forms.TextBox();
            this.lblfecha = new System.Windows.Forms.Label();
            this.lblnumcliente = new System.Windows.Forms.Label();
            this.txtnumcliente = new System.Windows.Forms.TextBox();
            this.dtFechapedido = new System.Windows.Forms.DateTimePicker();
            this.lblrep = new System.Windows.Forms.Label();
            this.cmbventas = new System.Windows.Forms.ComboBox();
            this.dgdetalles = new System.Windows.Forms.DataGridView();
            this.idfab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idproducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preciounitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbltotal = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.lbloficina = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgdetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // lblnumpedido
            // 
            this.lblnumpedido.AutoSize = true;
            this.lblnumpedido.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumpedido.Location = new System.Drawing.Point(64, 41);
            this.lblnumpedido.Name = "lblnumpedido";
            this.lblnumpedido.Size = new System.Drawing.Size(209, 28);
            this.lblnumpedido.TabIndex = 0;
            this.lblnumpedido.Text = "Numero de Pedido";
            // 
            // txtnumped
            // 
            this.txtnumped.Location = new System.Drawing.Point(376, 47);
            this.txtnumped.Name = "txtnumped";
            this.txtnumped.Size = new System.Drawing.Size(204, 22);
            this.txtnumped.TabIndex = 1;
            this.txtnumped.TextChanged += new System.EventHandler(this.txtnumped_TextChanged);
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.Location = new System.Drawing.Point(64, 94);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(188, 28);
            this.lblfecha.TabIndex = 2;
            this.lblfecha.Text = "Fecha de Pedido";
            // 
            // lblnumcliente
            // 
            this.lblnumcliente.AutoSize = true;
            this.lblnumcliente.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumcliente.Location = new System.Drawing.Point(64, 146);
            this.lblnumcliente.Name = "lblnumcliente";
            this.lblnumcliente.Size = new System.Drawing.Size(154, 28);
            this.lblnumcliente.TabIndex = 3;
            this.lblnumcliente.Text = "Num. Cliente";
            // 
            // txtnumcliente
            // 
            this.txtnumcliente.Location = new System.Drawing.Point(376, 152);
            this.txtnumcliente.Name = "txtnumcliente";
            this.txtnumcliente.Size = new System.Drawing.Size(244, 22);
            this.txtnumcliente.TabIndex = 4;
            // 
            // dtFechapedido
            // 
            this.dtFechapedido.Location = new System.Drawing.Point(376, 100);
            this.dtFechapedido.Name = "dtFechapedido";
            this.dtFechapedido.Size = new System.Drawing.Size(247, 22);
            this.dtFechapedido.TabIndex = 5;
            // 
            // lblrep
            // 
            this.lblrep.AutoSize = true;
            this.lblrep.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrep.Location = new System.Drawing.Point(64, 193);
            this.lblrep.Name = "lblrep";
            this.lblrep.Size = new System.Drawing.Size(286, 28);
            this.lblrep.TabIndex = 6;
            this.lblrep.Text = "Representante de Ventas";
            // 
            // cmbventas
            // 
            this.cmbventas.FormattingEnabled = true;
            this.cmbventas.Location = new System.Drawing.Point(376, 199);
            this.cmbventas.Name = "cmbventas";
            this.cmbventas.Size = new System.Drawing.Size(247, 24);
            this.cmbventas.TabIndex = 7;
            this.cmbventas.SelectedIndexChanged += new System.EventHandler(this.cmbventas_SelectedIndexChanged);
            // 
            // dgdetalles
            // 
            this.dgdetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idfab,
            this.Idproducto,
            this.Cantidad,
            this.Descripcion,
            this.Preciounitario,
            this.Importe});
            this.dgdetalles.Location = new System.Drawing.Point(69, 306);
            this.dgdetalles.Name = "dgdetalles";
            this.dgdetalles.RowHeadersWidth = 51;
            this.dgdetalles.RowTemplate.Height = 24;
            this.dgdetalles.Size = new System.Drawing.Size(806, 208);
            this.dgdetalles.TabIndex = 8;
            this.dgdetalles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdetalles_CellContentClick);
            // 
            // idfab
            // 
            this.idfab.HeaderText = "idfab";
            this.idfab.MinimumWidth = 6;
            this.idfab.Name = "idfab";
            this.idfab.Width = 125;
            // 
            // Idproducto
            // 
            this.Idproducto.HeaderText = "Idproducto";
            this.Idproducto.MinimumWidth = 6;
            this.Idproducto.Name = "Idproducto";
            this.Idproducto.Width = 125;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 125;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 125;
            // 
            // Preciounitario
            // 
            this.Preciounitario.HeaderText = "Preciounitario";
            this.Preciounitario.MinimumWidth = 6;
            this.Preciounitario.Name = "Preciounitario";
            this.Preciounitario.Width = 125;
            // 
            // Importe
            // 
            this.Importe.HeaderText = "Importe";
            this.Importe.MinimumWidth = 6;
            this.Importe.Name = "Importe";
            this.Importe.Width = 125;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(525, 529);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(83, 28);
            this.lbltotal.TabIndex = 9;
            this.lbltotal.Text = "TOTAL";
            this.lbltotal.Click += new System.EventHandler(this.lbltotal_Click);
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(726, 529);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(149, 22);
            this.txttotal.TabIndex = 10;
            // 
            // lbloficina
            // 
            this.lbloficina.AutoSize = true;
            this.lbloficina.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloficina.Location = new System.Drawing.Point(371, 246);
            this.lbloficina.Name = "lbloficina";
            this.lbloficina.Size = new System.Drawing.Size(0, 28);
            this.lbloficina.TabIndex = 11;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(500, 579);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(132, 42);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Aceptar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(691, 579);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(143, 42);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 28);
            this.label1.TabIndex = 14;
            this.label1.Text = "Oficina";
            // 
            // frmpedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 649);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lbloficina);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.dgdetalles);
            this.Controls.Add(this.cmbventas);
            this.Controls.Add(this.lblrep);
            this.Controls.Add(this.dtFechapedido);
            this.Controls.Add(this.txtnumcliente);
            this.Controls.Add(this.lblnumcliente);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.txtnumped);
            this.Controls.Add(this.lblnumpedido);
            this.Name = "frmpedido";
            this.Text = "frmpedido";
            this.Load += new System.EventHandler(this.frmpedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgdetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnumpedido;
        private System.Windows.Forms.TextBox txtnumped;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lblnumcliente;
        private System.Windows.Forms.TextBox txtnumcliente;
        private System.Windows.Forms.DateTimePicker dtFechapedido;
        private System.Windows.Forms.Label lblrep;
        private System.Windows.Forms.ComboBox cmbventas;
        private System.Windows.Forms.DataGridView dgdetalles;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label lbloficina;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfab;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idproducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preciounitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.Label label1;
    }
}