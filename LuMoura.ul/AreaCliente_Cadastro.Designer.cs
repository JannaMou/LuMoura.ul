namespace LuMoura.ul
{
    partial class AreaCliente_Cadastro
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
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            TxtEmail = new TextBox();
            BtCadastrar = new Button();
            label7 = new Label();
            TxtTelefone = new TextBox();
            label6 = new Label();
            label1 = new Label();
            TxtNome = new TextBox();
            label2 = new Label();
            TxtCPF = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(TxtEmail);
            groupBox1.Controls.Add(BtCadastrar);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(TxtTelefone);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(TxtNome);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TxtCPF);
            groupBox1.Location = new Point(1, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1231, 372);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.salao_de_beleza_adesivo_decoracao;
            pictureBox2.Location = new Point(845, 34);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(380, 320);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Lu;
            pictureBox1.Location = new Point(109, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(210, 320);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(396, 221);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 21;
            label3.Text = "E-mail :";
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(440, 217);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(324, 23);
            TxtEmail.TabIndex = 22;
            // 
            // BtCadastrar
            // 
            BtCadastrar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtCadastrar.Location = new Point(559, 304);
            BtCadastrar.Name = "BtCadastrar";
            BtCadastrar.Size = new Size(88, 28);
            BtCadastrar.TabIndex = 19;
            BtCadastrar.Text = "Cadastrar";
            BtCadastrar.UseVisualStyleBackColor = true;
            BtCadastrar.Click += BtCadastrar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(601, 189);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 11;
            label7.Text = "Telefone :";
            // 
            // TxtTelefone
            // 
            TxtTelefone.Location = new Point(664, 186);
            TxtTelefone.Name = "TxtTelefone";
            TxtTelefone.Size = new Size(100, 23);
            TxtTelefone.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(463, 72);
            label6.Name = "label6";
            label6.Size = new Size(267, 32);
            label6.TabIndex = 10;
            label6.Text = "FICHA DE CADASTRO ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(396, 162);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome :";
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(440, 157);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(324, 23);
            TxtNome.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(408, 190);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 2;
            label2.Text = "CPF :";
            // 
            // TxtCPF
            // 
            TxtCPF.Location = new Point(440, 186);
            TxtCPF.Name = "TxtCPF";
            TxtCPF.Size = new Size(100, 23);
            TxtCPF.TabIndex = 3;
            // 
            // AreaCliente_Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1243, 450);
            Controls.Add(groupBox1);
            Name = "AreaCliente_Cadastro";
            Text = "AreaCliente_Cadastro";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label3;
        private TextBox TxtEmail;
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