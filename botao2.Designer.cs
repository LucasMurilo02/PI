namespace PI_final_1
{
    partial class botao2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.text1_bot2 = new System.Windows.Forms.Label();
            this.text2_bot2 = new System.Windows.Forms.Label();
            this.text3_bot2 = new System.Windows.Forms.Label();
            this.text4_bot2 = new System.Windows.Forms.Label();
            this.text5_bot2 = new System.Windows.Forms.Label();
            this.text6_bot2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // text1_bot2
            // 
            this.text1_bot2.AutoSize = true;
            this.text1_bot2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text1_bot2.Location = new System.Drawing.Point(38, 9);
            this.text1_bot2.Name = "text1_bot2";
            this.text1_bot2.Size = new System.Drawing.Size(210, 20);
            this.text1_bot2.TabIndex = 0;
            this.text1_bot2.Text = "Estimativas e Descrições";
            // 
            // text2_bot2
            // 
            this.text2_bot2.AutoSize = true;
            this.text2_bot2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text2_bot2.Location = new System.Drawing.Point(3, 41);
            this.text2_bot2.Name = "text2_bot2";
            this.text2_bot2.Size = new System.Drawing.Size(73, 16);
            this.text2_bot2.TabIndex = 1;
            this.text2_bot2.Text = "Descrição:";
            // 
            // text3_bot2
            // 
            this.text3_bot2.AutoSize = true;
            this.text3_bot2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text3_bot2.Location = new System.Drawing.Point(88, 41);
            this.text3_bot2.Name = "text3_bot2";
            this.text3_bot2.Size = new System.Drawing.Size(200, 45);
            this.text3_bot2.TabIndex = 2;
            this.text3_bot2.Text = "-Aparelho conectado ao carregador\r\ne nao carrega.\r\n-Sem sinal de carregamento.";
            // 
            // text4_bot2
            // 
            this.text4_bot2.AutoSize = true;
            this.text4_bot2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text4_bot2.Location = new System.Drawing.Point(3, 136);
            this.text4_bot2.Name = "text4_bot2";
            this.text4_bot2.Size = new System.Drawing.Size(130, 16);
            this.text4_bot2.TabIndex = 3;
            this.text4_bot2.Text = "Estimativa de preço:";
            // 
            // text5_bot2
            // 
            this.text5_bot2.AutoSize = true;
            this.text5_bot2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text5_bot2.Location = new System.Drawing.Point(148, 136);
            this.text5_bot2.Name = "text5_bot2";
            this.text5_bot2.Size = new System.Drawing.Size(140, 15);
            this.text5_bot2.TabIndex = 4;
            this.text5_bot2.Text = "De R$50,00 a R$150,00\r\n";
            // 
            // text6_bot2
            // 
            this.text6_bot2.AutoSize = true;
            this.text6_bot2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text6_bot2.Location = new System.Drawing.Point(3, 235);
            this.text6_bot2.Name = "text6_bot2";
            this.text6_bot2.Size = new System.Drawing.Size(139, 16);
            this.text6_bot2.TabIndex = 5;
            this.text6_bot2.Text = "Estimativa de Tempo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Caso: \r\n       -Conector de Carga - 1 Dia\r\n       -Bateria                    - 3" +
    " Dias\r\n";
            // 
            // botao2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(304, 365);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text6_bot2);
            this.Controls.Add(this.text5_bot2);
            this.Controls.Add(this.text4_bot2);
            this.Controls.Add(this.text3_bot2);
            this.Controls.Add(this.text2_bot2);
            this.Controls.Add(this.text1_bot2);
            this.Name = "botao2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label text1_bot2;
        private System.Windows.Forms.Label text2_bot2;
        private System.Windows.Forms.Label text3_bot2;
        private System.Windows.Forms.Label text4_bot2;
        private System.Windows.Forms.Label text5_bot2;
        private System.Windows.Forms.Label text6_bot2;
        private System.Windows.Forms.Label label1;
    }
}