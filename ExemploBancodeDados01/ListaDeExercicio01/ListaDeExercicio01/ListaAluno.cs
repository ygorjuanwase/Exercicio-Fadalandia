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
    public partial class ListaAluno : Form
    {
        public ListaAluno()
        {
            InitializeComponent();
        }

        private void ListaAluno_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            new CadastroAlunos().ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int linhaselecionada = dataGridView1.CurrentRow.Index;
            int codigo = Convert.ToInt32(dataGridView1.Rows[linhaselecionada].Cells[0].Value.ToString());
            new CadastroAlunos(codigo).ShowDialog();
        }
    }
}
