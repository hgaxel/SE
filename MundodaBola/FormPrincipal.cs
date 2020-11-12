using MundodaBola;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SbsSW.SwiPlCs;
using System.Windows.Forms;

namespace SistemaExperto
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPeliculasDisponibles frm = new FormPeliculasDisponibles();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormPeliculasEstreno frm = new FormPeliculasEstreno();
            frm.Show();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            /* usando o método Environment.SetEnvironmentVariable para crear variable de ambiente de swipl .
            * para trabajar com prolog*/
            Environment.SetEnvironmentVariable("SWI_HOME_DIR", @"prolog"); // establecer las variables en el archivo PL
            Environment.SetEnvironmentVariable("Path", @"prolog");         // establecer las variables en el archivo PL
            Environment.SetEnvironmentVariable("Path", @"prolog\\bin");    // establecer las variables en el archivo PL

            string[] p = { "-q", "-f", @"Peliculas.pl", @"Peliculas_estreno.pl" };
            PlEngine.Initialize(p);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
