using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;//Biblioteca para criar arquivo .txt
//Projeto Integrativo 2 semestre Fatec
//Gabriel Goncalves da Silva(desenvolvedor)
//Lucas Murilo de Lazari
//Wesley Isney de Jesus Reis
namespace PI_final_1
{
    public partial class Menu_principal : Form
    {
        public int orc_samsung, orc_morotola, orc_apple, orc_pc, orc_total;
        public string text_mod_samsung, text_mod_motorola, text_mod_apple;
        StreamWriter nota_samsung, nota_motorola, nota_apple;
        
        public Menu_principal()
        {
            InitializeComponent();

            //Mostrar valor total das somas dos orcamentos
            textbox_orc_total_men_principal.Text = "R$" + Convert.ToString(orc_total);
            
        }

        private void Menu_principal_Load(object sender, EventArgs e)
        {
            

        }

        private void bot_detalhes_Click(object sender, EventArgs e)
        {
            //Orientando as variaveis para interface detalhes

            Detalhes tela = new Detalhes(orc_samsung, orc_morotola, orc_apple, orc_pc, orc_total);
            tela.ShowDialog();
        }

        private void bot_imprimir_Click(object sender, EventArgs e)
        {                                                    //Geracao de arquivo .txt pra marca samsung
            string caminho_samsung = "C:\\c# prog\\PI_2sem_f\\PI_final_1\\PI_final_1\\nota_samsung.txt";
            //local a ser criado o arquivo .txt
            nota_samsung = File.CreateText(caminho_samsung);

            nota_samsung.WriteLine("Aparelho Samsung");
            nota_samsung.WriteLine();
            nota_samsung.WriteLine();
            nota_samsung.WriteLine("Modelo: " + text_mod_samsung);
            nota_samsung.WriteLine();
            nota_samsung.WriteLine("Preco: " + "R$" + orc_samsung);
            nota_samsung.WriteLine();
            nota_samsung.WriteLine("Tempo Estimado: 5 Dias");
            nota_samsung.WriteLine();
            nota_samsung.Close();

                                      //local a ser criado o arquivo .txt
            string caminho_motorola = "C:\\c# prog\\PI_2sem_f\\PI_final_1\\PI_final_1\\nota_motorola.txt";
            //Geracao de arquivo .txt pra marca motorola
            nota_motorola = File.CreateText(caminho_motorola);

            nota_motorola.WriteLine("Aparelho Motorola");
            nota_motorola.WriteLine();
            nota_motorola.WriteLine();
            nota_motorola.WriteLine("Modelo :" + text_mod_motorola);
            nota_motorola.WriteLine();
            nota_motorola.WriteLine("Preco: " + "R$" + orc_morotola);
            nota_motorola.WriteLine();
            nota_motorola.WriteLine("Tempo Estimado: 5 dias");
            nota_motorola.WriteLine();
            nota_motorola.Close();

            //Geracao de arquivo .txt pra marca Apple
            string caminho_apple = "C:\\c# prog\\PI_2sem_f\\PI_final_1\\PI_final_1\\nota_apple.txt";
                                    //local a ser criado arquivo .txt
            nota_apple = File.CreateText(caminho_apple);

            nota_apple.WriteLine("Aparelho Apple");
            nota_apple.WriteLine();
            nota_apple.WriteLine();
            nota_apple.WriteLine("Modelo :" + text_mod_apple);
            nota_apple.WriteLine();
            nota_apple.WriteLine("Preco: " + "R$" + orc_apple);
            nota_apple.WriteLine();
            nota_apple.WriteLine("Tempo Estimado: 7 Dias");
            nota_apple.WriteLine();
            nota_apple.Close();

        }

        private void Text_man_principal_Click(object sender, EventArgs e)
        {

        }

        private void bot_Orcamento_Click(object sender, EventArgs e)
        {  //botao gera a acao de abrir a interface Menu de manutencao
            Menu_manutencao tela = new Menu_manutencao(this);
            tela.ShowDialog();
        }

        private void bot_servico_Click(object sender, EventArgs e)
        {
           
        }

        private void Menu_principal_VisibleChanged(object sender, EventArgs e)
        {
            

        }
    }
}
