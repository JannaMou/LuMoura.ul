using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LuMoura.ul
{
    public partial class AreaCliente_Cadastro : Form
    {
        public AreaCliente_Cadastro()
        {
            InitializeComponent();
        }

        private void BtCadastrar_Click(object sender, EventArgs e)
        {
            {
                CadastroDAL objdal = new CadastroDAL();
                objdal.FichaCadastro(TxtNome.Text, TxtCPF.Text, TxtTelefone.Text, TxtEmail.Text);
                TxtNome.Text = ""; TxtCPF.Text = ""; TxtTelefone.Text = ""; TxtEmail.Text = "";

                TxtNome.Text = "";
                TxtCPF.Text = "";
                TxtTelefone.Text = "";
                TxtEmail.Text = "";
            }

        }

        private void BtCadastrar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
