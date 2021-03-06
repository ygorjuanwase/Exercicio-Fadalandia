﻿using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuFada
{
    public partial class Form1 : Form
    {
        string nomeAntigo = string.Empty;
        List<Fadalandia> fadas = new List<Fadalandia>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            txtFamilia.Text = "";
            txtCorAsa.Text = "";
            txtTamanhoAsa.Text = "";
            txtElemento.Text = "";
            txtIdade.Text = "";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                Fadalandia fadinha = new Fadalandia(txtNome.Text, txtFamilia.Text, txtCorAsa.Text);
                {
                    fadinha.Nome = txtNome.Text;
                    fadinha.CorAsa = txtCorAsa.Text;
                    fadinha.Familia = txtFamilia.Text;
                    fadinha.TamanhoAsa = Convert.ToInt32(txtTamanhoAsa.Text);
                    fadinha.Idade = Convert.ToInt32(txtIdade.Text);
                };
                if(nomeAntigo == "")
                {
                    fadas.Add(fadinha);
                    AdicionarFadaATabela(fadinha);
                }
                else
                {
                    int Linha = fadas.FindIndex(x => x.Nome == nomeAntigo);
                    fadas[Linha] = fadinha;
                    EditarFadaNaTabela(fadinha, Linha);
                    MessageBox.Show("Alterado com sucesso");
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

        private void button2_Click(object sender, EventArgs e)
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

        private void button10_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                Fadalandia fadinha = new Fadalandia(txtNome.Text, txtFamilia.Text, txtCorAsa.Text);
                {
                    fadinha.Nome = txtNome.Text;
                    fadinha.CorAsa = txtCorAsa.Text;
                    fadinha.Familia = txtFamilia.Text;
                    fadinha.TamanhoAsa = Convert.ToInt32(txtTamanhoAsa.Text);
                    fadinha.Idade = Convert.ToInt32(txtIdade.Text);
                };
                if(nomeAntigo == "")
                {
                    fadas.Add(fadinha);
                    AdicionarFadaATabela(fadinha);
                }
                else
                {
                    int Linha = fadas.FindIndex(x => x.Nome == nomeAntigo);
                    fadas[Linha] = fadinha;
                    EditarFadaNaTabela(fadinha, Linha);
                    MessageBox.Show("Alterado com sucesso");
                }
                LimparCampos();
                tabControl1.SelectedIndex = 0;
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
            Fadalandia fada = new Fadalandia(txtNomeR.Text, txtFamiliaR.Text, txtElementoR.Text)
            {

            };
        }
        }

       

       

       
    }

