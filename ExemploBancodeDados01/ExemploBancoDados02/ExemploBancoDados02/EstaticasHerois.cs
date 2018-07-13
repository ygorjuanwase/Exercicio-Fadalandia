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
    public partial class EstaticasHerois : Form
    {
        public EstaticasHerois()
        {
            InitializeComponent();
        }

        private void EstaticasHerois_Load(object sender, EventArgs e)
        {
            double TotalContas = new HeroiRepositorio().ObterTotalContas();
            lblTotalContasBancarias.Text = Convert.ToString(TotalContas);
        }
    }
}
