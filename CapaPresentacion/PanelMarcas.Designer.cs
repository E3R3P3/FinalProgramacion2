namespace CapaPresentacion
{
    partial class PanelMarcas
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
            this.LbMarcas = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnBuscarNombreMarca = new System.Windows.Forms.Button();
            this.DGVNombreMarca = new System.Windows.Forms.DataGridView();
            this.TxtNombreMarcas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVNombreMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // LbMarcas
            // 
            this.LbMarcas.AutoSize = true;
            this.LbMarcas.BackColor = System.Drawing.Color.Transparent;
            this.LbMarcas.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbMarcas.ForeColor = System.Drawing.Color.White;
            this.LbMarcas.Location = new System.Drawing.Point(43, 39);
            this.LbMarcas.Name = "LbMarcas";
            this.LbMarcas.Size = new System.Drawing.Size(85, 23);
            this.LbMarcas.TabIndex = 1;
            this.LbMarcas.Text = "Marcas";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(588, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 11;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BtnBuscarNombreMarca
            // 
            this.BtnBuscarNombreMarca.FlatAppearance.BorderSize = 0;
            this.BtnBuscarNombreMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarNombreMarca.ForeColor = System.Drawing.Color.White;
            this.BtnBuscarNombreMarca.Location = new System.Drawing.Point(351, 84);
            this.BtnBuscarNombreMarca.Name = "BtnBuscarNombreMarca";
            this.BtnBuscarNombreMarca.Size = new System.Drawing.Size(80, 31);
            this.BtnBuscarNombreMarca.TabIndex = 10;
            this.BtnBuscarNombreMarca.Text = "Buscar";
            this.BtnBuscarNombreMarca.UseVisualStyleBackColor = true;
            this.BtnBuscarNombreMarca.Click += new System.EventHandler(this.BtnBuscarNombreMarca_Click);
            // 
            // DGVNombreMarca
            // 
            this.DGVNombreMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVNombreMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVNombreMarca.Location = new System.Drawing.Point(40, 138);
            this.DGVNombreMarca.Name = "DGVNombreMarca";
            this.DGVNombreMarca.Size = new System.Drawing.Size(582, 242);
            this.DGVNombreMarca.TabIndex = 9;
            // 
            // TxtNombreMarcas
            // 
            this.TxtNombreMarcas.BackColor = System.Drawing.Color.White;
            this.TxtNombreMarcas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNombreMarcas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNombreMarcas.Location = new System.Drawing.Point(105, 84);
            this.TxtNombreMarcas.Multiline = true;
            this.TxtNombreMarcas.Name = "TxtNombreMarcas";
            this.TxtNombreMarcas.Size = new System.Drawing.Size(231, 31);
            this.TxtNombreMarcas.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(37, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Buscar:";
            // 
            // PanelMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(682, 415);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnBuscarNombreMarca);
            this.Controls.Add(this.DGVNombreMarca);
            this.Controls.Add(this.TxtNombreMarcas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LbMarcas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PanelMarcas";
            this.Text = "PanelMarcas";
            this.Load += new System.EventHandler(this.PanelMarcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVNombreMarca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbMarcas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnBuscarNombreMarca;
        private System.Windows.Forms.DataGridView DGVNombreMarca;
        private System.Windows.Forms.TextBox TxtNombreMarcas;
        private System.Windows.Forms.Label label2;
    }
}