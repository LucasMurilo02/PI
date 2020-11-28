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
    public partial class orc_samsung : Form
    {
        
        marca_celular_tablets m_m;
        int orc_prev_samsung;
        public orc_samsung(marca_celular_tablets menu_marcas)
        {
            
            InitializeComponent();
            m_m = menu_marcas;
            

        }

        private void bot_op1_samsung_Click(object sender, EventArgs e)
        {
            if(textbox_mod_samsung.Text == "")
            {
                MessageBox.Show("Insira o modelo do aparelho!");
                return;
            }
            textBox_orc_samsung.Text = Convert.ToString(orc_prev_samsung);
            
        }

        private void bot_op2_samsung_Click(object sender, EventArgs e)
        {
            if (textbox_mod_samsung.Text == "")
            {
                MessageBox.Show("Insira o modelo do aparelho!");
                return;
                
            }
            orc_prev_samsung += 60 ;
            textBox_orc_samsung.Text = Convert.ToString(orc_prev_samsung);
        }

        private void bot_op3_samsung_Click(object sender, EventArgs e)
        {
            if (textbox_mod_samsung.Text == "")
            {
                MessageBox.Show("Insira o modelo do aparelho!");
                
                return;
                
            }
            orc_prev_samsung += 40;
            textBox_orc_samsung.Text = Convert.ToString(orc_prev_samsung);
        }

        private void bot_op4_samsung_Click(object sender, EventArgs e)
        {
            if (textbox_mod_samsung.Text == "")
            {
                MessageBox.Show("Insira o modelo do aparelho!");
                return;
            }
            orc_prev_samsung += 60;
            textBox_orc_samsung.Text = Convert.ToString(orc_prev_samsung);
        }

        private void bot_op5_samsung_Click(object sender, EventArgs e)
        {
            if (textbox_mod_samsung.Text == "")
            {
                MessageBox.Show("Insira o modelo do aparelho!");
                return;
            }
            orc_prev_samsung += 50;
            textBox_orc_samsung.Text = Convert.ToString(orc_prev_samsung);
        }

        private void bot_op6_samsung_Click(object sender, EventArgs e)
        {
            if (textbox_mod_samsung.Text == "")
            {
                MessageBox.Show("Insira o modelo do aparelho!");
                return;
            }
            orc_prev_samsung += 100;
            textBox_orc_samsung.Text = Convert.ToString(orc_prev_samsung);
        }

        private void bot_op7_samsung_Click(object sender, EventArgs e)
        {
            if (textbox_mod_samsung.Text == "")
            {
                MessageBox.Show("Insira o modelo do aparelho!");
                return;
            }
            orc_prev_samsung += 50;
            textBox_orc_samsung.Text = Convert.ToString(orc_prev_samsung);
        }

        private void bot_op8_samsung_Click(object sender, EventArgs e)
        {
            if (textbox_mod_samsung.Text == "")
            {
                MessageBox.Show("Insira o modelo do aparelho!");
                return;
            }
            orc_prev_samsung += 60;
            textBox_orc_samsung.Text = Convert.ToString(orc_prev_samsung);
        }
         
        private void orc_samsung_Load(object sender, EventArgs e)
        {

        }

        private void bot_limpar_orc_samsung_Click(object sender, EventArgs e)
        {
            orc_prev_samsung = 0;
            textBox_orc_samsung.Clear();

        }

        private void bot_concluir_samsung_Click(object sender, EventArgs e)
        {
            m_m.marc_men = orc_prev_samsung;
            
        }
    }
}
