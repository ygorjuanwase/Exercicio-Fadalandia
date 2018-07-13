using Listaexercicio01.Modelo;
using Listaexercicio01.Repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listaexercicio01
{
    public partial class CadastroAluno : Form
    {
        private int codigo;
        public CadastroAluno()
        {
            InitializeComponent();
        }
        public CadastroAluno(int codigo)
        {
            InitializeComponent();
            this.codigo = codigo;
            Aluno aluno = new AlunoRepositorio().ObterPeloCodigo(codigo);
            PreencherCampos(aluno);
        }

        private void PreencherCampos(Aluno aluno)
        {
            txtnome.Text = aluno.Nome;
            txtcodigo.Text = Convert.ToString(aluno.Id);
            txtNota1.Text = Convert.ToString(aluno.Nota1);
            txtNota2.Text = Convert.ToString(aluno.Nota2);
            txtNota3.Text = Convert.ToString(aluno.Nota3);
            txtFrequencia.Text = Convert.ToString(aluno.Frequencia);
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();
            aluno.Nome = txtnome.Text;
            aluno.Nota1 = Convert.ToDouble(txtNota1.Text);
            aluno.Nota2 = Convert.ToDouble(txtNota2.Text);
            aluno.Nota3 = Convert.ToDouble(txtNota3.Text);
            aluno.Frequencia = Convert.ToByte(txtFrequencia.Text);
            if (string.IsNullOrEmpty(txtcodigo.Text))
            {
                int id = new AlunoRepositorio().Inserir(aluno);
                txtcodigo.Text = Convert.ToString(id);
                MessageBox.Show("Registro cadastrado com sucesso");
            }
            else
            {
                int id = Convert.ToInt32(txtcodigo.Text);
                aluno.Id = id;
                bool alterou = new AlunoRepositorio().Alterar(aluno);
                if (alterou)
                {
                    MessageBox.Show("Registro alterado com seucesso");
                }
                else
                {
                    MessageBox.Show("Não foi possivel alterar");
                }
            }
        }

    

        private void txtcodigo_Leave(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtcodigo.Text))
            {
                try
                {
                    int id = Convert.ToInt32(txtcodigo.Text);
                    Aluno aluno = new AlunoRepositorio().ObterPeloCodigo(id);
                    if(aluno != null)
                    {
                        PreencherCampos(aluno);
                    }
                    else
                    {
                        MessageBox.Show("Registro não existente");
                        txtcodigo.Focus();
                        txtcodigo.SelectionStart = 0;
                        txtcodigo.SelectionLength = txtcodigo.Text.Length;
                    }
                }
                catch(NotFiniteNumberException ex)
                {
                    MessageBox.Show("Digite um código válid");
                    txtcodigo.Focus();

                }
            }
        }
    }
}
