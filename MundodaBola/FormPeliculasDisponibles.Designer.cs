namespace MundodaBola
{
    partial class FormPeliculasDisponibles
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConsulta = new System.Windows.Forms.Button();
            this.cbOpcoes = new System.Windows.Forms.ComboBox();
            this.listJogador = new System.Windows.Forms.ListBox();
            this.pregunta = new System.Windows.Forms.Label();
            this.opcion4 = new System.Windows.Forms.RadioButton();
            this.opcion3 = new System.Windows.Forms.RadioButton();
            this.opcion2 = new System.Windows.Forms.RadioButton();
            this.opcion1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.datavg = new System.Windows.Forms.DataGridView();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datavg)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(77, 232);
            this.btnConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(163, 68);
            this.btnConsulta.TabIndex = 9;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
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
            this.cbOpcoes.Location = new System.Drawing.Point(335, 46);
            this.cbOpcoes.Margin = new System.Windows.Forms.Padding(4);
            this.cbOpcoes.Name = "cbOpcoes";
            this.cbOpcoes.Size = new System.Drawing.Size(160, 24);
            this.cbOpcoes.TabIndex = 8;
            // 
            // listJogador
            // 
            this.listJogador.FormattingEnabled = true;
            this.listJogador.ItemHeight = 16;
            this.listJogador.Location = new System.Drawing.Point(13, 37);
            this.listJogador.Margin = new System.Windows.Forms.Padding(4);
            this.listJogador.Name = "listJogador";
            this.listJogador.Size = new System.Drawing.Size(282, 100);
            this.listJogador.TabIndex = 7;
            // 
            // pregunta
            // 
            this.pregunta.AutoSize = true;
            this.pregunta.Location = new System.Drawing.Point(620, 53);
            this.pregunta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pregunta.Name = "pregunta";
            this.pregunta.Size = new System.Drawing.Size(0, 17);
            this.pregunta.TabIndex = 10;
            // 
            // opcion4
            // 
            this.opcion4.AutoSize = true;
            this.opcion4.Location = new System.Drawing.Point(635, 284);
            this.opcion4.Margin = new System.Windows.Forms.Padding(4);
            this.opcion4.Name = "opcion4";
            this.opcion4.Size = new System.Drawing.Size(17, 16);
            this.opcion4.TabIndex = 14;
            this.opcion4.TabStop = true;
            this.opcion4.UseVisualStyleBackColor = true;
            // 
            // opcion3
            // 
            this.opcion3.AutoSize = true;
            this.opcion3.Location = new System.Drawing.Point(635, 229);
            this.opcion3.Margin = new System.Windows.Forms.Padding(4);
            this.opcion3.Name = "opcion3";
            this.opcion3.Size = new System.Drawing.Size(17, 16);
            this.opcion3.TabIndex = 13;
            this.opcion3.TabStop = true;
            this.opcion3.UseVisualStyleBackColor = true;
            // 
            // opcion2
            // 
            this.opcion2.AutoSize = true;
            this.opcion2.Location = new System.Drawing.Point(635, 177);
            this.opcion2.Margin = new System.Windows.Forms.Padding(4);
            this.opcion2.Name = "opcion2";
            this.opcion2.Size = new System.Drawing.Size(17, 16);
            this.opcion2.TabIndex = 12;
            this.opcion2.TabStop = true;
            this.opcion2.UseVisualStyleBackColor = true;
            // 
            // opcion1
            // 
            this.opcion1.AutoSize = true;
            this.opcion1.Location = new System.Drawing.Point(635, 121);
            this.opcion1.Margin = new System.Windows.Forms.Padding(4);
            this.opcion1.Name = "opcion1";
            this.opcion1.Size = new System.Drawing.Size(17, 16);
            this.opcion1.TabIndex = 11;
            this.opcion1.TabStop = true;
            this.opcion1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(738, 328);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 40);
            this.button1.TabIndex = 15;
            this.button1.Text = "Siguiente";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // datavg
            // 
            this.datavg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datavg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NOMBRE,
            this.nombre2,
            this.Column1});
            this.datavg.Location = new System.Drawing.Point(13, 382);
            this.datavg.Name = "datavg";
            this.datavg.RowHeadersWidth = 51;
            this.datavg.RowTemplate.Height = 24;
            this.datavg.Size = new System.Drawing.Size(547, 148);
            this.datavg.TabIndex = 16;
            // 
            // NOMBRE
            // 
            this.NOMBRE.HeaderText = "nombre";
            this.NOMBRE.MinimumWidth = 6;
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.Width = 125;
            // 
            // nombre2
            // 
            this.nombre2.HeaderText = "nombre2";
            this.nombre2.MinimumWidth = 6;
            this.nombre2.Name = "nombre2";
            this.nombre2.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // FormPeliculasDisponibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 637);
            this.Controls.Add(this.datavg);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.opcion4);
            this.Controls.Add(this.opcion3);
            this.Controls.Add(this.opcion2);
            this.Controls.Add(this.opcion1);
            this.Controls.Add(this.pregunta);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.cbOpcoes);
            this.Controls.Add(this.listJogador);
            this.Name = "FormPeliculasDisponibles";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datavg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.ComboBox cbOpcoes;
        private System.Windows.Forms.ListBox listJogador;
        private System.Windows.Forms.Label pregunta;
        private System.Windows.Forms.RadioButton opcion4;
        private System.Windows.Forms.RadioButton opcion3;
        private System.Windows.Forms.RadioButton opcion2;
        private System.Windows.Forms.RadioButton opcion1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView datavg;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}

