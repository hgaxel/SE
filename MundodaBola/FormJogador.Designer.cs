namespace MundodaBola
{
    partial class FormJogador
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
            this.btnConsulta = new System.Windows.Forms.Button();
            this.listJogador = new System.Windows.Forms.ListBox();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.cbOpcoes = new System.Windows.Forms.ComboBox();
            this.lbJogador = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(201, 228);
            this.btnConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(163, 68);
            this.btnConsulta.TabIndex = 0;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // listaPeliculas
            // 
            this.listJogador.FormattingEnabled = true;
            this.listJogador.ItemHeight = 16;
            this.listJogador.Location = new System.Drawing.Point(29, 87);
            this.listJogador.Margin = new System.Windows.Forms.Padding(4);
            this.listJogador.Name = "listaPeliculas";
            this.listJogador.Size = new System.Drawing.Size(333, 132);
            this.listJogador.TabIndex = 1;
            // 
            // btnLimpa
            // 
            this.btnLimpa.Location = new System.Drawing.Point(29, 228);
            this.btnLimpa.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(164, 68);
            this.btnLimpa.TabIndex = 2;
            this.btnLimpa.Text = "Limpar";
            this.btnLimpa.UseVisualStyleBackColor = true;
            this.btnLimpa.Click += new System.EventHandler(this.btnLimpa_Click);
            // 
            // cbOpcoes
            // 
            this.cbOpcoes.FormattingEnabled = true;
            this.cbOpcoes.Items.AddRange(new object[] {
            "Atacante Brasileiro",
            "Meia Brasileiro",
            "Atacante Europeu",
            "Zagueiro Brasileiro",
            "Prueba"});
            this.cbOpcoes.Location = new System.Drawing.Point(372, 228);
            this.cbOpcoes.Margin = new System.Windows.Forms.Padding(4);
            this.cbOpcoes.Name = "cbOpcoes";
            this.cbOpcoes.Size = new System.Drawing.Size(160, 24);
            this.cbOpcoes.TabIndex = 3;
            this.cbOpcoes.SelectedIndexChanged += new System.EventHandler(this.cbOpcoes_SelectedIndexChanged);
            // 
            // lbJogador
            // 
            this.lbJogador.AutoSize = true;
            this.lbJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJogador.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbJogador.Location = new System.Drawing.Point(135, 30);
            this.lbJogador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbJogador.Name = "lbJogador";
            this.lbJogador.Size = new System.Drawing.Size(245, 29);
            this.lbJogador.TabIndex = 4;
            this.lbJogador.Text = "Lista de Jogadores";
            // 
            // FormJogador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 332);
            this.Controls.Add(this.lbJogador);
            this.Controls.Add(this.cbOpcoes);
            this.Controls.Add(this.btnLimpa);
            this.Controls.Add(this.listJogador);
            this.Controls.Add(this.btnConsulta);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormJogador";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormJogador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.ListBox listJogador;
        private System.Windows.Forms.Button btnLimpa;
        private System.Windows.Forms.ComboBox cbOpcoes;
        private System.Windows.Forms.Label lbJogador;
    }
}

