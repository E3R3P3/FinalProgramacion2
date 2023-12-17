namespace CapaPresentacion
{
    partial class PanelComprar
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
            this.button1 = new System.Windows.Forms.Button();
            this.BtnBuscarNombreProductosComprar = new System.Windows.Forms.Button();
            this.DGVProductosComprar = new System.Windows.Forms.DataGridView();
            this.TxtNombreProductosComprar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CantidadComprar = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnComprar = new System.Windows.Forms.Button();
            this.TxtNombreComprar = new System.Windows.Forms.TextBox();
            this.TxtCostoUnidad = new System.Windows.Forms.TextBox();
            this.TxtProveedorComprar = new System.Windows.Forms.TextBox();
            this.TxtMarcaComprar = new System.Windows.Forms.TextBox();
            this.TxtPresentacionComprar = new System.Windows.Forms.TextBox();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProductosComprar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadComprar)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(709, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 11;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BtnBuscarNombreProductosComprar
            // 
            this.BtnBuscarNombreProductosComprar.AutoSize = true;
            this.BtnBuscarNombreProductosComprar.FlatAppearance.BorderSize = 0;
            this.BtnBuscarNombreProductosComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarNombreProductosComprar.ForeColor = System.Drawing.Color.White;
            this.BtnBuscarNombreProductosComprar.Location = new System.Drawing.Point(335, 73);
            this.BtnBuscarNombreProductosComprar.Name = "BtnBuscarNombreProductosComprar";
            this.BtnBuscarNombreProductosComprar.Size = new System.Drawing.Size(80, 31);
            this.BtnBuscarNombreProductosComprar.TabIndex = 10;
            this.BtnBuscarNombreProductosComprar.Text = "Buscar";
            this.BtnBuscarNombreProductosComprar.UseVisualStyleBackColor = true;
            this.BtnBuscarNombreProductosComprar.Click += new System.EventHandler(this.BtnBuscarNombreProductos_Click);
            // 
            // DGVProductosComprar
            // 
            this.DGVProductosComprar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVProductosComprar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVProductosComprar.Location = new System.Drawing.Point(24, 127);
            this.DGVProductosComprar.Name = "DGVProductosComprar";
            this.DGVProductosComprar.ReadOnly = true;
            this.DGVProductosComprar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVProductosComprar.Size = new System.Drawing.Size(437, 274);
            this.DGVProductosComprar.TabIndex = 9;
            this.DGVProductosComprar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVProductosComprar_CellContentClick);
            this.DGVProductosComprar.Click += new System.EventHandler(this.DGVProductosComprar_Click);
            // 
            // TxtNombreProductosComprar
            // 
            this.TxtNombreProductosComprar.BackColor = System.Drawing.Color.White;
            this.TxtNombreProductosComprar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNombreProductosComprar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNombreProductosComprar.Location = new System.Drawing.Point(89, 73);
            this.TxtNombreProductosComprar.Multiline = true;
            this.TxtNombreProductosComprar.Name = "TxtNombreProductosComprar";
            this.TxtNombreProductosComprar.Size = new System.Drawing.Size(231, 31);
            this.TxtNombreProductosComprar.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Buscar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Comprar Productos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(529, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(529, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Cantidad:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(529, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Costo por Unidad:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(529, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Proveedor:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(529, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Marca:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(529, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Presentacion:";
            // 
            // CantidadComprar
            // 
            this.CantidadComprar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CantidadComprar.AutoSize = true;
            this.CantidadComprar.BackColor = System.Drawing.Color.White;
            this.CantidadComprar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CantidadComprar.Hexadecimal = true;
            this.CantidadComprar.Location = new System.Drawing.Point(612, 146);
            this.CantidadComprar.Name = "CantidadComprar";
            this.CantidadComprar.Size = new System.Drawing.Size(120, 16);
            this.CantidadComprar.TabIndex = 20;
            this.CantidadComprar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CantidadComprar.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CantidadComprar.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            this.CantidadComprar.Click += new System.EventHandler(this.CantidadComprar_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(529, 351);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "Total:";
            // 
            // BtnComprar
            // 
            this.BtnComprar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnComprar.AutoSize = true;
            this.BtnComprar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(36)))));
            this.BtnComprar.FlatAppearance.BorderSize = 0;
            this.BtnComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnComprar.ForeColor = System.Drawing.Color.White;
            this.BtnComprar.Location = new System.Drawing.Point(687, 418);
            this.BtnComprar.Name = "BtnComprar";
            this.BtnComprar.Size = new System.Drawing.Size(80, 31);
            this.BtnComprar.TabIndex = 26;
            this.BtnComprar.Text = "Comprar";
            this.BtnComprar.UseVisualStyleBackColor = false;
            this.BtnComprar.Click += new System.EventHandler(this.BtnComprar_Click);
            // 
            // TxtNombreComprar
            // 
            this.TxtNombreComprar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TxtNombreComprar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.TxtNombreComprar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNombreComprar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNombreComprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreComprar.ForeColor = System.Drawing.Color.White;
            this.TxtNombreComprar.Location = new System.Drawing.Point(604, 106);
            this.TxtNombreComprar.Multiline = true;
            this.TxtNombreComprar.Name = "TxtNombreComprar";
            this.TxtNombreComprar.Size = new System.Drawing.Size(128, 31);
            this.TxtNombreComprar.TabIndex = 27;
            this.TxtNombreComprar.Text = "Nombre";
            this.TxtNombreComprar.TextChanged += new System.EventHandler(this.TxtNombreComprar_TextChanged);
            // 
            // TxtCostoUnidad
            // 
            this.TxtCostoUnidad.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TxtCostoUnidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.TxtCostoUnidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCostoUnidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCostoUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCostoUnidad.ForeColor = System.Drawing.Color.White;
            this.TxtCostoUnidad.Location = new System.Drawing.Point(668, 194);
            this.TxtCostoUnidad.Multiline = true;
            this.TxtCostoUnidad.Name = "TxtCostoUnidad";
            this.TxtCostoUnidad.Size = new System.Drawing.Size(97, 31);
            this.TxtCostoUnidad.TabIndex = 28;
            this.TxtCostoUnidad.Text = "0";
            this.TxtCostoUnidad.TextChanged += new System.EventHandler(this.TxtCostoUnidad_TextChanged);
            // 
            // TxtProveedorComprar
            // 
            this.TxtProveedorComprar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TxtProveedorComprar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.TxtProveedorComprar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtProveedorComprar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtProveedorComprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProveedorComprar.ForeColor = System.Drawing.Color.White;
            this.TxtProveedorComprar.Location = new System.Drawing.Point(622, 230);
            this.TxtProveedorComprar.Multiline = true;
            this.TxtProveedorComprar.Name = "TxtProveedorComprar";
            this.TxtProveedorComprar.Size = new System.Drawing.Size(157, 31);
            this.TxtProveedorComprar.TabIndex = 29;
            this.TxtProveedorComprar.Text = "Nombre";
            this.TxtProveedorComprar.TextChanged += new System.EventHandler(this.TxtProveedorComprar_TextChanged);
            // 
            // TxtMarcaComprar
            // 
            this.TxtMarcaComprar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TxtMarcaComprar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.TxtMarcaComprar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtMarcaComprar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtMarcaComprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMarcaComprar.ForeColor = System.Drawing.Color.White;
            this.TxtMarcaComprar.Location = new System.Drawing.Point(591, 273);
            this.TxtMarcaComprar.Multiline = true;
            this.TxtMarcaComprar.Name = "TxtMarcaComprar";
            this.TxtMarcaComprar.Size = new System.Drawing.Size(157, 31);
            this.TxtMarcaComprar.TabIndex = 30;
            this.TxtMarcaComprar.Text = "Marca";
            this.TxtMarcaComprar.TextChanged += new System.EventHandler(this.TxtMarcaComprar_TextChanged);
            // 
            // TxtPresentacionComprar
            // 
            this.TxtPresentacionComprar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TxtPresentacionComprar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.TxtPresentacionComprar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPresentacionComprar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPresentacionComprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPresentacionComprar.ForeColor = System.Drawing.Color.White;
            this.TxtPresentacionComprar.Location = new System.Drawing.Point(642, 317);
            this.TxtPresentacionComprar.Multiline = true;
            this.TxtPresentacionComprar.Name = "TxtPresentacionComprar";
            this.TxtPresentacionComprar.Size = new System.Drawing.Size(157, 31);
            this.TxtPresentacionComprar.TabIndex = 31;
            this.TxtPresentacionComprar.Text = "Presentacion";
            this.TxtPresentacionComprar.TextChanged += new System.EventHandler(this.TxtPresentacionComprar_TextChanged);
            // 
            // TxtTotal
            // 
            this.TxtTotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TxtTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.TxtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotal.ForeColor = System.Drawing.Color.White;
            this.TxtTotal.Location = new System.Drawing.Point(581, 351);
            this.TxtTotal.Multiline = true;
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(157, 31);
            this.TxtTotal.TabIndex = 32;
            this.TxtTotal.Text = "0";
            this.TxtTotal.TextChanged += new System.EventHandler(this.TxtTotal_TextChanged);
            // 
            // PanelComprar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(803, 461);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.TxtPresentacionComprar);
            this.Controls.Add(this.TxtMarcaComprar);
            this.Controls.Add(this.TxtProveedorComprar);
            this.Controls.Add(this.TxtCostoUnidad);
            this.Controls.Add(this.TxtNombreComprar);
            this.Controls.Add(this.BtnComprar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CantidadComprar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnBuscarNombreProductosComprar);
            this.Controls.Add(this.DGVProductosComprar);
            this.Controls.Add(this.TxtNombreProductosComprar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PanelComprar";
            this.Text = "PanelComprar";
            this.Load += new System.EventHandler(this.PanelComprar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVProductosComprar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadComprar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnBuscarNombreProductosComprar;
        private System.Windows.Forms.DataGridView DGVProductosComprar;
        private System.Windows.Forms.TextBox TxtNombreProductosComprar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown CantidadComprar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnComprar;
        private System.Windows.Forms.TextBox TxtNombreComprar;
        private System.Windows.Forms.TextBox TxtCostoUnidad;
        private System.Windows.Forms.TextBox TxtProveedorComprar;
        private System.Windows.Forms.TextBox TxtMarcaComprar;
        private System.Windows.Forms.TextBox TxtPresentacionComprar;
        private System.Windows.Forms.TextBox TxtTotal;
    }
}