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
        public Form1()
        {
            InitializeComponent();
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
            bool cadastrou = new HeroiRepositorio().Inserir(heroi);
            if (cadastrou)
            {
                MessageBox.Show("Registro cadastrado com sucesso");
            }
            else
            {
                MessageBox.Show("Deu ruim, chame os prog");
            }

        }

        
    }
}
