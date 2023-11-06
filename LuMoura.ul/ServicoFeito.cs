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
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LojaVirtualDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            conn.Open();

            SqlCommand cmd = new SqlCommand("Select * from Cliente where nome like '%" + TxtOpc.Text + "%' ORDER BY IdCliente DESC", conn);

            SqlDataReader dr = cmd.ExecuteReader();

            BindingSource bs = new BindingSource();
            bs.DataSource = dr;

            GridCliente.DataSource = bs;

            GridCliente.CellContentClick += (sender, e) =>
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == GridCliente.Columns["BtnExcluir"].Index)
                {
                    GridCliente.Rows.RemoveAt(e.RowIndex); // Remove a linha clicada
                }
            };

        }
    }
    }
}
