namespace CapaPresentacion
{
    partial class PanelProveedores
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
            this.LbProveedores = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnBuscarProveedores = new System.Windows.Forms.Button();
            this.DGVProveedores = new System.Windows.Forms.DataGridView();
            this.TxtNombreProveedores = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // LbProveedores
            // 
            this.LbProveedores.AutoSize = true;
            this.LbProveedores.BackColor = System.Drawing.Color.Transparent;
            this.LbProveedores.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbProveedores.ForeColor = System.Drawing.Color.White;
            this.LbProveedores.Location = new System.Drawing.Point(43, 39);
            this.LbProveedores.Name = "LbProveedores";
            this.LbProveedores.Size = new System.Drawing.Size(143, 23);
            this.LbProveedores.TabIndex = 1;
            this.LbProveedores.Text = "Proveedores";
            this.LbProveedores.Click += new System.EventHandler(this.LbProveedores_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.ForeColor = System.Drawing.Color.Red;
            this.BtnCerrar.Location = new System.Drawing.Point(595, 12);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(75, 41);
            this.BtnCerrar.TabIndex = 10;
            this.BtnCerrar.Text = "X";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnBuscarProveedores
            // 
            this.BtnBuscarProveedores.FlatAppearance.BorderSize = 0;
            this.BtnBuscarProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarProveedores.ForeColor = System.Drawing.Color.White;
            this.BtnBuscarProveedores.Location = new System.Drawing.Point(358, 81);
            this.BtnBuscarProveedores.Name = "BtnBuscarProveedores";
            this.BtnBuscarProveedores.Size = new System.Drawing.Size(80, 31);
            this.BtnBuscarProveedores.TabIndex = 9;
            this.BtnBuscarProveedores.Text = "Buscar";
            this.BtnBuscarProveedores.UseVisualStyleBackColor = true;
            this.BtnBuscarProveedores.Click += new System.EventHandler(this.BtnBuscarProveedores_Click);
            // 
            // DGVProveedores
            // 
            this.DGVProveedores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVProveedores.Location = new System.Drawing.Point(47, 135);
            this.DGVProveedores.Name = "DGVProveedores";
            this.DGVProveedores.Size = new System.Drawing.Size(582, 242);
            this.DGVProveedores.TabIndex = 8;
            // 
            // TxtNombreProveedores
            // 
            this.TxtNombreProveedores.BackColor = System.Drawing.Color.White;
            this.TxtNombreProveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNombreProveedores.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNombreProveedores.Location = new System.Drawing.Point(112, 81);
            this.TxtNombreProveedores.Multiline = true;
            this.TxtNombreProveedores.Name = "TxtNombreProveedores";
            this.TxtNombreProveedores.Size = new System.Drawing.Size(231, 31);
            this.TxtNombreProveedores.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(44, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Buscar:";
            // 
            // PanelProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(682, 415);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnBuscarProveedores);
            this.Controls.Add(this.DGVProveedores);
            this.Controls.Add(this.TxtNombreProveedores);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LbProveedores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PanelProveedores";
            this.Text = "PanelProveedores";
            this.Load += new System.EventHandler(this.PanelProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbProveedores;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnBuscarProveedores;
        private System.Windows.Forms.DataGridView DGVProveedores;
        private System.Windows.Forms.TextBox TxtNombreProveedores;
        private System.Windows.Forms.Label label2;
    }
}