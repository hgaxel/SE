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
            this.label8 = new System.Windows.Forms.Label();
            this.txtEstreno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBoxDatosPelicula.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnConsultarPeliculas);
            this.groupBox2.Controls.Add(this.listaPeliculasEstreno);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(11, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(496, 242);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PELICULAS ENCONTRADAS";
            // 
            // btnConsultarPeliculas
            // 
            this.btnConsultarPeliculas.ForeColor = System.Drawing.Color.Black;
            this.btnConsultarPeliculas.Location = new System.Drawing.Point(152, 186);
            this.btnConsultarPeliculas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConsultarPeliculas.Name = "btnConsultarPeliculas";
            this.btnConsultarPeliculas.Size = new System.Drawing.Size(181, 30);
            this.btnConsultarPeliculas.TabIndex = 19;
            this.btnConsultarPeliculas.Text = "CONSULTAR DATOS PELICULA";
            this.btnConsultarPeliculas.UseVisualStyleBackColor = true;
            this.btnConsultarPeliculas.Click += new System.EventHandler(this.btnConsultarPeliculas_Click);
            // 
            // listaPeliculasEstreno
            // 
            this.listaPeliculasEstreno.BackColor = System.Drawing.Color.Red;
            this.listaPeliculasEstreno.Font = new System.Drawing.Font("Footlight MT Light", 14.25F);
            this.listaPeliculasEstreno.ForeColor = System.Drawing.Color.White;
            this.listaPeliculasEstreno.FormattingEnabled = true;
            this.listaPeliculasEstreno.ItemHeight = 20;
            this.listaPeliculasEstreno.Location = new System.Drawing.Point(26, 27);
            this.listaPeliculasEstreno.Name = "listaPeliculasEstreno";
            this.listaPeliculasEstreno.Size = new System.Drawing.Size(450, 144);
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
            this.groupBoxDatosPelicula.Location = new System.Drawing.Point(11, 267);
            this.groupBoxDatosPelicula.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxDatosPelicula.Name = "groupBoxDatosPelicula";
            this.groupBoxDatosPelicula.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxDatosPelicula.Size = new System.Drawing.Size(496, 247);
            this.groupBoxDatosPelicula.TabIndex = 23;
            this.groupBoxDatosPelicula.TabStop = false;
            this.groupBoxDatosPelicula.Text = "DATOS PELICULA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 142);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "DESCRIPCION:";
            // 
            // txtEstreno
            // 
            this.txtEstreno.Enabled = false;
            this.txtEstreno.Location = new System.Drawing.Point(246, 92);
            this.txtEstreno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEstreno.Name = "txtEstreno";
            this.txtEstreno.Size = new System.Drawing.Size(60, 20);
            this.txtEstreno.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(167, 95);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "ESTRENO:";
            // 
            // txtAño
            // 
            this.txtAño.Enabled = false;
            this.txtAño.Location = new System.Drawing.Point(389, 36);
            this.txtAño.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(60, 20);
            this.txtAño.TabIndex = 22;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(64, 36);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(214, 20);
            this.txtNombre.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "AÑO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "NOMBE:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.Red;
            this.txtDescripcion.Font = new System.Drawing.Font("Footlight MT Light", 12F);
            this.txtDescripcion.ForeColor = System.Drawing.Color.White;
            this.txtDescripcion.Location = new System.Drawing.Point(14, 169);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(453, 63);
            this.txtDescripcion.TabIndex = 30;
            // 
            // FormPeliculasEstreno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(521, 528);
            this.Controls.Add(this.groupBoxDatosPelicula);
            this.Controls.Add(this.groupBox2);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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