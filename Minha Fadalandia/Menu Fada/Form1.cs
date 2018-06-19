using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_Fada
{
    public partial class Form1 : Form
    {
        string nomeAntigo = string.Empty;
        List<Fadalandia> fadas = new List<Fadalandia>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void btnCadastroRapido_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void btncadastrar1_Click(object sender, EventArgs e)
        {

            try
            {
                Fadalandia fadinha = new Fadalandia(txtNome.Text, txtFamilia.Text, txtElemento.Text)
                {
              
                    CorAsa = txtCorAsa.Text,
                    TamanhoAsa = Convert.ToInt32(txtTamanhoAsa.Text),
                    Idade = Convert.ToInt32(txtIdade.Text)
                };
                if (nomeAntigo == "")
                {
                    fadas.Add(fadinha);
                    AdicionarFadaATabela(fadinha);
                }
                else
                {
                    int Linha = fadas.FindIndex(x => x.Nome == nomeAntigo);
                    fadas[Linha] = fadinha;
                    EditarFadaNaTabela(fadinha, Linha);
                    MessageBox.Show("Cadastrada com sucesso");
                }
                LimparCampos();
                tabControl1.SelectedIndex = 0;
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void EditarFadaNaTabela(Fadalandia fadinha, int Linha)
        {
            dataGridView1.Rows[Linha].Cells[0].Value = fadinha.Nome;
            dataGridView1.Rows[Linha].Cells[1].Value = fadinha.Familia;
            dataGridView1.Rows[Linha].Cells[2].Value = fadinha.Elemento;
            dataGridView1.Rows[Linha].Cells[3].Value = fadinha.TamanhoAsa;
        }

        private void AdicionarFadaATabela(Fadalandia fadinha)
        {
            dataGridView1.Rows.Add(new Object[] { fadinha.Nome, fadinha.Familia, fadinha.Elemento, fadinha.TamanhoAsa });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Cadastre uma fada Please.");
                tabControl1.SelectedIndex = 1;
                return;
            }
            int LinhaSelecionada = dataGridView1.CurrentRow.Index;
            string nome = dataGridView1.Rows[LinhaSelecionada].Cells[0].Value.ToString();
            for (int i = 0; i < fadas.Count(); i++)
            {
                Fadalandia fadona = fadas[i];
                if (fadona.Nome == nome)
                {
                    fadas.RemoveAt(i);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            Dispose();
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            txtFamilia.Text = "";
            txtCorAsa.Text = "";
            txtTamanhoAsa.Text = "";
            txtIdade.Text = "";
            txtElemento.Text = "";
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Cadastre uma fada");
                tabControl1.SelectedIndex = 1;
                return;
            }
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selecione a linha que queres apagar");
                return;
            }
            int linhaSelecionada = dataGridView1.CurrentRow.Index;
            string nome = dataGridView1.Rows[linhaSelecionada].Cells[0].Value.ToString();
            for (int i = 0; i < fadas.Count(); i++)
            {
                Fadalandia fada = fadas[i];
                if (fada.Nome == nome)
                {
                    fadas.RemoveAt(i);
                }
            }
            dataGridView1.Rows.RemoveAt(linhaSelecionada);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Cadastre uma fadinha!");
                tabControl1.SelectedIndex = 1;
                return;
            }
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selecione um arquivo para editar");
                return;
            }
            int linhaSelecionada = dataGridView1.CurrentRow.Index;
            string nome = dataGridView1.Rows[linhaSelecionada].Cells[0].Value.ToString();
            foreach (Fadalandia fada in fadas)
            {
                if (fada.Nome == nome)
                {
                    txtNome.Text = fada.Nome;
                    txtFamilia.Text = fada.Familia;
                    txtCorAsa.Text = fada.CorAsa;
                    txtTamanhoAsa.Text = Convert.ToString(fada.TamanhoAsa);
                    txtElemento.Text = fada.Elemento;
                    nomeAntigo = fada.Nome;
                    txtIdade.Text = Convert.ToString(fada.Idade);
                    tabControl1.SelectedIndex = 1;
                    break;
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                 Fadalandia fada = new Fadalandia(txtNome.Text);
                {
                    fada.Nome = txtNome1.Text;
                    fada.Familia = txtFamilia1.Text;
                    fada.TamanhoAsa = Convert.ToInt32(txtTamanhoAsa1.Text);
                    fada.Elemento = txtElemento1.Text;
                };
                if (nomeAntigo == "")
                {
                    fadas.Add(fada);
                    AdicionarFadasATabela(fada);
                }
                else
                {
                    int linha = fadas.FindIndex(x => x.Nome == nomeAntigo);
                    fadas[linha] = fada;
                    EditarFadaNaTabela(fada, linha);
                    MessageBox.Show("Cadastrada com secesso");
                    nomeAntigo = string.Empty;
                }
                LimparCampos();
                tabControl1.SelectedIndex = 0;
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void AdicionarFadasATabela(Fadalandia fada)
        {
            dataGridView1.Rows.Add(new Object[]{
                fada.Nome, fada.Familia, fada.Elemento, fada.Idade 
            });
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

      
    }
}
