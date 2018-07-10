using ExemploBancoDados02.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploBancoDados02.Repositorio
{
    class HeroiRepositorio
    {
        private string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\104967\Documents\ExemploBancoDados02.mdf;Integrated Security=True;Connect Timeout=30";
        private SqlConnection connection = null;

        public HeroiRepositorio()
        {
            connection = new SqlConnection(connectionString);
        }
        public bool Inserir(Heroi heroi) {
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "INSERT INTO herois(nome, escuridao, nome_pessoa, raca, conta_bancaria, data_nascimento, sexo, quantidade_filmes, descricao) VALUES(@NOME,@ESCURIDAO,@NOME_PESSOA,@RACA,@CONTA_BANCARIA,@DATA_NASCIMENTO,@SEXO,@QUANTIDADE_FILMES,@DESCRICAO)";


            command.Parameters.AddWithValue("@NOME", heroi.Nome);
            command.Parameters.AddWithValue("@ESCURIDAO",         heroi.Escuridao);
            command.Parameters.AddWithValue("@NOME_PESSOA",       heroi.NomePessoa);
            command.Parameters.AddWithValue("@RACA",              heroi.Raca);
            command.Parameters.AddWithValue("@CONTA_BANCARIA",    heroi.ContaBancaria);
            command.Parameters.AddWithValue("@DATA_NASCIMENTO",   heroi.DataNascimento);
            command.Parameters.AddWithValue("@SEXO",              heroi.Sexo);
            command.Parameters.AddWithValue("@QUANTIDADE_FILMES", heroi.QuantidadeFilmes);
            command.Parameters.AddWithValue("@DESCRICAO",         heroi.Descricao);
            int quantidadeRegistros = command.ExecuteNonQuery();
            connection.Close();
            return quantidadeRegistros == 1;
        }
        public bool Alterar(Heroi heroi) { return false; }
        public List<Heroi> ObterTodos(string textoParaPesquisar = "%%",
            string colunaOrdenacao = "nome",
            string tipoOrdenacao = "ASC") {
                textoParaPesquisar = "%" + textoParaPesquisar + "%";
            List<Heroi> herois = new List<Heroi>();
            connection.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = connection;

            comando.CommandText = @"SELECT id, nome, raca, conta_bancaria FROM herois WHERE nome LIKE @PESQUISA  OR raca LIKE @PESQUISA ORDER BY " + colunaOrdenacao + " " + tipoOrdenacao;
            comando.Parameters.AddWithValue("@PESQUISA", textoParaPesquisar);
            comando.Parameters.AddWithValue("#COLUNA", colunaOrdenacao);
            comando.Parameters.AddWithValue("@ORDEM", tipoOrdenacao);
            DataTable tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());
            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                Heroi heroi = new Heroi();
                heroi.ID = Convert.ToInt32(tabelaEmMemoria.Rows[i][0].ToString());
                heroi.Nome = tabelaEmMemoria.Rows[i][1].ToString();
                heroi.Raca = tabelaEmMemoria.Rows[i][2].ToString();
                heroi.ContaBancaria = Convert.ToDouble(tabelaEmMemoria.Rows[i][3].ToString());
                herois.Add(heroi);
            }
            connection.Close();
            return herois; }
        public Heroi ObterPeloCodigo(int codigo) { return null; }
        public bool apagar(int codigo) {

            connection.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = connection;
            comando.CommandText = "DELETE FROM herois WHERE id = @CODIGO";
            comando.Parameters.AddWithValue("@CODIGO", codigo);
            int quantidade = comando.ExecuteNonQuery();
            connection.Close();
            return quantidade == 1; 
        }
    }
}
