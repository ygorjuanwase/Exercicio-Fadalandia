using ListaDeExercicio01.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaDeExercicio01
{
    public partial class CadastroAlunos : Form
    {
        private int codigo;
        public CadastroAlunos()
        {
            InitializeComponent();
        }

        public CadastroAlunos(int codigo)
        {
            InitializeComponent();
            this.codigo = codigo;
            Aluno aluno = new AlunoRepositorio().ObterPeloCodigo(codigo);
            PreencherCampos(aluno);

        }

        private void PreencherCampos(Aluno aluno)
        {
            txtNome.Text = aluno.Nome;
            txtNota1.Text = Convert.ToString(aluno.Nota1);
            txtNota2.Text = Convert.ToString(aluno.Nota2);
            txtNota3.Text = Convert.ToString(aluno.Nota3);
            txtFrequencia.Text = Convert.ToString(aluno.Frequencia);
            textBox1.Text = Convert.ToString(aluno.Id);
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();
            aluno.Nome = txtNome.Text;
            aluno.Nota1 = Convert.ToDouble(txtNota1.Text);
            aluno.Nota2 = Convert.ToDouble(txtNota2.Text);
            aluno.Nota3 = Convert.ToDouble(txtNota3.Text);
            aluno.Frequencia = Convert.ToByte(txtFrequencia.Text);

          
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                int id = new AlunoRepositorio().Inserir(aluno);
                textBox1.Text = Convert.ToString(id);
                MessageBox.Show("Registro cadastrado com sucesso");
            }
            else
            {
                int id = Convert.ToInt32(textBox1.Text);
                aluno.Id = id;
                bool alterou = new AlunoRepositorio().Alterar(aluno);
                if (alterou)
                {
                    MessageBox.Show("Registro alterado com secesso");
                }
                else
                {
                    MessageBox.Show("Não foi possivel alterar o registro");
                }
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                try
                {
                    int id = Convert.ToInt32(textBox1.Text);
                    Aluno aluno = new AlunoRepositorio().ObterPeloCodigo(id);
                    if (aluno != null)
                    {
                        PreencherCampos(aluno);
                    }
                    else
                    {
                        MessageBox.Show("Registro não existente");
                        textBox1.Focus();
                        textBox1.SelectionStart = 0;
                        textBox1.SelectionLength = textBox1.Text.Length;
                    }
                }
                catch(NotFiniteNumberException ex)
                {
                    MessageBox.Show("Digite um código válido");
                    textBox1.Focus();
                }
            }
        }

    }
}
