namespace MundodaBola
{
    partial class FormPeliculasEstreno
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnConsultarPeliculas = new System.Windows.Forms.Button();
            this.listaPeliculasEstreno = new System.Windows.Forms.ListBox();
            this.groupBoxDatosPelicula = new System.Windows.Forms.GroupBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEstreno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBoxDatosPelicula.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnConsultarPeliculas);
            this.groupBox2.Controls.Add(this.listaPeliculasEstreno);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(37, 30);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(661, 298);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PELICULAS ENCONTRADAS";
            // 
            // btnConsultarPeliculas
            // 
            this.btnConsultarPeliculas.BackColor = System.Drawing.Color.Black;
            this.btnConsultarPeliculas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarPeliculas.ForeColor = System.Drawing.Color.White;
            this.btnConsultarPeliculas.Location = new System.Drawing.Point(203, 214);
            this.btnConsultarPeliculas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConsultarPeliculas.Name = "btnConsultarPeliculas";
            this.btnConsultarPeliculas.Size = new System.Drawing.Size(247, 52);
            this.btnConsultarPeliculas.TabIndex = 19;
            this.btnConsultarPeliculas.Text = "CONSULTAR DATOS";
            this.btnConsultarPeliculas.UseVisualStyleBackColor = false;
            this.btnConsultarPeliculas.Click += new System.EventHandler(this.btnConsultarPeliculas_Click);
            // 
            // listaPeliculasEstreno
            // 
            this.listaPeliculasEstreno.BackColor = System.Drawing.Color.Red;
            this.listaPeliculasEstreno.Font = new System.Drawing.Font("Footlight MT Light", 14.25F);
            this.listaPeliculasEstreno.ForeColor = System.Drawing.Color.White;
            this.listaPeliculasEstreno.FormattingEnabled = true;
            this.listaPeliculasEstreno.ItemHeight = 25;
            this.listaPeliculasEstreno.Location = new System.Drawing.Point(35, 33);
            this.listaPeliculasEstreno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listaPeliculasEstreno.Name = "listaPeliculasEstreno";
            this.listaPeliculasEstreno.Size = new System.Drawing.Size(599, 154);
            this.listaPeliculasEstreno.TabIndex = 7;
            // 
            // groupBoxDatosPelicula
            // 
            this.groupBoxDatosPelicula.Controls.Add(this.txtDescripcion);
            this.groupBoxDatosPelicula.Controls.Add(this.label8);
            this.groupBoxDatosPelicula.Controls.Add(this.txtEstreno);
            this.groupBoxDatosPelicula.Controls.Add(this.label5);
            this.groupBoxDatosPelicula.Controls.Add(this.txtAño);
            this.groupBoxDatosPelicula.Controls.Add(this.txtNombre);
            this.groupBoxDatosPelicula.Controls.Add(this.label2);
            this.groupBoxDatosPelicula.Controls.Add(this.label1);
            this.groupBoxDatosPelicula.Enabled = false;
            this.groupBoxDatosPelicula.ForeColor = System.Drawing.Color.White;
            this.groupBoxDatosPelicula.Location = new System.Drawing.Point(37, 357);
            this.groupBoxDatosPelicula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxDatosPelicula.Name = "groupBoxDatosPelicula";
            this.groupBoxDatosPelicula.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxDatosPelicula.Size = new System.Drawing.Size(661, 304);
            this.groupBoxDatosPelicula.TabIndex = 23;
            this.groupBoxDatosPelicula.TabStop = false;
            this.groupBoxDatosPelicula.Text = "DATOS PELICULA";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.Red;
            this.txtDescripcion.Font = new System.Drawing.Font("Californian FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.White;
            this.txtDescripcion.Location = new System.Drawing.Point(19, 182);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(603, 81);
            this.txtDescripcion.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 17);
            this.label8.TabIndex = 28;
            this.label8.Text = "DESCRIPCION:";
            // 
            // txtEstreno
            // 
            this.txtEstreno.BackColor = System.Drawing.Color.Red;
            this.txtEstreno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstreno.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtEstreno.Location = new System.Drawing.Point(321, 92);
            this.txtEstreno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEstreno.Name = "txtEstreno";
            this.txtEstreno.ReadOnly = true;
            this.txtEstreno.Size = new System.Drawing.Size(79, 28);
            this.txtEstreno.TabIndex = 27;
            this.txtEstreno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "ESTRENO:";
            // 
            // txtAño
            // 
            this.txtAño.BackColor = System.Drawing.Color.Red;
            this.txtAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAño.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtAño.Location = new System.Drawing.Point(502, 43);
            this.txtAño.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAño.Name = "txtAño";
            this.txtAño.ReadOnly = true;
            this.txtAño.Size = new System.Drawing.Size(79, 28);
            this.txtAño.TabIndex = 22;
            this.txtAño.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.Red;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtNombre.Location = new System.Drawing.Point(85, 44);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(284, 28);
            this.txtNombre.TabIndex = 21;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(435, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "AÑO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "NOMBE:";
            // 
            // FormPeliculasEstreno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(740, 682);
            this.Controls.Add(this.groupBoxDatosPelicula);
            this.Controls.Add(this.groupBox2);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormPeliculasEstreno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PELICULAS A ESTRENAR";
            this.Load += new System.EventHandler(this.FormPeliculasEstreno_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBoxDatosPelicula.ResumeLayout(false);
            this.groupBoxDatosPelicula.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnConsultarPeliculas;
        private System.Windows.Forms.ListBox listaPeliculasEstreno;
        private System.Windows.Forms.GroupBox groupBoxDatosPelicula;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEstreno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescripcion;
    }
}