namespace LuMoura.ul
{
    partial class ADM_CotroleCadastro
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
            groupBox1 = new GroupBox();
            label4 = new Label();
            TxtCodigo = new TextBox();
            dataGridView1 = new DataGridView();
            BtAtualizar = new Button();
            BtBuscar = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            TxtEmail = new TextBox();
            BtMenu = new Button();
            BtCadastrar = new Button();
            label7 = new Label();
            TxtTelefone = new TextBox();
            label6 = new Label();
            label1 = new Label();
            TxtNome = new TextBox();
            label2 = new Label();
            TxtCPF = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(TxtCodigo);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(BtAtualizar);
            groupBox1.Controls.Add(BtBuscar);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(TxtEmail);
            groupBox1.Controls.Add(BtMenu);
            groupBox1.Controls.Add(BtCadastrar);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(TxtTelefone);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(TxtNome);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TxtCPF);
            groupBox1.Location = new Point(2, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1219, 385);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(664, 56);
            label4.Name = "label4";
            label4.Size = new Size(23, 15);
            label4.TabIndex = 28;
            label4.Text = "Id :";
            // 
            // TxtCodigo
            // 
            TxtCodigo.Location = new Point(691, 51);
            TxtCodigo.Name = "TxtCodigo";
            TxtCodigo.Size = new Size(47, 23);
            TxtCodigo.TabIndex = 27;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(288, 158);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(753, 173);
            dataGridView1.TabIndex = 26;
            // 
            // BtAtualizar
            // 
            BtAtualizar.Location = new Point(838, 52);
            BtAtualizar.Name = "BtAtualizar";
            BtAtualizar.Size = new Size(75, 23);
            BtAtualizar.TabIndex = 25;
            BtAtualizar.Text = "Atualizar";
            BtAtualizar.UseVisualStyleBackColor = true;
            BtAtualizar.Click += BtAtualizar_Click;
            // 
            // BtBuscar
            // 
            BtBuscar.Location = new Point(744, 51);
            BtBuscar.Name = "BtBuscar";
            BtBuscar.Size = new Size(75, 23);
            BtBuscar.TabIndex = 24;
            BtBuscar.Text = "Buscar";
            BtBuscar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Lu;
            pictureBox1.Location = new Point(23, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(204, 279);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(244, 116);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 21;
            label3.Text = "E-mail :";
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(288, 112);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(324, 23);
            TxtEmail.TabIndex = 22;
            // 
            // BtMenu
            // 
            BtMenu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtMenu.Location = new Point(79, 19);
            BtMenu.Name = "BtMenu";
            BtMenu.Size = new Size(75, 23);
            BtMenu.TabIndex = 20;
            BtMenu.Text = "Menu";
            BtMenu.UseVisualStyleBackColor = true;
            // 
            // BtCadastrar
            // 
            BtCadastrar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtCadastrar.Location = new Point(638, 112);
            BtCadastrar.Name = "BtCadastrar";
            BtCadastrar.Size = new Size(88, 23);
            BtCadastrar.TabIndex = 19;
            BtCadastrar.Text = "Cadastrar";
            BtCadastrar.UseVisualStyleBackColor = true;
            BtCadastrar.Click += BtCadastrar_Click_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(449, 84);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 11;
            label7.Text = "Telefone :";
            // 
            // TxtTelefone
            // 
            TxtTelefone.Location = new Point(512, 81);
            TxtTelefone.Name = "TxtTelefone";
            TxtTelefone.Size = new Size(100, 23);
            TxtTelefone.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(449, 10);
            label6.Name = "label6";
            label6.Size = new Size(267, 32);
            label6.TabIndex = 10;
            label6.Text = "FICHA DE CADASTRO ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(244, 57);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome :";
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(288, 52);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(324, 23);
            TxtNome.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(256, 85);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 2;
            label2.Text = "CPF :";
            // 
            // TxtCPF
            // 
            TxtCPF.Location = new Point(288, 81);
            TxtCPF.Name = "TxtCPF";
            TxtCPF.Size = new Size(100, 23);
            TxtCPF.TabIndex = 3;
            // 
            // ADM_CotroleCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1233, 450);
            Controls.Add(groupBox1);
            Name = "ADM_CotroleCadastro";
            Text = "ADM_CotroleCadastro";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private TextBox TxtCodigo;
        private DataGridView dataGridView1;
        private Button BtAtualizar;
        private Button BtBuscar;
        private PictureBox pictureBox1;
        private Label label3;
        private TextBox TxtEmail;
        private Button BtMenu;
        private Button BtCadastrar;
        private Label label7;
        private TextBox TxtTelefone;
        private Label label6;
        private Label label1;
        private TextBox TxtNome;
        private Label label2;
        private TextBox TxtCPF;
    }
}