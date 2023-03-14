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

namespace ProjetoIntegrador
{
    public partial class frmDatagridPesquisaContrato : Form
    {
        public frmDatagridPesquisaContrato()
        {

            
            InitializeComponent();
            TestarConexao();

        }
        string stringconexao = "data source=localhost; initial catalog=ProjetoIntegradorT_13; user ID=sa; password=123456";

        public string _codigo;

        private void TestarConexao()
        {
            SqlConnection conn = new SqlConnection(stringconexao);

            try
            {
                conn.Open();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
                Application.Exit();
            }
        }

        private void frmDatagridPesquisaContrato_Load(object sender, EventArgs e)
        {

        }

        private void dataGridParceiroPesquisa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      //  private void dataGridParceiroPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
       // {
           // _codigo = dataGridParceiroPesquisa.CurrentRow.Cells["ID"].Value.ToString();
            //this.Close();
       // }
    }
}
