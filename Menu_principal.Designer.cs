namespace PI_final_1
{
    partial class Menu_principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Text_man_principal = new System.Windows.Forms.Label();
            this.bot_Orcamento = new System.Windows.Forms.Button();
            this.text1_men_principal = new System.Windows.Forms.Label();
            this.textbox_orc_total_men_principal = new System.Windows.Forms.TextBox();
            this.txt_vt_mp = new System.Windows.Forms.Label();
            this.bot_detalhes = new System.Windows.Forms.Button();
            this.bot_imprimir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Text_man_principal
            // 
            this.Text_man_principal.AutoSize = true;
            this.Text_man_principal.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_man_principal.Location = new System.Drawing.Point(259, 9);
            this.Text_man_principal.Name = "Text_man_principal";
            this.Text_man_principal.Size = new System.Drawing.Size(257, 42);
            this.Text_man_principal.TabIndex = 0;
            this.Text_man_principal.Text = "Bem Vindo(a)";
            this.Text_man_principal.Click += new System.EventHandler(this.Text_man_principal_Click);
            // 
            // bot_Orcamento
            // 
            this.bot_Orcamento.BackColor = System.Drawing.Color.AliceBlue;
            this.bot_Orcamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot_Orcamento.Location = new System.Drawing.Point(12, 122);
            this.bot_Orcamento.Name = "bot_Orcamento";
            this.bot_Orcamento.Size = new System.Drawing.Size(294, 62);
            this.bot_Orcamento.TabIndex = 1;
            this.bot_Orcamento.Text = "Estimar Orçamento";
            this.bot_Orcamento.UseVisualStyleBackColor = false;
            this.bot_Orcamento.Click += new System.EventHandler(this.bot_Orcamento_Click);
            // 
            // text1_men_principal
            // 
            this.text1_men_principal.AutoSize = true;
            this.text1_men_principal.Font = new System.Drawing.Font("Sitka Heading", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text1_men_principal.Location = new System.Drawing.Point(3, 320);
            this.text1_men_principal.Name = "text1_men_principal";
            this.text1_men_principal.Size = new System.Drawing.Size(158, 50);
            this.text1_men_principal.TabIndex = 3;
            this.text1_men_principal.Text = "Minerva ";
            // 
            // textbox_orc_total_men_principal
            // 
            this.textbox_orc_total_men_principal.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_orc_total_men_principal.Location = new System.Drawing.Point(569, 141);
            this.textbox_orc_total_men_principal.Name = "textbox_orc_total_men_principal";
            this.textbox_orc_total_men_principal.Size = new System.Drawing.Size(221, 49);
            this.textbox_orc_total_men_principal.TabIndex = 4;
            // 
            // txt_vt_mp
            // 
            this.txt_vt_mp.AutoSize = true;
            this.txt_vt_mp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_vt_mp.Location = new System.Drawing.Point(410, 153);
            this.txt_vt_mp.Name = "txt_vt_mp";
            this.txt_vt_mp.Size = new System.Drawing.Size(153, 31);
            this.txt_vt_mp.TabIndex = 5;
            this.txt_vt_mp.Text = "Valor Total:";
            // 
            // bot_detalhes
            // 
            this.bot_detalhes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot_detalhes.Location = new System.Drawing.Point(569, 197);
            this.bot_detalhes.Name = "bot_detalhes";
            this.bot_detalhes.Size = new System.Drawing.Size(221, 23);
            this.bot_detalhes.TabIndex = 6;
            this.bot_detalhes.Text = "Detalhes do valor";
            this.bot_detalhes.UseVisualStyleBackColor = true;
            this.bot_detalhes.Click += new System.EventHandler(this.bot_detalhes_Click);
            // 
            // bot_imprimir
            // 
            this.bot_imprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot_imprimir.Location = new System.Drawing.Point(569, 227);
            this.bot_imprimir.Name = "bot_imprimir";
            this.bot_imprimir.Size = new System.Drawing.Size(221, 26);
            this.bot_imprimir.TabIndex = 7;
            this.bot_imprimir.Text = "Imprimir";
            this.bot_imprimir.UseVisualStyleBackColor = true;
            this.bot_imprimir.Click += new System.EventHandler(this.bot_imprimir_Click);
            // 
            // Menu_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(802, 437);
            this.Controls.Add(this.bot_imprimir);
            this.Controls.Add(this.bot_detalhes);
            this.Controls.Add(this.txt_vt_mp);
            this.Controls.Add(this.textbox_orc_total_men_principal);
            this.Controls.Add(this.text1_men_principal);
            this.Controls.Add(this.bot_Orcamento);
            this.Controls.Add(this.Text_man_principal);
            this.Name = "Menu_principal";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.Menu_principal_Load);
            this.VisibleChanged += new System.EventHandler(this.Menu_principal_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Text_man_principal;
        private System.Windows.Forms.Button bot_Orcamento;
        private System.Windows.Forms.Label text1_men_principal;
        public System.Windows.Forms.TextBox textbox_orc_total_men_principal;
        private System.Windows.Forms.Label txt_vt_mp;
        private System.Windows.Forms.Button bot_detalhes;
        private System.Windows.Forms.Button bot_imprimir;
    }
}

