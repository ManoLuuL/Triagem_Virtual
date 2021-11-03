using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace InicioTriagem
{
    public partial class Form4 : Form
    {
        Thread AB;
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Fechar a Triagem?", "Fechar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            AB = new Thread(inicio);
            AB.SetApartmentState(ApartmentState.STA);
            AB.Start();
        }

        private void inicio()
        {
            Application.Run(new Form1());
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
