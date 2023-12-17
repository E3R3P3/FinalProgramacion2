namespace CapaPresentacion
{
    partial class PanelPresentaciones
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
            this.LbPresentacion = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnBuscarNombrePresentacion = new System.Windows.Forms.Button();
            this.DGVNombrePresentacion = new System.Windows.Forms.DataGridView();
            this.TxtNombrePresentacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVNombrePresentacion)).BeginInit();
            this.SuspendLayout();
            // 
            // LbPresentacion
            // 
            this.LbPresentacion.AutoSize = true;
            this.LbPresentacion.BackColor = System.Drawing.Color.Transparent;
            this.LbPresentacion.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPresentacion.ForeColor = System.Drawing.Color.White;
            this.LbPresentacion.Location = new System.Drawing.Point(43, 39);
            this.LbPresentacion.Name = "LbPresentacion";
            this.LbPresentacion.Size = new System.Drawing.Size(151, 23);
            this.LbPresentacion.TabIndex = 1;
            this.LbPresentacion.Text = "Presentacion";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(596, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 11;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BtnBuscarNombrePresentacion
            // 
            this.BtnBuscarNombrePresentacion.FlatAppearance.BorderSize = 0;
            this.BtnBuscarNombrePresentacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarNombrePresentacion.ForeColor = System.Drawing.Color.White;
            this.BtnBuscarNombrePresentacion.Location = new System.Drawing.Point(359, 84);
            this.BtnBuscarNombrePresentacion.Name = "BtnBuscarNombrePresentacion";
            this.BtnBuscarNombrePresentacion.Size = new System.Drawing.Size(80, 31);
            this.BtnBuscarNombrePresentacion.TabIndex = 10;
            this.BtnBuscarNombrePresentacion.Text = "Buscar";
            this.BtnBuscarNombrePresentacion.UseVisualStyleBackColor = true;
            this.BtnBuscarNombrePresentacion.Click += new System.EventHandler(this.BtnBuscarNombreProductos_Click);
            // 
            // DGVNombrePresentacion
            // 
            this.DGVNombrePresentacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVNombrePresentacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVNombrePresentacion.Location = new System.Drawing.Point(48, 138);
            this.DGVNombrePresentacion.Name = "DGVNombrePresentacion";
            this.DGVNombrePresentacion.Size = new System.Drawing.Size(582, 242);
            this.DGVNombrePresentacion.TabIndex = 9;
            // 
            // TxtNombrePresentacion
            // 
            this.TxtNombrePresentacion.BackColor = System.Drawing.Color.White;
            this.TxtNombrePresentacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNombrePresentacion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNombrePresentacion.Location = new System.Drawing.Point(113, 84);
            this.TxtNombrePresentacion.Multiline = true;
            this.TxtNombrePresentacion.Name = "TxtNombrePresentacion";
            this.TxtNombrePresentacion.Size = new System.Drawing.Size(231, 31);
            this.TxtNombrePresentacion.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(45, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Buscar:";
            // 
            // PanelPresentaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(682, 415);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnBuscarNombrePresentacion);
            this.Controls.Add(this.DGVNombrePresentacion);
            this.Controls.Add(this.TxtNombrePresentacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LbPresentacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PanelPresentaciones";
            this.Text = "PanelPresentaciones";
            this.Load += new System.EventHandler(this.PanelPresentaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVNombrePresentacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbPresentacion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnBuscarNombrePresentacion;
        private System.Windows.Forms.DataGridView DGVNombrePresentacion;
        private System.Windows.Forms.TextBox TxtNombrePresentacion;
        private System.Windows.Forms.Label label2;
    }
}