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
    public partial class orcamento_pc_notebook : Form
    {
        int orc_pc_notebook = 0;
        Menu_manutencao Mm;
        
        public orcamento_pc_notebook(Menu_manutencao M_m)
        {
            InitializeComponent();
            Mm = M_m;
        }

        private void orcamento_pc_notebook_Load(object sender, EventArgs e)
        {

        }

        private void textbox_backup_orc_pc_TextChanged(object sender, EventArgs e)
        {

        }

        private void bot_formatacao_pc_Click(object sender, EventArgs e)
        {
            orc_pc_notebook += 100;
            textbox_orcprev_pc.Text = Convert.ToString(orc_pc_notebook);
        }

        private void bot_limpezapc_pc_Click(object sender, EventArgs e)
        {
            orc_pc_notebook += 50;
            textbox_orcprev_pc.Text = Convert.ToString(orc_pc_notebook);
        }

        private void bot_limpezanotebook_pc_Click(object sender, EventArgs e)
        {
            orc_pc_notebook += 100;
            textbox_orcprev_pc.Text = Convert.ToString(orc_pc_notebook);
        }

        private void bot_limpezacache_pc_Click(object sender, EventArgs e)
        {
            orc_pc_notebook += 50;
            textbox_orcprev_pc.Text = Convert.ToString(orc_pc_notebook);

        }

        private void bot_attdrivers_pc_Click(object sender, EventArgs e)
        {
            orc_pc_notebook += 50;
            textbox_orcprev_pc.Text = Convert.ToString(orc_pc_notebook);
        }

        private void bot_backup_pc_Click(object sender, EventArgs e)
        {
            if(textbox_backup_orc_pc.Text == "")
            {
                MessageBox.Show("Digite a quantidade de Gigabytes");
                return;
            }
            orc_pc_notebook += Convert.ToInt32(textbox_backup_orc_pc.Text) * 10;
            textbox_orcprev_pc.Text = Convert.ToString(orc_pc_notebook);
        }

        private void bot_limpar_orc_Click(object sender, EventArgs e)
        {
            textbox_backup_orc_pc.Clear();

            textbox_orcprev_pc.Clear();

            orc_pc_notebook = 0;
        }

        private void bot_concluir_orc_pc_Click(object sender, EventArgs e)
        {
            Mm.objeto_orc_pc = orc_pc_notebook;
            Close();
        }

        private void bot_cancelar_orc_pc_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
