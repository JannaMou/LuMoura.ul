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



        public void agendar(DateTime dataAgendamento, string nome, string telefone, string servico, string descricao)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=FAC0539709W10-1;Initial Catalog=LuMoura.DB;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Agendamentos (FK_ServicoID, FK_HorarioID, DataAgendamento, NomeCliente, Telefone, Servico, Descricao) " +
                    "SELECT Servicos.ServicoID, Horarios.HorarioID, @DataAgendamento, @NomeCliente, @Telefone, @Servico, @Descricao " +
                    "FROM Servicos " +
                    "INNER JOIN Horarios ON Servicos.AlgumaColuna = Horarios.OutraColuna " +
                    "WHERE AlgumaCondição;", conn))
                {
                    cmd.Parameters.AddWithValue("@DataAgendamento", dataAgendamento);
                    cmd.Parameters.AddWithValue("@NomeCliente", nome);
                    cmd.Parameters.AddWithValue("@Telefone", telefone);
                    cmd.Parameters.AddWithValue("@Servico", servico);
                    cmd.Parameters.AddWithValue("@Descricao", descricao);

                    cmd.ExecuteNonQuery();
                }
            }
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

    }
}
