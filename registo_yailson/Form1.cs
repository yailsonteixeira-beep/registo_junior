using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace registo_yailson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            iniciar_sessao iniciar = new iniciar_sessao();
            iniciar.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            registar registar = new registar();
            registar.Show();
            this.Hide();
        }
    }
}
