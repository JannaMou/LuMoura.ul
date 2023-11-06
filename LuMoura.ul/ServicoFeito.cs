using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuMoura.ul
{
    public partial class ServicoFeito : Form
    {
        public ServicoFeito()
        {
            InitializeComponent();
        }

        private void ServicoFeito_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LuMoura;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Servicos order by ServicosID desc", conn);

            SqlDataReader dr = cmd.ExecuteReader();
            BindingSource bs = new BindingSource();

            bs.DataSource = dr;
            GridCliente.DataSource = bs;

        }

        private void GridCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}
