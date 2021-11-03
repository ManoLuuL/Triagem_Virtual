using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace InicioTriagem
{
    public partial class Form2 : Form
    {
        Thread ab;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //na hora de fechar pergunta se quer ou não fechar
            if (MessageBox.Show("Fechar o Programa?", "Fechar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
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
            Application.Run(new Form1());
        }


        private void button3_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Cuidado se o Paciente apresentar falta de AR, Dores Fortes ou algum outro sintoma do Coronavirus, encaminhar imediatamente para o centro de COVID-19!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            string nome; string sexo;
            DateTime datahj;
            string idade; string nasc;
            string estadocv; string natu;
            string tel; string cel;
            string email; string email2;
            string rg; string cpf;
            string pressao; string temp; string frecard;
            string alergia; string alergiaS;
            string observacao;
            string vomito;
            string prorecnt;
            string dorservera; string dormodera; string dorpreco; string dorpleur;
            string pulsoanor; string choq; string respira; string disp; string calaf;
            

            tel = maskedTextBox1.Text; cel = maskedTextBox2.Text;
            datahj = dateTimePicker1.Value;
            nome = textBox1.Text; sexo = comboBox1.Text;
            idade = maskedTextBox8.Text; nasc = maskedTextBox9.Text;
            estadocv = comboBox2.Text; natu = comboBox3.Text;
            email = textBox3.Text; email2 = comboBox7.Text;
            rg = maskedTextBox3.Text; cpf = maskedTextBox4.Text;
            pressao = maskedTextBox5.Text; temp = maskedTextBox6.Text; frecard = maskedTextBox7.Text;
            alergia = comboBox8.Text; alergiaS = textBox4.Text;
            observacao = textBox5.Text;
         

            Document doc = new Document(PageSize.A4);
            doc.SetMargins(25, 25, 25, 25);
            string caminho = @"C:\Triagem\" + nome  + ".pdf";

            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));
           
            //vomito
            if (VomitoS.Checked == true)
                vomito = " Sim";
            else
                vomito = " Não";
            //problema recente
            if (ProbRecent.Checked == true)
                prorecnt = " Sim";
            else
                prorecnt = " Não";
            //dores severas
            if (dorseve.Checked == true)
                dorservera = " Sim";
            else
                dorservera = " Não";
            //dores moderadas
            if (Dormord.Checked == true)
                dormodera = " Sim";
            else
                dormodera = " Não";
            //dores precordiais
            if (Dorprec.Checked == true)
                dorpreco = " Sim";
            else
                dorpreco = " Não";
            //dores pleuriticas
            if (Dorpleu.Checked == true)
                dorpleur = " Sim";
            else
                dorpleur = " Não";
            //pulso anormal
            if (Pulso.Checked == true)
                pulsoanor = " Sim";
            else
                pulsoanor = " Não";
            //choque
            if (Choque.Checked == true)
                choq = " Sim";
            else
                choq = " Não";
            //problema na respiração
            if (Respi.Checked == true)
                respira = " Sim";
            else
                respira = " Não";
            //dispneia aguda
            if (Dispneia.Checked == true)
                disp = " Sim";
            else
                disp = " Não";
            //calafrio
            if (Cfrio.Checked == true)
                calaf = " Sim";
            else
                calaf = " Não";

            doc.Open();

            //ermegencia
            if (ERME.Checked == true)
            {
                string erm = "https://1.bp.blogspot.com/-_qmwGu9sj4o/YG5P7-ujohI/AAAAAAAAAgY/wsMOSXnYpQ0vN3Cs7GLHS31k-cwFxsLXgCLcBGAsYHQ/s320/bola%2Bvermelha.png";
                Image imga = Image.GetInstance(erm);
                imga.Alignment = Element.ALIGN_LEFT;
                imga.ScaleAbsolute(25, 25);
                doc.Add(imga);
            }
            //muito urgente
            if(MTURG.Checked == true)
            {
                string mtug = "https://1.bp.blogspot.com/-OXAyTZvaZa8/YG5P7nmdqtI/AAAAAAAAAgU/W1qbZ_fJBVIPmyQLTs6ukwgJIhY5hp_AgCLcBGAsYHQ/s320/bola%2Blaranja.png";
                Image imga = Image.GetInstance(mtug);
                imga.Alignment = Element.ALIGN_LEFT;
                imga.ScaleAbsolute(25, 25);
                doc.Add(imga);
            }
            //urgente
            if(URG.Checked == true)
            {
                string mtug = "https://1.bp.blogspot.com/-LFnagHrHXLo/YG5P60TF4YI/AAAAAAAAAgQ/nQq2hp70Sp4NgSSbWfgwi1Mwcq7gzsoNwCLcBGAsYHQ/s320/bola%2Bamarela.png";
                Image imga = Image.GetInstance(mtug);
                imga.Alignment = Element.ALIGN_LEFT;
                imga.ScaleAbsolute(25, 25);
                doc.Add(imga);
            }
            //pouco urgente
            if(PCURG.Checked == true)
            {
                string mtug = "https://1.bp.blogspot.com/-yMBAyn6youo/YG5P602PsFI/AAAAAAAAAgI/kfFjSOIoYN8xfm6h4oMDrhySGWk4Ic3IQCLcBGAsYHQ/s320/Bola%2Bverde.png";
                Image imga = Image.GetInstance(mtug);
                imga.Alignment = Element.ALIGN_LEFT;
                imga.ScaleAbsolute(25, 25);
                doc.Add(imga);
            }
            //não urgente
            if(NDURG.Checked == true)
            {
                string mtug = "https://1.bp.blogspot.com/-JcMP26ZX01k/YG5P7Dfmy7I/AAAAAAAAAgM/sylTGWpm1fsg-M5UOapoGHcMh_2K1haQwCLcBGAsYHQ/s320/Bola%2Bazul.png";
                Image imga = Image.GetInstance(mtug);
                imga.Alignment = Element.ALIGN_LEFT;
                imga.ScaleAbsolute(25, 25);
                doc.Add(imga);
            }

            Paragraph titulo = new Paragraph();
            titulo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.COURIER, 30);
            titulo.Alignment = Element.ALIGN_CENTER;
            titulo.Add("Triagem\n\n");
            doc.Add(titulo);

            Paragraph Entrada = new Paragraph("", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12));
            string conteudo = "Entrada:" + datahj + "\n";
            Entrada.Add(conteudo);
            doc.Add(Entrada);

            Paragraph Nome = new Paragraph("", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12));
            string conteudo1 = "Nome:" + nome + "\nSexo:" + sexo + "\nEstado Civil:" + estadocv + "\nNaturalidade:" + natu;
            Nome.Add(conteudo1);
            doc.Add(Nome);

            Paragraph dado1 = new Paragraph("", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12));
            string conteudo2 = "Nascimento: " + nasc + "\nIdade:" + idade + "\nRG:" + rg + "  CPF:" + cpf + "\n";
            dado1.Add(conteudo2);
            doc.Add(dado1);

            Paragraph dado2 = new Paragraph("", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12));
            string conteudo3 = "Telefone:" + tel + " Celular:" + cel + "\nEmail:" + email + "" + email2 + "\n\n";
            dado2.Add(conteudo3);
            doc.Add(dado2);

            Paragraph dado3 = new Paragraph("", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12));
            string conteudo4 = "Pressão Arterial:" + pressao + "\nTemperatura:" + temp + "\nFrequencia Cardiaca:" + frecard + "\n\n";
            dado3.Add(conteudo4);
            doc.Add(dado3);

            Paragraph dado4 = new Paragraph("", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12));
            string cont = "Possui Alergia:" + alergia + "\nAlergico há:" + alergiaS + "\n\n";
            dado4.Add(cont);
            doc.Add(dado4);

            Paragraph dado5 = new Paragraph("", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12));
            string cont1 = "Vómitos:" + vomito + "\nProblemas Recentes:"+ prorecnt + "\nDores Severas:"+ dorservera + "\nDores Moderadas:"+ dormodera + "\nDor Precordial:"+ dorpreco +"\nDor Pleuritica:"+ dorpleur 
                + "\nPulso Anormal:"+ pulsoanor + "\nChoque:"+ choq + "\nProblema de Respiração:"+ respira + "\nCalafrio:"+ calaf + "\nDispneia Aguda:"+ disp;
            dado5.Add(cont1);
            doc.Add(dado5);

            Paragraph obs = new Paragraph("", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12));
            string cont2 = "Observações e Acrescimos de Informações: \n" + observacao;
            obs.Add(cont2);
            doc.Add(obs);

            
            doc.Close();
            System.Diagnostics.Process.Start(caminho);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            ab = new Thread(novoForm);
            ab.SetApartmentState(ApartmentState.STA);
            ab.Start();
        }

        private void novoForm()
        {
            Application.Run(new Form2());
        }

        private void Choque_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
