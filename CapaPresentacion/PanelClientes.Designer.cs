namespace CapaPresentacion
{
    partial class PanelClientes
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
            this.LbClientes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LbClientes
            // 
            this.LbClientes.AutoSize = true;
            this.LbClientes.BackColor = System.Drawing.Color.Transparent;
            this.LbClientes.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbClientes.ForeColor = System.Drawing.Color.White;
            this.LbClientes.Location = new System.Drawing.Point(43, 39);
            this.LbClientes.Name = "LbClientes";
            this.LbClientes.Size = new System.Drawing.Size(98, 23);
            this.LbClientes.TabIndex = 1;
            this.LbClientes.Text = "Clientes";
            this.LbClientes.Click += new System.EventHandler(this.LbClientes_Click);
            // 
            // PanelClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(682, 415);
            this.Controls.Add(this.LbClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PanelClientes";
            this.Text = "PanelClientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbClientes;
    }
}