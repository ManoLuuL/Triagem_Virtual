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
using System.IO;

namespace InicioTriagem
{
    public partial class Form1 : Form
    {
        Thread ab;
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //na hora de fechar pergunta se quer ou não fechar
            if (MessageBox.Show("Fechar a Triagem?", "Fechar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Não Atenda Pacientes SEM Máscara! \nUse sempre Álcool em Gel!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //botão que abre outro form
            this.Close();
            ab = new Thread(novoForm);
            ab.SetApartmentState(ApartmentState.STA);
            ab.Start();
            
            string folder = @"C:\Triagem"; //nome do diretorio a ser criado
            //Se o diretório não existir...

            if (!Directory.Exists(folder))
            {

                //Criamos um 
                Directory.CreateDirectory(folder);

            }

        }

        private void novoForm()
        {
            //RODA O FORM2
            Application.Run(new Form2());
        }    
        
        private void Creditos_Click(object sender, EventArgs e)
        {
            //botão que abre o form de creditos
            this.Close();
            ab = new Thread(credito);
            ab.SetApartmentState(ApartmentState.STA);
            ab.Start();
        }

        private void credito()
        {
            //RODA OS CREDITOS
            Application.Run(new Form3());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //botão que abre o form de sobre o programa 
            this.Close();
            ab = new Thread(comousar);
            ab.SetApartmentState(ApartmentState.STA);
            ab.Start();
        }

        private void comousar()
        {
            //RODA O como usar
            Application.Run(new Form4());
        }

        
    }
}
