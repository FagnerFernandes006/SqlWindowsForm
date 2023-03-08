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

using MySql.Data.MySqlClient;


namespace WindowsFormSql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            listRegister.View = View.Details;
            listRegister.LabelEdit = true;
            listRegister.AllowColumnReorder = true;
            listRegister.FullRowSelect = true;
            listRegister.GridLines = true;

            listRegister.Columns.Add("ID", 30, HorizontalAlignment.Left);
            listRegister.Columns.Add("Nome", 207, HorizontalAlignment.Left);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                string data_source = "datasource=localhost;username=root;password=1234567;database=db_agenda";
                //string data_source = "server=localhost;password=1234567;user=root;database=db_agenda"; SqlServer conexao
                string nome = campoNome.Text;

                MySqlConnection conexao = new MySqlConnection(data_source);

                string sql = "INSERT INTO contatos (nome) VALUES ('" + nome + "')";

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                conexao.Open();

                comando.ExecuteReader();

                MessageBox.Show("Registro inserido com sucesso");

                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void select_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = string.Empty;
                string data_source = "datasource=localhost;username=root;password=1234567;database=db_agenda";
                //string data_source = "server=localhost;password=1234567;user=root;database=db_agenda"; SqlServer conexao
                string nome = campoNome.Text;

                MySqlConnection conexao = new MySqlConnection(data_source);

                conexao.Open();

                if (campoNome.Text == "")
                    sql = "select * from contatos";
                else
                {
                    sql = $"select * from contatos where nome like '%{campoNome.Text}%'";
                }

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                MySqlDataReader reader = comando.ExecuteReader();

                listRegister.Items.Clear();

                while (reader.Read())
                {
                    string[] row =
                    {
                        reader.GetString(0),
                        reader.GetString(1)
                    };
                    var register = new ListViewItem(row);

                    listRegister.Items.Add(register);
                }
                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int itemId = int.Parse(listRegister.SelectedItems[0].Text);
                string data_source = "datasource=localhost;username=root;password=1234567;database=db_agenda";
                //string data_source = "server=localhost;password=1234567;user=root;database=db_agenda"; SqlServer conexao
                string nome = campoNome.Text;

                MySqlConnection conexao = new MySqlConnection(data_source);

                string sql = $"delete from contatos where id = {itemId}";

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                conexao.Open();

                comando.ExecuteReader();

                MessageBox.Show("Registro excluido com sucesso");

                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        private void campoNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void listRegister_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
