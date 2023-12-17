namespace CapaPresentacion
{
    partial class PanelComprasAnuales
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
            this.LbComprasA = new System.Windows.Forms.Label();
            this.DGVNombreProductos = new System.Windows.Forms.DataGridView();
            this.CByear1 = new System.Windows.Forms.ComboBox();
            this.CByear2 = new System.Windows.Forms.ComboBox();
            this.BtnBuscarComprasAnuales = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVNombreProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // LbComprasA
            // 
            this.LbComprasA.AutoSize = true;
            this.LbComprasA.BackColor = System.Drawing.Color.Transparent;
            this.LbComprasA.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbComprasA.ForeColor = System.Drawing.Color.White;
            this.LbComprasA.Location = new System.Drawing.Point(43, 39);
            this.LbComprasA.Name = "LbComprasA";
            this.LbComprasA.Size = new System.Drawing.Size(186, 23);
            this.LbComprasA.TabIndex = 1;
            this.LbComprasA.Text = "Compas Por Año";
            this.LbComprasA.Click += new System.EventHandler(this.LbComprasA_Click);
            // 
            // DGVNombreProductos
            // 
            this.DGVNombreProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVNombreProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVNombreProductos.Location = new System.Drawing.Point(50, 131);
            this.DGVNombreProductos.Name = "DGVNombreProductos";
            this.DGVNombreProductos.Size = new System.Drawing.Size(582, 242);
            this.DGVNombreProductos.TabIndex = 4;
            // 
            // CByear1
            // 
            this.CByear1.FormattingEnabled = true;
            this.CByear1.Location = new System.Drawing.Point(248, 39);
            this.CByear1.Name = "CByear1";
            this.CByear1.Size = new System.Drawing.Size(121, 21);
            this.CByear1.TabIndex = 5;
            // 
            // CByear2
            // 
            this.CByear2.FormattingEnabled = true;
            this.CByear2.Location = new System.Drawing.Point(398, 39);
            this.CByear2.Name = "CByear2";
            this.CByear2.Size = new System.Drawing.Size(121, 21);
            this.CByear2.TabIndex = 6;
            // 
            // BtnBuscarComprasAnuales
            // 
            this.BtnBuscarComprasAnuales.FlatAppearance.BorderSize = 0;
            this.BtnBuscarComprasAnuales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarComprasAnuales.ForeColor = System.Drawing.Color.White;
            this.BtnBuscarComprasAnuales.Location = new System.Drawing.Point(552, 33);
            this.BtnBuscarComprasAnuales.Name = "BtnBuscarComprasAnuales";
            this.BtnBuscarComprasAnuales.Size = new System.Drawing.Size(80, 31);
            this.BtnBuscarComprasAnuales.TabIndex = 7;
            this.BtnBuscarComprasAnuales.Text = "Buscar";
            this.BtnBuscarComprasAnuales.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(375, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "/";
            // 
            // PanelComprasAnuales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(682, 415);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnBuscarComprasAnuales);
            this.Controls.Add(this.CByear2);
            this.Controls.Add(this.CByear1);
            this.Controls.Add(this.DGVNombreProductos);
            this.Controls.Add(this.LbComprasA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PanelComprasAnuales";
            this.Text = "PanelComprasAnuales";
            ((System.ComponentModel.ISupportInitialize)(this.DGVNombreProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbComprasA;
        private System.Windows.Forms.DataGridView DGVNombreProductos;
        private System.Windows.Forms.ComboBox CByear1;
        private System.Windows.Forms.ComboBox CByear2;
        private System.Windows.Forms.Button BtnBuscarComprasAnuales;
        private System.Windows.Forms.Label label1;
    }
}