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
            this.TxtOpc = new System.Windows.Forms.TextBox();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // GridCliente
            // 
            this.GridCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCliente.Location = new System.Drawing.Point(230, 128);
            this.GridCliente.Name = "GridCliente";
            this.GridCliente.RowTemplate.Height = 25;
            this.GridCliente.Size = new System.Drawing.Size(558, 273);
            this.GridCliente.TabIndex = 1;
            this.GridCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridCliente_CellContentClick);
            // 
            // TxtOpc
            // 
            this.TxtOpc.Location = new System.Drawing.Point(230, 102);
            this.TxtOpc.Name = "TxtOpc";
            this.TxtOpc.Size = new System.Drawing.Size(100, 23);
            this.TxtOpc.TabIndex = 2;
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.Location = new System.Drawing.Point(137, 98);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.BtnPesquisar.TabIndex = 3;
            this.BtnPesquisar.Text = "PESQUISAR";
            this.BtnPesquisar.UseVisualStyleBackColor = true;
            // 
            // ServicoFeito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnPesquisar);
            this.Controls.Add(this.TxtOpc);
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
        private TextBox TxtOpc;
        private Button BtnPesquisar;
    }
}