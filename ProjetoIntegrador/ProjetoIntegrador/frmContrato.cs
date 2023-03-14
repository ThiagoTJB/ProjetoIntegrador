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
    public partial class frmContrato : Form
    {
        string stringconexao = "data source=localhost; initial catalog=ProjetoIntegradorT_13; user ID=sa; password=123456";


        private void testarconexao()
        {

            SqlConnection conn = new SqlConnection(stringconexao);

            try
            {
                conn.Open();
                conn.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("erro: " + ex.ToString());
                Application.Exit();
            }


        }

        public frmContrato()
        {
            InitializeComponent();
            testarconexao();
        }

        private void frmContrato_Load(object sender, EventArgs e)
        {

        }


      

        private void dtpEmissao_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btoPesquisar_Click(object sender, EventArgs e)
        {
            if (txtIdParceiro.Text.Trim() == "")
            {
                frmDatagridPesquisaContrato dor = new frmDatagridPesquisaContrato();
                dor.ShowDialog();
                txtIdParceiro.Text = dor._codigo;
            }




            //string sql = "select * from Contrato where id_parceiro_contrato = " + txtIdParceiro.Text;


            /*string sql = "select pa.nome_Parceiro, pl.nome_planos from Parceiro as pa " +
                             "inner join  planos as pl on pa.id_Parceiro = pl.id_planos" +
                             "where id_parceiro_contrato = " + txtIdParceiro.Text;
            */

             string sql = "select co.id_parceiro_contrato, pa.CNPJ_Parceiro,pa.nome_Parceiro from Contrato as co inner join parceiro as pa on id_parceiro_contrato = id_Parceiro where co.id_parceiro_contrato =" + txtIdParceiro.Text;

            SqlConnection conexao = new SqlConnection(stringconexao);
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            conexao.Open();

            try
            {
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {

                    txtIdParceiro.Text = reader[0].ToString();
                    txtCnpj.Text=reader[1].ToString();
                    txtNomeParceiro.Text =reader[2].ToString();

                    


                }


                else
                {
                    MessageBox.Show("Categoria inexistente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conexao.Close();

            }
        }

        private void btoPesquisar2_Click(object sender, EventArgs e)
        {
           




            //string sql = "select * from Contrato where id_parceiro_contrato = " + txtIdParceiro.Text;


            /*string sql = "select pa.nome_Parceiro, pl.nome_planos from Parceiro as pa " +
                             "inner join  planos as pl on pa.id_Parceiro = pl.id_planos" +
                             "where id_parceiro_contrato = " + txtIdParceiro.Text;
            */

            string sql = "select  co.id_planos_contrato, pl.nome_planos, pl.preço_planos, pl.Tipo_planos from planos as pl inner join contrato as co on id_planos_contrato = id_planos where co.id_planos_contrato = " + txtIdPlano.Text;

            SqlConnection conexao = new SqlConnection(stringconexao);
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            conexao.Open();

            try
            {
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {

                   
                   txtNomePlano.Text = reader[1].ToString();
                    txtValorPlano.Text= reader[2].ToString();
                    txtTipoPlano.Text=reader[3].ToString();





                }


                else
                {
                    MessageBox.Show("Categoria inexistente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conexao.Close();

            }
        }

        private void btoCadastrar_Click(object sender, EventArgs e)
        {
            string vCusto = txtValorPlano.Text;
            //R$ 1.000,00
            vCusto = vCusto.Replace("R$ ", ""); //1.000,00
            vCusto = vCusto.Replace(".", ""); //1000,00
            vCusto = vCusto.Replace(',', '.');//1000.00



        }
    }
}


 

