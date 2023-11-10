using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LuMoura.ul
{
    internal class Agendar
    {

        public void Exibir_Servicos( ComboBox item)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=FAC0539709W10-1;Initial Catalog=LuMoura.DB;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            conn.Open();

            // Use parâmetros SQL para evitar problemas de SQL Injection
            SqlCommand cmd = new SqlCommand("SELECT * FROM Servicos", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            item.Items.Clear();

            while (reader.Read())
            {
                item.Items.Add(reader["NomeServico"].ToString());
            }
        }


        public void agendar(DateTime Dataa, string Nome, string Telefone, string Servico, string Descricao)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=FAC0539709W10-1;Initial Catalog=LuMoura.DB;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            conn.Open();

            SqlCommand cmd = new SqlCommand("insert into Agendamentos values (2, 2,'" + Dataa + "','" + Nome+ "','"+Telefone+"','"+Servico+"','"+Descricao+"')", conn);

            cmd.ExecuteNonQuery();
                
        }

        public void Cadastrar(string Nome, string Telefone, string Email)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=FAC0539709W10-1;Initial Catalog=LuMoura.DB;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            conn.Open();

            SqlCommand cmd = new SqlCommand("insert into Agendamento values ( '" + Nome + "', '" + Telefone + "','" + Email + "', GETDATE())", conn);

        }
        
        public void Atualizar(DataGridView dataGridView1)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=FAC0539709W10-1;Initial Catalog=LuMoura.DB;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False");
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Cliente", conn);

            SqlDataReader dr = cmd.ExecuteReader();
            BindingSource bs = new BindingSource();
            bs.DataSource = dr;
            dataGridView1.DataSource = bs;
        }

        public void Exibir(DataGridView dataGridView1, string nome)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=FAC0539709W10-1;Initial Catalog=LuMoura.DB;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False");
            conn.Open();

            //SqlCommand cmd = new SqlCommand("SELECT * FROM Cliente WHERE Nome LIKE '%" + nome + "%'", conn);

            

            SqlCommand cmd = new SqlCommand("SELECT * FROM Cliente WHERE Nome LIKE '%" + nome + "%'", conn);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = dr;
                dataGridView1.DataSource = bs;
            }
            else
            {
                MessageBox.Show("Usuário não encontrado.");
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="descricao"></param>
        /// <param name="valor"></param>
        /// <returns></returns>
        public void AdicionarServico(string nome, string descricao, decimal valor, int horario)

        {
            string textoComVirgula = valor.ToString();
            string textoComPonto = textoComVirgula.Replace(",", ".");

            /// >ATUALIZAR< /// ADICIONAR LINK DO BANCO DE DADOS///
            SqlConnection conn = new SqlConnection(@"Data Source=FAC0539709W10-1;Initial Catalog=LuMoura.DB;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            conn.Open();

            SqlCommand cmd = new SqlCommand("insert into Servicos values ('" + nome + "','" + descricao + "', " + textoComPonto + " , " + horario + " )", conn);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Serviço cadastrado com sucesso!");

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public void ExcluirServico(int id)

        {
            /// >ATUALIZAR< /// ADICIONAR LINK DO BANCO DE DADOS///
            SqlConnection conn = new SqlConnection(@"Data Source=FAC0539709W10-1;Initial Catalog=LuMoura.DB;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            conn.Open();

            SqlCommand cmd = new SqlCommand("delete from Servicos where ServicoId= " + id + "", conn);


            cmd.ExecuteNonQuery();
            MessageBox.Show("Serviço Cancelado!");

        }

        public void Atualizar(string nome, string descricao, decimal valor, int horario, int id)

        {
            string textoComVirgula1 = valor.ToString();

            string textoComPonto1 = textoComVirgula1.Replace(",", ".");

            /// >ATUALIZAR< /// ADICIONAR LINK DO BANCO DE DADOS///
            SqlConnection conn = new SqlConnection(@"Data Source=FAC0539709W10-1;Initial Catalog=LuMoura.DB;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            conn.Open();

            SqlCommand cmd = new SqlCommand("UPDATE Servicos SET NomeServico = '" + nome + "', DescricaoServico = '" + descricao + "', ValorServico = " + textoComPonto1 + " , DuracaoEmHoras = " + horario + "  where ServicoID = " + id, conn);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Serviço atualizado com sucesso!");
        }

    }
}
