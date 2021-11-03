using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace InicioTriagem
{
    public partial class Form3 : Form
    {
        Thread ab;
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            ab = new Thread(inicio);
            ab.SetApartmentState(ApartmentState.STA);
            ab.Start();
        }

        private void inicio()
        {
            //volta para o inicio
            Application.Run(new Form1());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //na hora de fechar pergunta se quer ou não fechar
            if (MessageBox.Show("Fechar o Programa?", "Fechar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        
    }
}
