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

        public void agendar(string Nome, string CPF ,string Telefone, string Email)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LuMoura;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            conn.Open();

            SqlCommand cmd = new SqlCommand("insert into Agendamento values ( '" + Nome + "'," + CPF+ ", '"+Telefone+"','"+Email+"', GETDATE())", conn);

            cmd.ExecuteNonQuery();

        }

        public void Cadastrar(string Nome, string Telefone, string Email)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=FAC0539709W10-1;Initial Catalog=LuMoura.DB;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            conn.Open();

            SqlCommand cmd = new SqlCommand("insert into Agendamento values ( '" + Nome + "', '" + Telefone + "','" + Email + "', GETDATE())", conn);

        }
        

    }
}
