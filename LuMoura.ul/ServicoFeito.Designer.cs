namespace LuMoura.ul
{
    partial class ServicoFeito
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
            this.GridCliente = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // GridCliente
            // 
            this.GridCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCliente.Location = new System.Drawing.Point(50, 105);
            this.GridCliente.Name = "GridCliente";
            this.GridCliente.RowTemplate.Height = 25;
            this.GridCliente.Size = new System.Drawing.Size(700, 286);
            this.GridCliente.TabIndex = 1;
            this.GridCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridCliente_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(321, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "SERVICOS EXECUTADOS";
            // 
            // ServicoFeito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridCliente);
            this.Name = "ServicoFeito";
            this.Text = "ServicoFeito";
            this.Load += new System.EventHandler(this.ServicoFeito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView GridCliente;
        private Label label1;
    }
}