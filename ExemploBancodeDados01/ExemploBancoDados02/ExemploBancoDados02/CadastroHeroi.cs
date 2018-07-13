using ExemploBancoDados02.Modelo;
using ExemploBancoDados02.Repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploBancoDados02
{
    public partial class Form1 : Form
    {
        private int codigo;

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(int codigo)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            this.codigo = codigo;
            Heroi heroi = new HeroiRepositorio().ObterPeloCodigo(codigo);
            PreencherCampos(heroi);

        }

        private void PreencherCampos(Heroi heroi)
        {
            txtNome.Text = heroi.Nome;
            txtNomePessoa.Text = heroi.NomePessoa;
            txtCodigo.Text = Convert.ToString(heroi.ID);
            txtContaBancaria.Text = Convert.ToString(heroi.ContaBancaria);
            txtQuantidadeFilmes.Text = Convert.ToString(heroi.QuantidadeFilmes);
            cbMulher.Checked = heroi.Sexo == 'm';
            cbRaca.SelectedItem = heroi.Raca;
            rtbDescricao.Text = heroi.Descricao;
            if (heroi.Escuridao)
            {
                rbSim.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Heroi heroi = new Heroi();
            heroi.Nome = txtNome.Text;
            heroi.NomePessoa = txtNomePessoa.Text;
            heroi.ContaBancaria = Convert.ToDouble(txtContaBancaria.Text);
            heroi.DataNascimento = dtpDataNascimento.Value;
            heroi.Escuridao = true;
            heroi.QuantidadeFilmes = Convert.ToByte(txtQuantidadeFilmes.Text);
            heroi.Raca = cbRaca.SelectedItem.ToString();
            heroi.Sexo = cbMulher.Checked ? 'm' : 'h';
            heroi.Descricao = rtbDescricao.Text;
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                int id = new HeroiRepositorio().Inserir(heroi);
                txtCodigo.Text = Convert.ToString(id);
                MessageBox.Show("Registro cadastrado com sucesso");
            }
            else
            {
                int id = Convert.ToInt32(txtCodigo.Text);
                heroi.ID = id;
                bool alterou = new HeroiRepositorio().Alterar(heroi);
                if (alterou)
                {
                    MessageBox.Show("Registro alterdado com sucesso");
                }
                else
                {
                    MessageBox.Show("Não foi possivel aletrar");
                }
            }


            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodigo.Text))
            {
                try
                {
                    int id = Convert.ToInt32(txtCodigo.Text);
                    Heroi heroi = new HeroiRepositorio().ObterPeloCodigo(id);
                    if(heroi != null)
                    {
                        PreencherCampos(heroi);
                    }
                    else
                    {
                        MessageBox.Show("Registro nao existe");
                        txtCodigo.Focus();
                        txtCodigo.SelectionStart = 0;
                        txtCodigo.SelectionLength = txtCodigo.Text.Length;
                    }
                }
                catch(NotFiniteNumberException)
                {
                    MessageBox.Show("Digite um código válido");
                    txtCodigo.Focus();
                }
            }
        }

       

        
    }
}
