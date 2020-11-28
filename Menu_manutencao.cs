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
    public partial class Menu_manutencao : Form
    {
        Menu_principal mp;
        public int objeto_orc_samsung, objeto_orc_pc, objeto_orc_motorola, objeto_orc_apple, objeto_total;
        public string mod_samsung, mod_motorola, mod_apple, mod_pc;
        public Menu_manutencao(Menu_principal Mp) //Puxando as variaveis do Menu_principal
        {
            InitializeComponent();
            mp = Mp;//designando mp para orientar os dados
            
        }

        private void bot_pc_notebook_Click(object sender, EventArgs e)
        {  //Abrir interface de orcamento de pc e notebook
            
            orcamento_pc_notebook tela = new orcamento_pc_notebook(this);
            tela.ShowDialog();

        }

        private void Menu_manutencao_Load(object sender, EventArgs e)
        {

        }

        private void bot_cel_tablet_Click(object sender, EventArgs e)
        {
            
            
        }

        private void bot_voltar_men_man_Click(object sender, EventArgs e)
        { //botao para fechar aba
            Close();
        }

        private void samsungToolStripMenuItem_Click(object sender, EventArgs e)
        { //abrindo interface correspondente ao item do scroll
            orc_samsung tela = new orc_samsung(this);
            tela.ShowDialog();
        }

        private void motorolaToolStripMenuItem_Click(object sender, EventArgs e)
        {//abrindo interface correspondente ao item do scroll
            orc_motorola tela = new orc_motorola(this);
            tela.ShowDialog();
        }

        private void appleToolStripMenuItem_Click(object sender, EventArgs e)
        {//abrindo interface correspondente ao item do scroll
            orc_apple tela = new orc_apple(this);
            tela.ShowDialog();
        }

        private void Menu_manutencao_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Puxando as Strings dos orcamentos para o menu principal

            mp.text_mod_apple = mod_apple;//orientando a string de modelo  para string em menu principal
            mp.text_mod_motorola = mod_motorola;
            mp.text_mod_samsung = mod_samsung;



            //Puxando os valores gerados para o menu principal
            objeto_total = objeto_orc_samsung + objeto_orc_motorola + objeto_orc_apple + objeto_orc_pc;
            mp.orc_apple = objeto_orc_apple;
            mp.orc_morotola = objeto_orc_motorola;
            mp.orc_samsung = objeto_orc_samsung;
            mp.orc_pc = objeto_orc_pc;
            //inserindo o valor total dos orcamentos para textbox do menu prinicpal
            mp.textbox_orc_total_men_principal.Text = "R$" + Convert.ToString(objeto_total);
           
            
        }
    }
}
