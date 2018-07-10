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
    public partial class Lista_Usuaroi : Form
    {
        public Lista_Usuaroi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form1().ShowDialog();
        }

        private void Lista_Usuaroi_Load(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void AtualizarLista()
        {

            string coluna = "nome";
            if (rbRaca.Checked)
            {
                coluna = "raca";
            }
            else if (rbContabancaria.Checked)
            {
                coluna = "conta_bancaria";
            }
            string tipoOrdenacao = "ASC";
            if (rbDESC.Checked)
            {
                tipoOrdenacao = "DESC";
            }
            dataGridView1.Rows.Clear();
            List<Heroi> herois = new HeroiRepositorio().ObterTodos(textBox1.Text, coluna, tipoOrdenacao);
            foreach (Heroi heroi in herois)
            {
                dataGridView1.Rows.Add(new object[]{
                    heroi.ID,
                    heroi.Nome,
                    heroi.Raca,
                    heroi.ContaBancaria
                });
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int linhaSelecionada = dataGridView1.CurrentRow.Index;
            int codigo =Convert.ToInt32(dataGridView1.Rows[linhaSelecionada].Cells[0].Value.ToString());
            bool apagado =  new HeroiRepositorio().apagar(codigo);
            if (apagado)
            {
                dataGridView1.Rows.RemoveAt(linhaSelecionada);
                MessageBox.Show("Registro apagado com sucesso");
            }
            else
            {
                MessageBox.Show("não foi possivel apagar");
            }
            
        }

       
    }
}
