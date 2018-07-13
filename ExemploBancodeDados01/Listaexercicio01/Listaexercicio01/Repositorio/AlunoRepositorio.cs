using Listaexercicio01.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listaexercicio01.Repositorio
{
    class AlunoRepositorio
    {
        private string connectinoString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\104967\Documents\Exercicio01.mdf;Integrated Security=True;Connect Timeout=30";
        private SqlConnection connection = null;

        public AlunoRepositorio()
        {
            connection = new SqlConnection(connectinoString);
        }
        public int Inserir(Aluno aluno)
        {
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "INSERT INTO alunos (nome, codigo_matricula, nota_1, nota_2, nota-3, frequencia) OUTPUT INSERTED.ID VALUES(@nome, @CODIGO_MATRICULA,@nota_1@,nota_2,@nota_3, @frequencia)";
            command.Parameters.AddWithValue("@NOME", aluno.Nome);
            command.Parameters.AddWithValue("@CODIGO_MATRICULA", aluno.Codigo);
            command.Parameters.AddWithValue("@NOTA_1", aluno.Nota1);
            command.Parameters.AddWithValue("@NOTA_2", aluno.Nota2);
            command.Parameters.AddWithValue("@NOTA_3", aluno.Nota3);
            command.Parameters.AddWithValue("@FREQUENCIA", aluno.Frequencia);
            
            int id = Convert.ToInt32(command.ExecuteScalar().ToString());
            connection.Close();
            return id;
        }
        public bool Alterar(Aluno aluno)
        {
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = @"UPDATE alunos SET
nome = @NOME,
codigo_matricula = @CODIGO_MATRICULA,
nota_1 = @NOTA_1,
nota_2 = @NOTA_2,
nota_3 = NOTA_3,
frequencia = @FREQUENCIA
WHERE id = @ID";
            command.Parameters.AddWithValue("@NOME", aluno.Nome);
            command.Parameters.AddWithValue("@CODIGO_MATRICULA", aluno.Codigo);
            command.Parameters.AddWithValue("@NOTA_1", aluno.Nota1);
            command.Parameters.AddWithValue("@NOTA_2", aluno.Nota2);
            command.Parameters.AddWithValue("@NOTA_3", aluno.Nota3);
            command.Parameters.AddWithValue("@FREQUENCIA", aluno.Frequencia);
            command.Parameters.AddWithValue("@ID", aluno.Id);
            int quantidadeAlterada = command.ExecuteNonQuery();
            connection.Close();
            return quantidadeAlterada == 1;
        }
        public List<Aluno> ObterTodos(string textoParaPesquisar = "%%", string colunaOrdenacao = "nome", string tipoOrdenacao = "ASC")
        {
            textoParaPesquisar = "%" + textoParaPesquisar + "%";
            List<Aluno> alunos = new List<Aluno>();
            connection.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = connection;
            comando.CommandText = @"SELECT id, nome,codigo_matricula, nota_1, nota_2, nota_3, frequencia FROM alunos WHERE nome LIKE @PESQUISA ORDER BY" + colunaOrdenacao + " " + tipoOrdenacao;
            comando.Parameters.AddWithValue("@PESQUISA", textoParaPesquisar);
            DataTable tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());
            for (int i = 0; i < tabelaEmMemoria.Rows.Count ; i++)
            {
                Aluno aluno = new Aluno();
                aluno.Id = Convert.ToInt32(tabelaEmMemoria.Rows[i][0].ToString());
                aluno.Nome = tabelaEmMemoria.Rows[i][0].ToString();
                aluno.Nota1 = Convert.ToDouble(tabelaEmMemoria.Rows[i][0].ToString());
                aluno.Nota2 = Convert.ToDouble(tabelaEmMemoria.Rows[i][0].ToString());
                aluno.Nota3 = Convert.ToDouble(tabelaEmMemoria.Rows[i][0].ToString());
                aluno.Frequencia = Convert.ToByte(tabelaEmMemoria.Rows[i][0].ToString());
            }
            connection.Close();
            return alunos;
        }
        public Aluno ObterPeloCodigo(int codigo)
        {
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = @"SELECT 
id,
nome,
nota_1,
nota_2,
nota_3, 
frequencia,
codigo_matricula
FROM alunos
WHERE id = @ID";
            command.Parameters.AddWithValue("@ID", codigo);
            DataTable tabeleEmMemoria = new DataTable();
            tabeleEmMemoria.Load(command.ExecuteReader());
            if (tabeleEmMemoria.Rows.Count == 0)
            {
                return null;
            }
            Aluno aluno = new Aluno();
            aluno.Id = Convert.ToInt32(tabeleEmMemoria.Rows[0][0].ToString());
            aluno.Nome = tabeleEmMemoria.Rows[0][1].ToString();
            aluno.Nota1 = Convert.ToDouble(tabeleEmMemoria.Rows[0][2].ToString());
            aluno.Nota2 = Convert.ToDouble(tabeleEmMemoria.Rows[0][3].ToString());
            aluno.Nota3 = Convert.ToDouble(tabeleEmMemoria.Rows[0][4].ToString());
            aluno.Frequencia = Convert.ToByte(tabeleEmMemoria.Rows[0][5].ToString());
            connection.Close();
            return aluno;
        }
        public bool Apagar(int codigo)
        {
            connection.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = connection;
            comando.CommandText = "DELETE FROM alunos WHERE id = @CODIGO";
            comando.Parameters.AddWithValue("@CODIGO", codigo);
            int quantidade = comando.ExecuteNonQuery();
            connection.Close();
            return quantidade == 1;
        }       
    }
}
