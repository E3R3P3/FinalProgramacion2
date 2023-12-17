namespace CapaPresentacion
{
    partial class PanelProductos
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
            this.TxtNombreProductos = new System.Windows.Forms.TextBox();
            this.DGVNombreProductos = new System.Windows.Forms.DataGridView();
            this.BtnBuscarNombreProductos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVNombreProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(43, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Productos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(44, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buscar:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TxtNombreProductos
            // 
            this.TxtNombreProductos.BackColor = System.Drawing.Color.White;
            this.TxtNombreProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNombreProductos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNombreProductos.Location = new System.Drawing.Point(112, 81);
            this.TxtNombreProductos.Multiline = true;
            this.TxtNombreProductos.Name = "TxtNombreProductos";
            this.TxtNombreProductos.Size = new System.Drawing.Size(231, 31);
            this.TxtNombreProductos.TabIndex = 2;
            // 
            // DGVNombreProductos
            // 
            this.DGVNombreProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVNombreProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVNombreProductos.Location = new System.Drawing.Point(47, 135);
            this.DGVNombreProductos.Name = "DGVNombreProductos";
            this.DGVNombreProductos.Size = new System.Drawing.Size(582, 242);
            this.DGVNombreProductos.TabIndex = 3;
            this.DGVNombreProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCategoriaProductos_CellContentClick);
            // 
            // BtnBuscarNombreProductos
            // 
            this.BtnBuscarNombreProductos.FlatAppearance.BorderSize = 0;
            this.BtnBuscarNombreProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarNombreProductos.ForeColor = System.Drawing.Color.White;
            this.BtnBuscarNombreProductos.Location = new System.Drawing.Point(358, 81);
            this.BtnBuscarNombreProductos.Name = "BtnBuscarNombreProductos";
            this.BtnBuscarNombreProductos.Size = new System.Drawing.Size(80, 31);
            this.BtnBuscarNombreProductos.TabIndex = 4;
            this.BtnBuscarNombreProductos.Text = "Buscar";
            this.BtnBuscarNombreProductos.UseVisualStyleBackColor = true;
            this.BtnBuscarNombreProductos.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(595, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // PanelProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(682, 415);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnBuscarNombreProductos);
            this.Controls.Add(this.DGVNombreProductos);
            this.Controls.Add(this.TxtNombreProductos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PanelProductos";
            this.Text = "PanelProductos";
            this.Load += new System.EventHandler(this.PanelProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVNombreProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNombreProductos;
        private System.Windows.Forms.DataGridView DGVNombreProductos;
        private System.Windows.Forms.Button BtnBuscarNombreProductos;
        private System.Windows.Forms.Button button1;
    }
}