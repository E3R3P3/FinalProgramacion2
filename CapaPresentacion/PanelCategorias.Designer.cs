namespace CapaPresentacion
{
    partial class PanelCategorias
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
            System.Windows.Forms.Label LbCategorias;
            this.button1 = new System.Windows.Forms.Button();
            this.BtnBuscarCategoriaProductos = new System.Windows.Forms.Button();
            this.DGVCategoriaNombre = new System.Windows.Forms.DataGridView();
            this.TxtNombreCategoria = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            LbCategorias = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCategoriaNombre)).BeginInit();
            this.SuspendLayout();
            // 
            // LbCategorias
            // 
            LbCategorias.AutoSize = true;
            LbCategorias.BackColor = System.Drawing.Color.Transparent;
            LbCategorias.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LbCategorias.ForeColor = System.Drawing.Color.White;
            LbCategorias.Location = new System.Drawing.Point(43, 39);
            LbCategorias.Name = "LbCategorias";
            LbCategorias.Size = new System.Drawing.Size(125, 23);
            LbCategorias.TabIndex = 1;
            LbCategorias.Text = "Categorias";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(598, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 11;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BtnBuscarCategoriaProductos
            // 
            this.BtnBuscarCategoriaProductos.FlatAppearance.BorderSize = 0;
            this.BtnBuscarCategoriaProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarCategoriaProductos.ForeColor = System.Drawing.Color.White;
            this.BtnBuscarCategoriaProductos.Location = new System.Drawing.Point(361, 83);
            this.BtnBuscarCategoriaProductos.Name = "BtnBuscarCategoriaProductos";
            this.BtnBuscarCategoriaProductos.Size = new System.Drawing.Size(80, 31);
            this.BtnBuscarCategoriaProductos.TabIndex = 10;
            this.BtnBuscarCategoriaProductos.Text = "Buscar";
            this.BtnBuscarCategoriaProductos.UseVisualStyleBackColor = true;
            this.BtnBuscarCategoriaProductos.Click += new System.EventHandler(this.BtnBuscarCategoriaProductos_Click);
            // 
            // DGVCategoriaNombre
            // 
            this.DGVCategoriaNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVCategoriaNombre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCategoriaNombre.Location = new System.Drawing.Point(50, 137);
            this.DGVCategoriaNombre.Name = "DGVCategoriaNombre";
            this.DGVCategoriaNombre.Size = new System.Drawing.Size(582, 242);
            this.DGVCategoriaNombre.TabIndex = 9;
            // 
            // TxtNombreCategoria
            // 
            this.TxtNombreCategoria.BackColor = System.Drawing.Color.White;
            this.TxtNombreCategoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNombreCategoria.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNombreCategoria.Location = new System.Drawing.Point(115, 83);
            this.TxtNombreCategoria.Multiline = true;
            this.TxtNombreCategoria.Name = "TxtNombreCategoria";
            this.TxtNombreCategoria.Size = new System.Drawing.Size(231, 31);
            this.TxtNombreCategoria.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(47, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Buscar:";
            // 
            // PanelCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(682, 415);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnBuscarCategoriaProductos);
            this.Controls.Add(this.DGVCategoriaNombre);
            this.Controls.Add(this.TxtNombreCategoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(LbCategorias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PanelCategorias";
            this.Text = "PanelCategorias";
            this.Load += new System.EventHandler(this.PanelCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCategoriaNombre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnBuscarCategoriaProductos;
        private System.Windows.Forms.DataGridView DGVCategoriaNombre;
        private System.Windows.Forms.TextBox TxtNombreCategoria;
        private System.Windows.Forms.Label label2;
    }
}