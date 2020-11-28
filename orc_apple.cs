using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_final_1
{
    public partial class orc_apple : Form
    {
        Menu_manutencao mm;
        int orc_prev_apple;
        string txt_apple;
        int b2, b3, b4, b5, b6, b7, b8;
        public orc_apple(Menu_manutencao M_m)
        {
            InitializeComponent();
            mm = M_m;//Designando variavel para comunicar os dados com menu principal
        }
        private void orc_apple_Load(object sender, EventArgs e)
        {//Buscando os valores dos servicos
            string[] apple = System.IO.File.ReadAllLines(@"C:\Users\Lucas\Downloads\PI_final_1-20201128T174615Z-001\PI_final_1\Orcamentos\orc_apple.txt");

            foreach(string line in apple)
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



        private void bot1_apple_Click(object sender, EventArgs e) 
        {
            if (textbox1_orc_apple.Text == "")  //Caso nao contenha texto, nao deixaria seguir com orcamento                   
            {
                MessageBox.Show("Insira o modelo do aparelho!");
                return;
            }
            
            //Quando selecionado o servico, puxara uma interface com mais informacoes sobre o servico
            botao1 tela = new botao1();
            tela.ShowDialog();
        }

        private void bot2_apple_Click(object sender, EventArgs e)
        {
            if (textbox1_orc_apple.Text == "")//Caso nao contenha texto, nao deixaria seguir com orcamento
            {
                MessageBox.Show("Insira o modelo do aparelho!");
                return;
            }
            //Cocatenando os valores gerados pela ação click
            orc_prev_apple += b2;
            //Mostrando o valor dessa cocatenação
            textbox_out_apple.Text = "R$" + Convert.ToString(orc_prev_apple);
            //Quando selecionado o servico, puxara uma interface com mais informacoes sobre o servico
            botao2 tela = new botao2();
            tela.ShowDialog();
        }

        private void bot3_apple_Click(object sender, EventArgs e)
        {
            if (textbox1_orc_apple.Text == "")//Caso nao contenha texto, nao deixaria seguir com orcamento
            {
                MessageBox.Show("Insira o modelo do aparelho!");
                return;
            }
            //Cocatenando os valores gerados pela ação click
            orc_prev_apple += b3;
            //Mostrando o valor dessa cocatenação
            textbox_out_apple.Text = "R$" + Convert.ToString(orc_prev_apple);
            //Quando selecionado o servico, puxara uma interface com mais informacoes sobre o servico
            botao3 tela = new botao3();
            tela.ShowDialog();
        }

        private void bot4_apple_Click(object sender, EventArgs e)
        {
            if (textbox1_orc_apple.Text == "")//Caso nao contenha texto, nao deixaria seguir com orcamento
            {
                MessageBox.Show("Insira o modelo do aparelho!");
                return;
            }
            //Cocatenando os valores gerados pela ação click
            orc_prev_apple += b4;
            //Mostrando o valor dessa cocatenação
            textbox_out_apple.Text = "R$" + Convert.ToString(orc_prev_apple);
            //Quando selecionado o servico, puxara uma interface com mais informacoes sobre o servico
            botao4 tela = new botao4();
            tela.ShowDialog();
        }

        private void bot5_apple_Click(object sender, EventArgs e)
        {
            if (textbox1_orc_apple.Text == "")//Caso nao contenha texto, nao deixaria seguir com orcamento
            {
                MessageBox.Show("Insira o modelo do aparelho!");
                return;
            }
            //Cocatenando os valores gerados pela ação click
            orc_prev_apple += b5;
            //Mostrando o valor dessa cocatenação
            textbox_out_apple.Text = "R$" + Convert.ToString(orc_prev_apple);
            //Quando selecionado o servico, puxara uma interface com mais informacoes sobre o servico
            botao5 tela = new botao5();
            tela.ShowDialog();
        }

        

        private void bot6_apple_Click(object sender, EventArgs e)
        {
            if (textbox1_orc_apple.Text == "")//Caso nao contenha texto, nao deixaria seguir com orcamento
            {
                MessageBox.Show("Insira o modelo do aparelho!");
                return;
            }
            //Cocatenando os valores gerados pela ação click
            orc_prev_apple += b6;
            //Mostrando o valor dessa cocatenação
            textbox_out_apple.Text = "R$" + Convert.ToString(orc_prev_apple);
            //Quando selecionado o servico, puxara uma interface com mais informacoes sobre o servico
            botao6 tela = new botao6();
            tela.ShowDialog();
        }

        private void bot7_apple_Click(object sender, EventArgs e)
        {
            if (textbox1_orc_apple.Text == "")//Caso nao contenha texto, nao deixaria seguir com orcamento
            {
                MessageBox.Show("Insira o modelo do aparelho!");
                return;
            }
            //Cocatenando os valores gerados pela ação click
            orc_prev_apple += b7;
            //Mostrando o valor dessa cocatenação
            textbox_out_apple.Text = "R$" + Convert.ToString(orc_prev_apple);
            //Quando selecionado o servico, puxara uma interface com mais informacoes sobre o servico
            botao7 tela = new botao7();
            tela.ShowDialog();
        }

        private void bot8_apple_Click(object sender, EventArgs e)
        {
            if (textbox1_orc_apple.Text == "")//Caso nao contenha texto, nao deixaria seguir com orcamento
            {
                MessageBox.Show("Insira o modelo do aparelho!");
                return;
            }
            //Cocatenando os valores gerados pela ação click
            orc_prev_apple += b8;
            //Mostrando o valor dessa cocatenação
            textbox_out_apple.Text = "R$" + Convert.ToString(orc_prev_apple);
            //Quando selecionado o servico, puxara uma interface com mais informacoes sobre o servico
            botao8 tela = new botao8();
            tela.ShowDialog();
        }

        private void bot_cancel_apple_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bot_clean_apple_Click(object sender, EventArgs e)
        {
            //Limpando/zerando valores da cocatenação
            textbox_out_apple.Clear();
            Close();
        }

        private void bot_concluir_apple_Click(object sender, EventArgs e)
        {
            txt_apple = textbox1_orc_apple.Text; //passando a o texto para string

            mm.mod_apple = txt_apple; //passando a string para string do menu manutencao

            mm.objeto_orc_apple = orc_prev_apple;
            Close();
        }
    }
}
