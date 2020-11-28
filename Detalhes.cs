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
    
    public partial class Detalhes : Form
    {
        public Detalhes(int Samsung, int motorola, int apple, int pc, int total)
        {
            
            InitializeComponent();
            
            txtbox_samsung.Text = "R$" + Convert.ToString(Samsung);
            txt_motorola.Text = "R$" + Convert.ToString(motorola);
            txt_apple.Text = "R$" + Convert.ToString(apple);
            txt_pc.Text = "R$" + Convert.ToString(pc);
            txt_total.Text = "R$" + Convert.ToString(total);

        }

        private void bot_voltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
