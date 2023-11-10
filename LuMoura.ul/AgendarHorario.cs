﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuMoura.ul
{
    public partial class AgendarHorario : Form
    {
        public AgendarHorario()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textNome_TextChanged(object sender, EventArgs e)
        {
            Agendar horario = new Agendar();
            horario.Exibir(dataGridView1, textNome.Text);

        }

        private void textTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboServiço_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtém o item selecionado no ComboBox
            string servicoSelecionado = comboServiço.SelectedItem?.ToString();

            // Verifica se há um item selecionado antes de chamar o método
            if (!string.IsNullOrEmpty(servicoSelecionado))
            {
                Agendar agendar = new Agendar();
                agendar.Exibir_Servicos(comboServiço);
            }

            else
            {
                Agendar agendar = new Agendar();
                agendar.Exibir_Servicos(comboServiço);
            }
        }


        private void BtnCadastar_Click(object sender, EventArgs e)
        {

            DateTime dataSelecionada = monthCalendar1.SelectionStart; // Substitua 'monthCalendar1' pelo nome do seu controle MonthCalendar

            // Agora, você pode formatar a data em uma string com o formato desejado
            //string dataFormatada = dataSelecionada.ToString("dd/MM/yyyy");
            //MessageBox.Show(dataFormatada);


            //DateTime dataSelecionada = monthCalendar1.Value;
            //string dataSelecionadaString = dataSelecionada.ToString("dd/MM/yyyy");


            Agendar agendar = new Agendar();
            agendar.agendar(dataSelecionada, textNome.Text, textTelefone.Text, comboServiço.Text, textDescricao.Text);


            


                        
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textDescricao_TextChanged(object sender, EventArgs e)
        {
            //Agendar agendar = new Agendar();
            //agendar.agendar(textNome.Text, textTelefone.Text,comboServiço.Text, textDescricao.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AreaCliente_Cadastro areaCliente_Cadastro = new AreaCliente_Cadastro();
            areaCliente_Cadastro.Show();
           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Agendar agendar = new Agendar();
            agendar.Atualizar(dataGridView1);
        }

        private void AgendarHorario_Load(object sender, EventArgs e)
        {
            string servicoSelecionado = comboServiço.SelectedItem?.ToString();

            // Verifica se há um item selecionado antes de chamar o método
            if (!string.IsNullOrEmpty(servicoSelecionado))
            {
                Agendar agendar = new Agendar();
                agendar.Exibir_Servicos(comboServiço);
            }

            else
            {
                Agendar agendar = new Agendar();
                agendar.Exibir_Servicos(comboServiço);
            }
        }
    }
}
