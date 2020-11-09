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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxDatos = new System.Windows.Forms.GroupBox();
            this.listBoxDescripcion = new System.Windows.Forms.ListBox();
            this.textValoracion = new System.Windows.Forms.TextBox();
            this.textEdad = new System.Windows.Forms.TextBox();
            this.textDuracion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textProcedencia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textGenero = new System.Windows.Forms.TextBox();
            this.textAño = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBoxPeliculas = new System.Windows.Forms.GroupBox();
            this.groupFiltrado = new System.Windows.Forms.GroupBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.checkEdad = new System.Windows.Forms.CheckBox();
            this.comboAño = new System.Windows.Forms.ComboBox();
            this.comboEdad = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.checkGenero = new System.Windows.Forms.CheckBox();
            this.checkAño = new System.Windows.Forms.CheckBox();
            this.comboGenero = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBoxDatos.SuspendLayout();
            this.groupBoxPeliculas.SuspendLayout();
            this.groupFiltrado.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(1210, 381);
            this.btnConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(143, 51);
            this.btnConsulta.TabIndex = 9;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Visible = false;
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
            this.cbOpcoes.Location = new System.Drawing.Point(757, 326);
            this.cbOpcoes.Margin = new System.Windows.Forms.Padding(4);
            this.cbOpcoes.Name = "cbOpcoes";
            this.cbOpcoes.Size = new System.Drawing.Size(133, 24);
            this.cbOpcoes.TabIndex = 8;
            this.cbOpcoes.Visible = false;
            // 
            // listJogador
            // 
            this.listJogador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listJogador.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.listJogador.FormattingEnabled = true;
            this.listJogador.ItemHeight = 22;
            this.listJogador.Location = new System.Drawing.Point(26, 37);
            this.listJogador.Margin = new System.Windows.Forms.Padding(4);
            this.listJogador.Name = "listJogador";
            this.listJogador.Size = new System.Drawing.Size(672, 158);
            this.listJogador.TabIndex = 7;
            // 
            // pregunta
            // 
            this.pregunta.AutoSize = true;
            this.pregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pregunta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pregunta.Location = new System.Drawing.Point(792, 33);
            this.pregunta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pregunta.Name = "pregunta";
            this.pregunta.Size = new System.Drawing.Size(0, 18);
            this.pregunta.TabIndex = 10;
            // 
            // opcion4
            // 
            this.opcion4.AutoSize = true;
            this.opcion4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.opcion4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.opcion4.Location = new System.Drawing.Point(810, 243);
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
            this.opcion3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.opcion3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.opcion3.Location = new System.Drawing.Point(810, 188);
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
            this.opcion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.opcion2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.opcion2.Location = new System.Drawing.Point(810, 136);
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
            this.opcion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.opcion1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.opcion1.Location = new System.Drawing.Point(810, 80);
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
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(1008, 287);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 40);
            this.button1.TabIndex = 15;
            this.button1.Text = "Siguiente";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(17, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "NOMBE:";
            // 
            // groupBoxDatos
            // 
            this.groupBoxDatos.Controls.Add(this.listBoxDescripcion);
            this.groupBoxDatos.Controls.Add(this.textValoracion);
            this.groupBoxDatos.Controls.Add(this.textEdad);
            this.groupBoxDatos.Controls.Add(this.textDuracion);
            this.groupBoxDatos.Controls.Add(this.label8);
            this.groupBoxDatos.Controls.Add(this.textProcedencia);
            this.groupBoxDatos.Controls.Add(this.label7);
            this.groupBoxDatos.Controls.Add(this.label6);
            this.groupBoxDatos.Controls.Add(this.label5);
            this.groupBoxDatos.Controls.Add(this.textGenero);
            this.groupBoxDatos.Controls.Add(this.textAño);
            this.groupBoxDatos.Controls.Add(this.txtNombre);
            this.groupBoxDatos.Controls.Add(this.label4);
            this.groupBoxDatos.Controls.Add(this.label3);
            this.groupBoxDatos.Controls.Add(this.label2);
            this.groupBoxDatos.Controls.Add(this.label1);
            this.groupBoxDatos.Enabled = false;
            this.groupBoxDatos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxDatos.Location = new System.Drawing.Point(15, 349);
            this.groupBoxDatos.Name = "groupBoxDatos";
            this.groupBoxDatos.Size = new System.Drawing.Size(713, 400);
            this.groupBoxDatos.TabIndex = 18;
            this.groupBoxDatos.TabStop = false;
            this.groupBoxDatos.Text = "DATOS PELICULA";
            // 
            // listBoxDescripcion
            // 
            this.listBoxDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listBoxDescripcion.Enabled = false;
            this.listBoxDescripcion.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.listBoxDescripcion.FormattingEnabled = true;
            this.listBoxDescripcion.ItemHeight = 16;
            this.listBoxDescripcion.Location = new System.Drawing.Point(20, 237);
            this.listBoxDescripcion.Name = "listBoxDescripcion";
            this.listBoxDescripcion.Size = new System.Drawing.Size(678, 84);
            this.listBoxDescripcion.TabIndex = 32;
            // 
            // textValoracion
            // 
            this.textValoracion.Enabled = false;
            this.textValoracion.Location = new System.Drawing.Point(611, 112);
            this.textValoracion.Name = "textValoracion";
            this.textValoracion.Size = new System.Drawing.Size(87, 22);
            this.textValoracion.TabIndex = 31;
            // 
            // textEdad
            // 
            this.textEdad.Enabled = false;
            this.textEdad.Location = new System.Drawing.Point(611, 81);
            this.textEdad.Name = "textEdad";
            this.textEdad.Size = new System.Drawing.Size(87, 22);
            this.textEdad.TabIndex = 30;
            // 
            // textDuracion
            // 
            this.textDuracion.Enabled = false;
            this.textDuracion.Location = new System.Drawing.Point(611, 52);
            this.textDuracion.Name = "textDuracion";
            this.textDuracion.Size = new System.Drawing.Size(87, 22);
            this.textDuracion.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(17, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 17);
            this.label8.TabIndex = 28;
            this.label8.Text = "DESCRIPCION:";
            // 
            // textProcedencia
            // 
            this.textProcedencia.Enabled = false;
            this.textProcedencia.Location = new System.Drawing.Point(135, 121);
            this.textProcedencia.Name = "textProcedencia";
            this.textProcedencia.Size = new System.Drawing.Size(282, 22);
            this.textProcedencia.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(441, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "CLASIF. POR EDAD:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(441, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "DURACION(MIN):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(17, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "PROCEDEN:";
            // 
            // textGenero
            // 
            this.textGenero.Enabled = false;
            this.textGenero.Location = new System.Drawing.Point(135, 81);
            this.textGenero.Name = "textGenero";
            this.textGenero.Size = new System.Drawing.Size(282, 22);
            this.textGenero.TabIndex = 23;
            // 
            // textAño
            // 
            this.textAño.Enabled = false;
            this.textAño.Location = new System.Drawing.Point(135, 163);
            this.textAño.Name = "textAño";
            this.textAño.Size = new System.Drawing.Size(87, 22);
            this.textAño.TabIndex = 22;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(93, 49);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(324, 22);
            this.txtNombre.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(441, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "VALORACION:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(17, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "GENERO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(17, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "AÑO:";
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(213, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(282, 52);
            this.button2.TabIndex = 19;
            this.button2.Text = "CONSULTAR DATOS PELICULA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBoxPeliculas
            // 
            this.groupBoxPeliculas.Controls.Add(this.button2);
            this.groupBoxPeliculas.Controls.Add(this.listJogador);
            this.groupBoxPeliculas.Enabled = false;
            this.groupBoxPeliculas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxPeliculas.Location = new System.Drawing.Point(15, 18);
            this.groupBoxPeliculas.Name = "groupBoxPeliculas";
            this.groupBoxPeliculas.Size = new System.Drawing.Size(728, 293);
            this.groupBoxPeliculas.TabIndex = 20;
            this.groupBoxPeliculas.TabStop = false;
            this.groupBoxPeliculas.Text = "PELICULAS ENCONTRADAS";
            // 
            // groupFiltrado
            // 
            this.groupFiltrado.Controls.Add(this.btnFiltrar);
            this.groupFiltrado.Controls.Add(this.checkEdad);
            this.groupFiltrado.Controls.Add(this.comboAño);
            this.groupFiltrado.Controls.Add(this.comboEdad);
            this.groupFiltrado.Controls.Add(this.label10);
            this.groupFiltrado.Controls.Add(this.checkGenero);
            this.groupFiltrado.Controls.Add(this.checkAño);
            this.groupFiltrado.Controls.Add(this.comboGenero);
            this.groupFiltrado.Controls.Add(this.label9);
            this.groupFiltrado.Controls.Add(this.label12);
            this.groupFiltrado.Enabled = false;
            this.groupFiltrado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupFiltrado.Location = new System.Drawing.Point(757, 456);
            this.groupFiltrado.Name = "groupFiltrado";
            this.groupFiltrado.Size = new System.Drawing.Size(573, 293);
            this.groupFiltrado.TabIndex = 21;
            this.groupFiltrado.TabStop = false;
            this.groupFiltrado.Text = "FILTRADO ";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFiltrar.Location = new System.Drawing.Point(198, 209);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(248, 52);
            this.btnFiltrar.TabIndex = 24;
            this.btnFiltrar.Text = "FILTRAR";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // checkEdad
            // 
            this.checkEdad.AutoSize = true;
            this.checkEdad.Location = new System.Drawing.Point(137, 152);
            this.checkEdad.Name = "checkEdad";
            this.checkEdad.Size = new System.Drawing.Size(18, 17);
            this.checkEdad.TabIndex = 41;
            this.checkEdad.UseVisualStyleBackColor = true;
            this.checkEdad.CheckedChanged += new System.EventHandler(this.checkEdad_CheckedChanged);
            // 
            // comboAño
            // 
            this.comboAño.Enabled = false;
            this.comboAño.FormattingEnabled = true;
            this.comboAño.Items.AddRange(new object[] {
            "2015",
            "2016",
            "2017",
            "2018",
            "2019"});
            this.comboAño.Location = new System.Drawing.Point(309, 59);
            this.comboAño.Name = "comboAño";
            this.comboAño.Size = new System.Drawing.Size(141, 24);
            this.comboAño.TabIndex = 40;
            // 
            // comboEdad
            // 
            this.comboEdad.Enabled = false;
            this.comboEdad.FormattingEnabled = true;
            this.comboEdad.Items.AddRange(new object[] {
            "7",
            "13",
            "16",
            "18"});
            this.comboEdad.Location = new System.Drawing.Point(309, 148);
            this.comboEdad.Name = "comboEdad";
            this.comboEdad.Size = new System.Drawing.Size(141, 24);
            this.comboEdad.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(179, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 17);
            this.label10.TabIndex = 38;
            this.label10.Text = "EDAD:";
            // 
            // checkGenero
            // 
            this.checkGenero.AutoSize = true;
            this.checkGenero.Location = new System.Drawing.Point(137, 105);
            this.checkGenero.Name = "checkGenero";
            this.checkGenero.Size = new System.Drawing.Size(18, 17);
            this.checkGenero.TabIndex = 37;
            this.checkGenero.UseVisualStyleBackColor = true;
            this.checkGenero.CheckedChanged += new System.EventHandler(this.checkGenero_CheckedChanged);
            // 
            // checkAño
            // 
            this.checkAño.AutoSize = true;
            this.checkAño.Location = new System.Drawing.Point(137, 63);
            this.checkAño.Name = "checkAño";
            this.checkAño.Size = new System.Drawing.Size(18, 17);
            this.checkAño.TabIndex = 35;
            this.checkAño.UseVisualStyleBackColor = true;
            this.checkAño.CheckedChanged += new System.EventHandler(this.checkAño_CheckedChanged);
            // 
            // comboGenero
            // 
            this.comboGenero.Enabled = false;
            this.comboGenero.FormattingEnabled = true;
            this.comboGenero.Items.AddRange(new object[] {
            "comedias",
            "premiadas",
            "thillers",
            "romaticas",
            "infantiles",
            "accion",
            "dramas",
            "anime",
            "aventuras",
            "internacionales",
            "extranjeras",
            "ciencia_ficcion",
            "fantasticas",
            "terror",
            "documentales"});
            this.comboGenero.Location = new System.Drawing.Point(309, 102);
            this.comboGenero.Name = "comboGenero";
            this.comboGenero.Size = new System.Drawing.Size(141, 24);
            this.comboGenero.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(179, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 17);
            this.label9.TabIndex = 33;
            this.label9.Text = "GENERO:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(179, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 17);
            this.label12.TabIndex = 33;
            this.label12.Text = "AÑO:";
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(917, 386);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(248, 52);
            this.button4.TabIndex = 23;
            this.button4.Text = "FILTRAR PELICULAS";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FormPeliculasDisponibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1382, 793);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupFiltrado);
            this.Controls.Add(this.groupBoxPeliculas);
            this.Controls.Add(this.groupBoxDatos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.opcion4);
            this.Controls.Add(this.opcion3);
            this.Controls.Add(this.opcion2);
            this.Controls.Add(this.opcion1);
            this.Controls.Add(this.pregunta);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.cbOpcoes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Name = "FormPeliculasDisponibles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PELICULAS DISPONIBLES";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxDatos.ResumeLayout(false);
            this.groupBoxDatos.PerformLayout();
            this.groupBoxPeliculas.ResumeLayout(false);
            this.groupFiltrado.ResumeLayout(false);
            this.groupFiltrado.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxDatos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textGenero;
        private System.Windows.Forms.TextBox textAño;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textProcedencia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBoxDescripcion;
        private System.Windows.Forms.TextBox textValoracion;
        private System.Windows.Forms.TextBox textEdad;
        private System.Windows.Forms.TextBox textDuracion;
        private System.Windows.Forms.GroupBox groupBoxPeliculas;
        private System.Windows.Forms.GroupBox groupFiltrado;
        private System.Windows.Forms.ComboBox comboGenero;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox checkAño;
        private System.Windows.Forms.CheckBox checkGenero;
        private System.Windows.Forms.CheckBox checkEdad;
        private System.Windows.Forms.ComboBox comboAño;
        private System.Windows.Forms.ComboBox comboEdad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnFiltrar;
    }
}

