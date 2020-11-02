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

namespace MundodaBola
{
    public partial class FormPeliculasDisponibles : Form
    {
        int resultado = 0;
        int seleccion = 1;

        public FormPeliculasDisponibles()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /* usando o método Environment.SetEnvironmentVariable para crear variable de ambiente de swipl .
            * para trabajar com prolog*/
            Environment.SetEnvironmentVariable("SWI_HOME_DIR", @"prolog"); // establecer las variables en el archivo PL
            Environment.SetEnvironmentVariable("Path", @"prolog");         // establecer las variables en el archivo PL
            Environment.SetEnvironmentVariable("Path", @"prolog\\bin");    // establecer las variables en el archivo PL

            string[] p = { "-q", "-f", @"jogador.pl" };
            PlEngine.Initialize(p);

            Iniciar();
        }

        private void Iniciar()
        {
            if (MessageBox.Show("BIENVENIDO", "Evaluacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                this.pregunta.Text = "¿ QUE OPCIÓN SE ACOMODA MÁS A SUS GENEROS FAVORITOS ?";
                this.opcion1.Text = "AVENTURA, ACCIÓN, DRAMA, TRHILLER/SUSPENSE ";
                this.opcion2.Text = "TERROR,COMEDIA,ROMANTICO.";
                this.opcion3.Text = "PARA TODA LA FAMILIA, CIENCIA FICCIÓN,";
                this.opcion4.Text = "COMICS. ";
            }
            else
            {
                Application.Exit();
            }
        }


        private void btnConsulta_Click(object sender, EventArgs e)
        {
            //Limpar a tela de consulta a cada nova interação
            listJogador.Items.Clear();
            //buscar os dados do banco de dados criado através do Prolog
            PlQuery carrega = new PlQuery("carrega('jogador.bd')");
            carrega.NextSolution();

            //Usando estrutura condicional para as consultas
            switch (Convert.ToString(cbOpcoes.SelectedItem))
            {

                case "Atacante Brasileiro":
                    PlQuery atacantebrasileiro = new PlQuery("atacantebrasileiro(X)");
                    
                    foreach (PlQueryVariables v in atacantebrasileiro.SolutionVariables)
                        listJogador.Items.Add(v["X"].ToString());
                    break;

                case "Meia Brasileiro":
                    PlQuery meiabrasileiro = new PlQuery("meiabrasileiro(X)");
                    foreach (PlQueryVariables v in meiabrasileiro.SolutionVariables)
                        listJogador.Items.Add(v["X"].ToString());
                    break;

                case "Atacante Europeu":
                    PlQuery atacanteeuropeu = new PlQuery("atacanteeuropeu(X)");
                    foreach (PlQueryVariables v in atacanteeuropeu.SolutionVariables)
                        listJogador.Items.Add(v["X"].ToString());
                    break;

                case "Zagueiro Brasileiro":
                    PlQuery zagueirobrasileiro = new PlQuery("zagueirobrasileiro(X)");
                    foreach (PlQueryVariables v in zagueirobrasileiro.SolutionVariables)
                        listJogador.Items.Add(v["X"].ToString());
                    break;

                case "Prueba":
                    PlQuery zagueiro = new PlQuery("pelicula1('peli1',X)");
                    foreach (PlQueryVariables v in zagueiro.SolutionVariables)
                        //listJogador.Items.Add(v["X"].ToString() +"  "+ v["Y"].ToString());
                        datavg.Rows[0].Cells[0].Value = v["X"].ToList();
              
                    //listJogador.Items.Add(v["Y"].ToString());
                    break;

            }
        }

        private void pregunta2()
        {
            this.pregunta.Text = " ESCOGA A PARTIR DE QUE AÑO PODEMOS RECOMENDARTE PELICULAS ";
            this.opcion1.Text = "2016.";
            this.opcion2.Text = "2017.";
            this.opcion3.Text = "2018.";
            this.opcion4.Text = "2019.";
            seleccion++;
        }


        private void pregunta3()
        {
            this.pregunta.Text = " ESCOGA LA LISTA DE PROCEDENCIA DE PELICULAS QUE MAS LE GUSTE ";
            this.opcion1.Text = " Estados Unidos, Reino Unido, Francia. ";
            this.opcion2.Text = " Canadá, China, Estados Unidos, Japon. ";
            this.opcion3.Text = " Reino Unido, Francia.";
            this.opcion4.Text = " Japon, China.";
            seleccion++;
        }

        private void pregunta4()
        {
            this.pregunta.Text = " ESCOGA LA DURACION EN MINUTOS  ";
            this.opcion1.Text = " MENOR A 60 MIN.";
            this.opcion2.Text = " MENOR A 90 MIN.";
            this.opcion3.Text = " MENOR A 120 MIN.";
            this.opcion4.Text = " MENOR A 150 MIN";
            seleccion++;
        }
        private void pregunta5()
        {
            this.pregunta.Text = " ESCOGA A PARTIR DE QUE EDAD DESEA LA RECOMENDACION ";
            this.opcion1.Text = " +7. ";
            this.opcion2.Text = " +13. ";
            this.opcion3.Text = " +16. ";
            this.opcion4.Text = " +18. ";
            seleccion++;
        }
        private void pregunta6()
        {
            this.pregunta.Text = " ESCOGA PROMEDIO DE VALORACION DE PELICULA. ";
            this.opcion1.Text = " >1 ";
            this.opcion2.Text = " >2 ";
            this.opcion3.Text = " >3 ";
            this.opcion4.Text = " >4 ";
            seleccion++;
        }
        private void pregunta7()
        {
            this.pregunta.Text = " ESCOGA A PARTIR DE QUE VALOR. ";
            this.opcion1.Text = " ";
            this.opcion2.Text = " ";
            this.opcion3.Text = " ";
            this.opcion4.Text = " ";
            seleccion++;
        }
        private void pregunta8()
        {
            this.pregunta.Text = " ESCOGA A PARTIR DE QUE VALOR. ";
            this.opcion1.Text = " ";
            this.opcion2.Text = " ";
            this.opcion3.Text = " ";
            this.opcion4.Text = " ";
            seleccion++;
        }
        private void pregunta9()
        {
            this.pregunta.Text = " ESCOGA A PARTIR DE QUE VALOR. ";
            this.opcion1.Text = " ";
            this.opcion2.Text = " ";
            this.opcion3.Text = " ";
            this.opcion4.Text = " ";
            seleccion++;
        }
        private void pregunta10()
        {
            this.pregunta.Text = " ESCOGA A PARTIR DE QUE VALOR. ";
            this.opcion1.Text = " ";
            this.opcion2.Text = " ";
            this.opcion3.Text = " ";
            this.opcion4.Text = " ";
            seleccion++;
        }
        private void Limpiar()
        {
            this.opcion1.Checked = true;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            switch (seleccion)
            {
                case 1:

                    if (this.opcion1.Checked == true)
                    {
                        resultado++;
                    }
                    

                    if (this.opcion2.Checked == true)
                    {
                        resultado++;
                    }
                

                    if (this.opcion3.Checked == true)
                    {
                        resultado++;
                    }


                    if (this.opcion4.Checked == true)
                    {
                        resultado++;
                    }
                    pregunta2();
                    Limpiar();


                    break;

                case 2:
                    if (this.opcion2.Checked == true)
                    {
                        resultado++;
                    }
                    pregunta3();
                    Limpiar();
                    break;

                case 3:
                    if (this.opcion4.Checked == true)
                    {
                        resultado++;
                    }
                    pregunta4();
                    Limpiar();
                    break;

                case 4:
                    if (this.opcion2.Checked == true)
                    {
                        resultado++;
                    }
                    pregunta5();
                    Limpiar();
                    break;

                case 5:
                    if (this.opcion3.Checked == true)
                    {
                        resultado++;
                    }
                    pregunta6();
                    Limpiar();
                    break;

                case 6:
                    if (this.opcion1.Checked == true)
                    {
                        resultado++;
                    }
                    pregunta7();
                    Limpiar();
                    break;

                case 7:
                    if (this.opcion4.Checked == true)
                    {
                        resultado++;
                    }
                    pregunta8();
                    Limpiar();
                    break;

                case 8:
                    if (this.opcion2.Checked == true)
                    {
                        resultado++;
                    }
                    pregunta9();
                    Limpiar();
                    break;

                case 9:
                    if (this.opcion4.Checked == true)
                    {
                        resultado++;
                    }
                    pregunta10();
                    Limpiar();
                    break;

                case 10:
                    if (this.opcion3.Checked == true)
                    {
                        resultado++;
                    }
                    if (resultado >= 7)
                    {
                        MessageBox.Show(resultado.ToString(), "FELICITACIONES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Exit();
                    }
                    else
                    {
                        MessageBox.Show(resultado.ToString(), "DEBES ATENDER MAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }

                    break;
                default:
                    break;
            }
        }
    }
}
