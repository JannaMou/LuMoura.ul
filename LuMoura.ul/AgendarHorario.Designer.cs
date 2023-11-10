namespace LuMoura.ul
{
    partial class AgendarHorario
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textTelefone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnCadastar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboServiço = new System.Windows.Forms.ComboBox();
            this.textDescricao = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(28, 39);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(9, 9, 9, 10);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            this.monthCalendar1.TodayDate = new System.DateTime(2023, 11, 8, 0, 0, 0, 0);
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(564, 29);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(405, 26);
            this.textNome.TabIndex = 2;
            this.textNome.TextChanged += new System.EventHandler(this.textNome_TextChanged);
            // 
            // textTelefone
            // 
            this.textTelefone.Location = new System.Drawing.Point(564, 74);
            this.textTelefone.Name = "textTelefone";
            this.textTelefone.Size = new System.Drawing.Size(405, 26);
            this.textTelefone.TabIndex = 3;
            this.textTelefone.TextChanged += new System.EventHandler(this.textTelefone_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(490, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(466, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telefone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(478, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Serviço:";
            // 
            // BtnCadastar
            // 
            this.BtnCadastar.BackColor = System.Drawing.Color.Thistle;
            this.BtnCadastar.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCadastar.Location = new System.Drawing.Point(759, 113);
            this.BtnCadastar.Name = "BtnCadastar";
            this.BtnCadastar.Size = new System.Drawing.Size(170, 23);
            this.BtnCadastar.TabIndex = 8;
            this.BtnCadastar.Text = "Cadastar Horario";
            this.BtnCadastar.UseVisualStyleBackColor = false;
            this.BtnCadastar.Click += new System.EventHandler(this.BtnCadastar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Thistle;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(412, 225);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // comboServiço
            // 
            this.comboServiço.FormattingEnabled = true;
            this.comboServiço.Items.AddRange(new object[] {
            "Pé e mão ",
            "Pé ",
            "Mão",
            "Postiça",
            "Adesivo",
            "Esmaltação",
            "Esmaltação infantil",
            "SPA dos Pés",
            "Cuticulagem",
            "Decoração acréscimo",
            "Designer de sobrancelhas",
            "Limpeza sobrancelhas"});
            this.comboServiço.Location = new System.Drawing.Point(564, 123);
            this.comboServiço.Name = "comboServiço";
            this.comboServiço.Size = new System.Drawing.Size(405, 26);
            this.comboServiço.TabIndex = 10;
            this.comboServiço.SelectedIndexChanged += new System.EventHandler(this.comboServiço_SelectedIndexChanged);
            // 
            // textDescricao
            // 
            this.textDescricao.Location = new System.Drawing.Point(564, 182);
            this.textDescricao.Multiline = true;
            this.textDescricao.Name = "textDescricao";
            this.textDescricao.Size = new System.Drawing.Size(405, 72);
            this.textDescricao.TabIndex = 11;
            this.textDescricao.TextChanged += new System.EventHandler(this.textDescricao_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LavenderBlush;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.textDescricao);
            this.groupBox1.Controls.Add(this.comboServiço);
            this.groupBox1.Controls.Add(this.textNome);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.textTelefone);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1000, 584);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agendar Horário";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.monthCalendar1);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Controls.Add(this.BtnCadastar);
            this.groupBox2.Location = new System.Drawing.Point(25, 282);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(950, 240);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Horários";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Thistle;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(315, 39);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(418, 162);
            this.dataGridView2.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Thistle;
            this.button1.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(842, 545);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Cadastrar   🠖";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(459, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Descrição:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Thistle;
            this.button2.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(25, 545);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "🠔  Atualizar ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(645, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "label1";
            // 
            // AgendarHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 613);
            this.Controls.Add(this.groupBox1);
            this.Name = "AgendarHorario";
            this.Text = "AgendarHorario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private TextBox textNome;
        private TextBox textTelefone;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button BtnCadastar;
        private DataGridView dataGridView1;
        private ComboBox comboServiço;
        private TextBox textDescricao;
        private GroupBox groupBox1;
        private Label label5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView2;
        public MonthCalendar monthCalendar1;
        private GroupBox groupBox2;
        private Label label1;
    }
}