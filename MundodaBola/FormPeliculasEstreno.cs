using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SbsSW.SwiPlCs;

namespace MundodaBola
{
    public partial class FormPeliculasEstreno : Form
    {
        public FormPeliculasEstreno()
        {
            InitializeComponent();
        }

        private void FormPeliculasEstreno_Load(object sender, EventArgs e)
        {
            Iniciar();
        }

        private void Iniciar()
        {
            PlQuery peliculasEstreno = new PlQuery("listaPeliculasEstreno(R)");

            foreach (PlQueryVariables v in peliculasEstreno.SolutionVariables)
            {
                var peliculas = v["R"];

                listaPeliculasEstreno.Items.Add(peliculas.ToString());
            }
        }

        #region Funciones 

        private void mostrarDatosPelicula(List<PlTerm> pelicula, string peliculaSelected)
        {
            txtNombre.Text = peliculaSelected;
            txtAño.Text = pelicula[0].ToString();
            txtDescripcion.Text = pelicula[1].ToString();
            txtEstreno.Text = pelicula[2].ToString();
        }

        #endregion

        private void btnConsultarPeliculas_Click(object sender, EventArgs e)
        {
            groupBoxDatosPelicula.Enabled = true;

            if (listaPeliculasEstreno.SelectedItem == null) return;

            txtDescripcion.Text = "";

            string peliculaSeleccionada = listaPeliculasEstreno.SelectedItem.ToString();

            PlQuery peliculasEstreno = new PlQuery("peliculaEstreno('"+ peliculaSeleccionada + "',R)");

            foreach (PlQueryVariables v in peliculasEstreno.SolutionVariables)
            {
                var peliculas = v["R"].ToList();

                mostrarDatosPelicula(peliculas.ToList(), peliculaSeleccionada);
            }
            
        }
    }
}
