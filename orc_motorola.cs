using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PI_final_1
{
    public partial class orc_motorola : Form
    {
        int b2, b3, b4, b5, b6, b7, b8;
        Menu_manutencao mm;
        int orc_prev_motorola;
        string txt_motorola;
        public orc_motorola(Menu_manutencao M_m)
        {
            InitializeComponent();
            mm = M_m;//Designando variavel para comunicar os dados com menu principal
        }
        private void orc_motorola_Load(object sender, EventArgs e)
        {//Buscando os valores dos servicos
            string[] motorola = System.IO.File.ReadAllLines(@"C:\c# prog\PI_2sem_f\PI_final_1\PI_final_1\Orcamentos\orc_motorola.txt");
            
            foreach( string line in motorola)
            {
                string[] serv = line.Split('.');

                //convertendo para cocatenacao
                b2 = Convert.ToInt32(serv[0]);
                b3 = Convert.ToInt32(serv[1]);
                b4 = Convert.ToInt32(serv[2]);
                b5 = Convert.ToInt32(serv[3]);
                b6 = Convert.ToInt32(serv[4]);
                b7 = Convert.ToInt32(serv[5]);
                b8 = Convert.ToInt32(serv[6]);

            }

        }
        private void text2_motorola_Click(object sender, EventArgs e)
        {

        }

        private void bot1_motorola_Click(object sender, EventArgs e)
        {
            if (textbox1_orc_motorola.Text == "")//Caso nao contenha texto, nao deixaria seguir com orcamento 
            {
                MessageBox.Show("Insira o modelo do aparelho!");
                return;
            }
            //Quando selecionado o servico, puxara uma interface com mais informacoes sobre o servico
            botao1 tela = new botao1();
            tela.ShowDialog();

        }

        private void bot2_motorola_Click(object sender, EventArgs e)
        {
            if (textbox1_orc_motorola.Text == "")//Caso nao contenha texto, nao deixaria seguir com orcamento 
            {
                MessageBox.Show("Insira o modelo do aparelho!");
                return;
            }
            //Quando selecionado o servico, puxara uma interface com mais informacoes sobre o servico
            botao2 tela = new botao2();
            tela.ShowDialog();
            //Cocatenando os valores gerados pela ação click
            orc_prev_motorola += b2;
            //Mostrando o valor dessa cocatenação
            textbox_out_motorola.Text = "R$" + Convert.ToString(orc_prev_motorola);

        }

        private void bot3_motorola_Click(object sender, EventArgs e)
        {
            if (textbox1_orc_motorola.Text == "")//Caso nao contenha texto, nao deixaria seguir com orcamento 
            {
                MessageBox.Show("Insira o modelo do aparelho!");
                return;
            }
            //Cocatenando os valores gerados pela ação click
            orc_prev_motorola += b3;
            //Mostrando o valor dessa cocatenação
            textbox_out_motorola.Text = "R$" + Convert.ToString(orc_prev_motorola);
            //Quando selecionado o servico, puxara uma interface com mais informacoes sobre o servico
            botao3 tela = new botao3();
            tela.ShowDialog();
        }

        private void bot4_motorola_Click(object sender, EventArgs e)
        {
            if (textbox1_orc_motorola.Text == "")//Caso nao contenha texto, nao deixaria seguir com orcamento 
            {
                MessageBox.Show("Insira o modelo do aparelho!");
                return;
            }
            //Cocatenando os valores gerados pela ação click
            orc_prev_motorola += b4;
            //Mostrando o valor dessa cocatenação
            textbox_out_motorola.Text = "R$" + Convert.ToString(orc_prev_motorola);
            //Quando selecionado o servico, puxara uma interface com mais informacoes sobre o servico
            botao4 tela = new botao4();
            tela.ShowDialog();
        }

        private void bot5_motorola_Click(object sender, EventArgs e)
        {
            if (textbox1_orc_motorola.Text == "")//Caso nao contenha texto, nao deixaria seguir com orcamento 
            {
                MessageBox.Show("Insira o modelo do aparelho!");
                return;
            }
            //Cocatenando os valores gerados pela ação click
            orc_prev_motorola += b5;
            //Mostrando o valor dessa cocatenação
            textbox_out_motorola.Text = "R$" + Convert.ToString(orc_prev_motorola);
            //Quando selecionado o servico, puxara uma interface com mais informacoes sobre o servico
            botao5 tela = new botao5();
            tela.ShowDialog();
        }

        private void bot6_motorola_Click(object sender, EventArgs e)
        {
            if (textbox1_orc_motorola.Text == "")//Caso nao contenha texto, nao deixaria seguir com orcamento 
            {
                MessageBox.Show("Insira o modelo do aparelho!");
                return;
            }
            //Cocatenando os valores gerados pela ação click
            orc_prev_motorola += b6;
            //Mostrando o valor dessa cocatenação
            textbox_out_motorola.Text = "R$" + Convert.ToString(orc_prev_motorola);
            //Quando selecionado o servico, puxara uma interface com mais informacoes sobre o servico
            botao6 tela = new botao6();
            tela.ShowDialog();
        }

        private void bot7_motorola_Click(object sender, EventArgs e)
        {
            if (textbox1_orc_motorola.Text == "")//Caso nao contenha texto, nao deixaria seguir com orcamento 
            {
                MessageBox.Show("Insira o modelo do aparelho!");
                return;
            }
            //Cocatenando os valores gerados pela ação click
            orc_prev_motorola += b7;
            //Mostrando o valor dessa cocatenação
            textbox_out_motorola.Text = "R$" + Convert.ToString(orc_prev_motorola);
            //Quando selecionado o servico, puxara uma interface com mais informacoes sobre o servico
            botao7 tela = new botao7();
            tela.ShowDialog();
        }

        private void bot8_motorola_Click(object sender, EventArgs e)
        {
            if (textbox1_orc_motorola.Text == "")//Caso nao contenha texto, nao deixaria seguir com orcamento 
            {
                MessageBox.Show("Insira o modelo do aparelho!");
                return;
            }
            //Cocatenando os valores gerados pela ação click
            orc_prev_motorola += b8;
            //Mostrando o valor dessa cocatenação
            textbox_out_motorola.Text = "R$" + Convert.ToString(orc_prev_motorola);
            //Quando selecionado o servico, puxara uma interface com mais informacoes sobre o servico
            botao8 tela = new botao8();
            tela.ShowDialog();
        }

        private void bot_cancel_motorola_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bot_clear_motorola_Click(object sender, EventArgs e)
        {
            textbox_out_motorola.Clear();
            Close();
        }

        private void bot_concluir_motorola_Click(object sender, EventArgs e)
        {
            txt_motorola = textbox1_orc_motorola.Text;

            mm.mod_motorola = txt_motorola;
            mm.objeto_orc_motorola = orc_prev_motorola;
            Close();
        }

        
    }
}
