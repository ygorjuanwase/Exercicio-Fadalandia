using ListaDeExercicio01.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicio01
{
    public class AlunoRepositorio
    {
        private string conexaoString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\104967\Documents\Lista_Execicio_01.mdf;Integrated Security=True;Connect Timeout=30";
        private SqlConnection conexao = null;

        public AlunoRepositorio()
        {
            conexao = new SqlConnection(conexaoString);
        }

        public int Inserir(Aluno aluno) 
        {
            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "INSERT INTO alunos(nome, nota_1, nota_2, nota_3, frequancia) OUTPUT INSERTED.ID VALUES (@NOME, @NOTA_1 , @NOTA_2, @NOTA_3 , @FREQUENCIA)";
            comando.Parameters.AddWithValue("@NOME", aluno.Nome);
            comando.Parameters.AddWithValue("@NOTA_1", aluno.Nota1);
            comando.Parameters.AddWithValue("@NOTA_2", aluno.Nota2);
            comando.Parameters.AddWithValue("@NOTA_3", aluno.Nota3);
            comando.Parameters.AddWithValue("@FREQUENCIA", aluno.Frequencia);
            int id = Convert.ToInt32(comando.ExecuteScalar());
            conexao.Close();
            return id; 
        }

        public bool Alterar(Aluno aluno) 
        {
            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"UPDATE alunos SET
nome = @NOME,
NOTA_1 = @NOTA_1,
NOTA_2 = @NOTA_2,
NOTA_3 =@NOTA_3,
FREQUENCIA = @FREQUENCIA
WHERE id = @ID";
            comando.Parameters.AddWithValue("@NOME", aluno.Nome);
            comando.Parameters.AddWithValue("@NOTA_1", aluno.Nota1);
            comando.Parameters.AddWithValue("@NOTA_@", aluno.Nota2);
            comando.Parameters.AddWithValue("@NOTA_3", aluno.Nota3);
            comando.Parameters.AddWithValue("@FREQUENCIA", aluno.Frequencia);
            comando.Parameters.AddWithValue("@ID", aluno.Id);
            int quantidadeAlterada = comando.ExecuteNonQuery();
            conexao.Close();
            return quantidadeAlterada == 1; 
        }
        public List<Aluno> ObterTodos(string textoParaPesquisar = "%%", string colunaOrdenacao = "nome", string tipoOrdenacao = "ASC")
        {
            textoParaPesquisar = "%" + textoParaPesquisar + "%";
            List<Aluno> alunos = new List<Aluno>();
            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"SELECT 
id, nome, nota_1, nota_2, nota_3, frequencia
FROM alunos
WHERE nome LIKE @PESQUISA 
ORDER BY" + colunaOrdenacao + "" + tipoOrdenacao;
            comando.Parameters.AddWithValue("@PESQUISA", textoParaPesquisar);

            DataTable tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());
            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                Aluno aluno = new Aluno();
                aluno.Id = Convert.ToInt32(tabelaEmMemoria.Rows[i][0].ToString());
                aluno.Nome = tabelaEmMemoria.Rows[i][1].ToString();
                aluno.Nota1 =Convert.ToDouble( tabelaEmMemoria.Rows[i][1].ToString());
                aluno.Nota2 =Convert.ToDouble( tabelaEmMemoria.Rows[i][1].ToString());
                aluno.Nota3 =Convert.ToDouble( tabelaEmMemoria.Rows[i][1].ToString());
            }
            conexao.Close();

            return alunos;
        }
        public Aluno ObterPeloCodigo(int codigo)
        {
            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"SELECT id, nome, nota_1, nota_2, nota_3, frequencia FROM alunos WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", codigo);
            DataTable tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());
            if (tabelaEmMemoria.Rows.Count == 0)
            {
                return null;
            }
            Aluno aluno = new Aluno();
            aluno.Id = Convert.ToInt32(tabelaEmMemoria.Rows[0][0].ToString());
            aluno.Nome = tabelaEmMemoria.Rows[0][1].ToString();
            aluno.Nota1 = Convert.ToDouble(tabelaEmMemoria.Rows[0][2].ToString());
            aluno.Nota2 = Convert.ToDouble(tabelaEmMemoria.Rows[0][3].ToString());
            aluno.Nota3 = Convert.ToDouble(tabelaEmMemoria.Rows[0][4].ToString());
            aluno.Frequencia = Convert.ToByte(tabelaEmMemoria.Rows[0][5].ToString());
            conexao.Close();
            return aluno;
        }
        public bool Apagar(int codigo)
        {
            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "DELETE FROM alunos WHERE id = @CODIGO";
            comando.Parameters.AddWithValue("@CODIGO", codigo);
            int quantidade = comando.ExecuteNonQuery();
            conexao.Close();
            return quantidade == 1;
        }

        public double TotalMedia(Aluno aluno)
        {
            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "SELECT alunos, ((nota_1 + nota_2 + nota_3) / 4) AS 'Média dos Alunos' FROM alunos";
            double total = Convert.ToDouble(comando.ExecuteScalar());
            conexao.Close();
            return total;
        }
    }
}