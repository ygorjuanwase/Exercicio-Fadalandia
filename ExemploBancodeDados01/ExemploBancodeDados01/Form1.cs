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

namespace ExemploBancodeDados01
{
    public partial class Form1 : Form
    {
        private string caminhoConexao = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\104967\Documents\ExemploBancodeDados01.mdf;Integrated Security=True;Connect Timeout=30";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastar_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(caminhoConexao);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;
            command.CommandText = "INSERT INTO cores VALUES(@NOME)";


            string corDigitada = txtcor.Text;
            command.Parameters.AddWithValue("@NOME",corDigitada);
            command.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void btnatualizar_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = caminhoConexao;
            conexao.Open();
            SqlCommand comando = new SqlCommand("SELECT nome FROM cores;");
            comando.Connection = conexao;
            
            DataTable dataTable = new DataTable();
            //Executa o comando e retorna um SQLDATAreader
            dataTable.Load(comando.ExecuteReader());
            //Criar em memória uma tabela
            //ExecuteReader EXecuta o comando e retor
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i <dataTable.Rows.Count ; i++)
            {
                string cor = dataTable.Rows[i][0].ToString();
                sb.AppendLine(cor);
            }
            richTextBox1.Clear();
            richTextBox1.AppendText(sb.ToString());

            conexao.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(caminhoConexao);
            connection.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "DELETE FROM cores WHERE nome = @NOMEDACOR";
            string corParaApagar = cbApagar.SelectedItem.ToString();
            command.Parameters.AddWithValue("@NOMEDACOR", corParaApagar);
            command.ExecuteNonQuery();
            cbApagar.SelectedIndex = -1;
            connection.Close();
        }

        private void cbApagar_DropDown(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(caminhoConexao);
            conexao.Open();
            SqlCommand command = new SqlCommand("SELECT nome FROM cores ORDER BY nome", conexao);
            DataTable table = new DataTable();
            table.Load(command.ExecuteReader());
            cbApagar.Items.Clear();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                cbApagar.Items.Add(table.Rows[i][0].ToString());
            }
            conexao.Close();

        }

        private void cbApagar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbApagar.SelectedIndex != -1)
            {
                txtnovoNome.Text = cbApagar.SelectedItem.ToString();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(caminhoConexao);
            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "UPDATE cores SET nome = @NOVONOME WHERE nome = @ANTIGONOME";


            string novoNome = txtnovoNome.Text;
            string antigoNome = cbApagar.SelectedItem.ToString();

            comando.Parameters.AddWithValue("@NOVONOME", novoNome);
            comando.Parameters.AddWithValue("@ANTIGONOME", antigoNome);
            comando.ExecuteNonQuery();
            cbApagar.SelectedIndex = -1;
            txtnovoNome.Clear();
            conexao.Close();
        }
    }
}
