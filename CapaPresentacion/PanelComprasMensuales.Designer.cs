namespace CapaPresentacion
{
    partial class PanelComprasMensuales
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
            this.LbComprasM = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBuscarComprasMensuales = new System.Windows.Forms.Button();
            this.CBmes2 = new System.Windows.Forms.ComboBox();
            this.CBMes1 = new System.Windows.Forms.ComboBox();
            this.DGVNombreProductos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVNombreProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // LbComprasM
            // 
            this.LbComprasM.AutoSize = true;
            this.LbComprasM.BackColor = System.Drawing.Color.Transparent;
            this.LbComprasM.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbComprasM.ForeColor = System.Drawing.Color.White;
            this.LbComprasM.Location = new System.Drawing.Point(43, 39);
            this.LbComprasM.Name = "LbComprasM";
            this.LbComprasM.Size = new System.Drawing.Size(195, 23);
            this.LbComprasM.TabIndex = 1;
            this.LbComprasM.Text = "Compras Por Mes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(375, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "/";
            // 
            // BtnBuscarComprasMensuales
            // 
            this.BtnBuscarComprasMensuales.FlatAppearance.BorderSize = 0;
            this.BtnBuscarComprasMensuales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarComprasMensuales.ForeColor = System.Drawing.Color.White;
            this.BtnBuscarComprasMensuales.Location = new System.Drawing.Point(552, 37);
            this.BtnBuscarComprasMensuales.Name = "BtnBuscarComprasMensuales";
            this.BtnBuscarComprasMensuales.Size = new System.Drawing.Size(80, 31);
            this.BtnBuscarComprasMensuales.TabIndex = 12;
            this.BtnBuscarComprasMensuales.Text = "Buscar";
            this.BtnBuscarComprasMensuales.UseVisualStyleBackColor = true;
            // 
            // CBmes2
            // 
            this.CBmes2.FormattingEnabled = true;
            this.CBmes2.Location = new System.Drawing.Point(398, 43);
            this.CBmes2.Name = "CBmes2";
            this.CBmes2.Size = new System.Drawing.Size(121, 21);
            this.CBmes2.TabIndex = 11;
            this.CBmes2.SelectedIndexChanged += new System.EventHandler(this.CByear2_SelectedIndexChanged);
            // 
            // CBMes1
            // 
            this.CBMes1.FormattingEnabled = true;
            this.CBMes1.Location = new System.Drawing.Point(248, 43);
            this.CBMes1.Name = "CBMes1";
            this.CBMes1.Size = new System.Drawing.Size(121, 21);
            this.CBMes1.TabIndex = 10;
            // 
            // DGVNombreProductos
            // 
            this.DGVNombreProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVNombreProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVNombreProductos.Location = new System.Drawing.Point(50, 135);
            this.DGVNombreProductos.Name = "DGVNombreProductos";
            this.DGVNombreProductos.Size = new System.Drawing.Size(582, 242);
            this.DGVNombreProductos.TabIndex = 9;
            // 
            // PanelComprasMensuales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(682, 415);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnBuscarComprasMensuales);
            this.Controls.Add(this.CBmes2);
            this.Controls.Add(this.CBMes1);
            this.Controls.Add(this.DGVNombreProductos);
            this.Controls.Add(this.LbComprasM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PanelComprasMensuales";
            this.Text = "PanelComprasMensuales";
            ((System.ComponentModel.ISupportInitialize)(this.DGVNombreProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbComprasM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBuscarComprasMensuales;
        private System.Windows.Forms.ComboBox CBmes2;
        private System.Windows.Forms.ComboBox CBMes1;
        private System.Windows.Forms.DataGridView DGVNombreProductos;
    }
}