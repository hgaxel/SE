﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SbsSW.SwiPlCs;
using System.Windows.Forms;
using SbsSW.SwiPlCs.Callback;

namespace MundodaBola
{
    public partial class FormPeliculasDisponibles : Form
    {
        int resultado = 0;
        int seleccion = 1;
        int totalLista1 = 0;  //AVENTURA, ACCIÓN, DRAMA, TRHILLER/SUSPENSE. 
        int totalLista2 = 0;  //TERROR,COMEDIA,ROMANTICO.
        int totalLista3 = 0;  //PARA TODA LA FAMILIA, CIENCIA FICCIÓN.
        int totalLista4 = 0;  //COMICS, DOCUMENTALES.
        string generosResultantes = "";
        string consultaFinal = "";
        List<int> list = new List<int>();

        public FormPeliculasDisponibles()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /* usando o método Environment.SetEnvironmentVariable para crear variable de ambiente de swipl .
            * para trabajar com prolog*/
           /* Environment.SetEnvironmentVariable("SWI_HOME_DIR", @"prolog"); // establecer las variables en el archivo PL
            Environment.SetEnvironmentVariable("Path", @"prolog");         // establecer las variables en el archivo PL
            Environment.SetEnvironmentVariable("Path", @"prolog\\bin");    // establecer las variables en el archivo PL

            string[] p = { "-q", "-f", @"peliculas.pl" };
            PlEngine.Initialize(p);*/

            Iniciar();
        }



        private void btnConsulta_Click(object sender, EventArgs e)
        {
            //Limpar a tela de consulta a cada nova interação
            listJogador.Items.Clear();
            //buscar os dados do banco de dados criado através do Prolog
            PlQuery carrega = new PlQuery("carrega('peliculas.bd')");
            carrega.NextSolution();
            List<string> lista = new List<string>();

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
                    string datox = "X";
                    string enviar = "jogador(" + datox + ")";
                    
                    PlQuery zagueiro = new PlQuery("pelicula(X,R)");
                    int cont = 0;
                    foreach (PlQueryVariables v in zagueiro.SolutionVariables)
                        //lista.Add(v["X"].ToString());
                        listJogador.Items.Add(v["X"].ToString());
                    //datavg.Rows[cont].Cells[0].Value = v["X"].ToString();
                    //cont++;
                    //datavg.Rows[0].Cells[v].Value = v["X"].ToString();
                    //listJogador.Items.Add(v["Y"].ToString());
                    break;
            }
        }


        private void Iniciar()
        {
            if (MessageBox.Show("SISTEMA EXPERTO - SISIN 2020","BIENVENIDO", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                this.pregunta.Text = " ¿EN QUE OPCIÓN SE ENCUENTRA EL GENERO DE LA PELICULA QUE VISTE POR ULTIMA VEZ? ";
                this.opcion1.Text = " AVENTURAS, ACCIÓN , COMEDIAS, INTERNACIONALES. "; // +2
                this.opcion2.Text = " TERROR , DRAMA , ROMANTICO , TRHILLERS/SUSPENSE. ";    // +2
                this.opcion3.Text = " FAMILIA , CIENCIA FICCIÓN , FANTASTICAS , ROMANTICAS. "; // +2
                this.opcion4.Text = " ANIMES , DOCUMENTALES , INFANTILES , PREMIADAS";   // +2
            }
            else
            {
                Application.Exit();
            }
        }

        private void pregunta2()
        {
            this.pregunta.Text = " ¿QUÉ PELICULA TE GUSTA MÁS? ";
            this.opcion1.Text = "Spider-Man: Un nuevo universo.";//acc, com,prem    lista1
            this.opcion2.Text = "Cadaver.";       //terror,peli inter.              lista2
            this.opcion3.Text = "El Halloween de Hubie.";       //comedia           lista1
            this.opcion4.Text = "El juicio de los 7 de Chicago.";  //drama          lista2
            seleccion++;
        }

        private void pregunta3()
        {
            this.pregunta.Text = " ¿QUÉ EDAD TIENES? ";
            this.opcion1.Text = " +7. ";        //DESCARTAMOS COMEDIAS,TERROR,TRAGEDIA,DRAMA,ACCION, DOCUMENTAL lista4 +2
            this.opcion2.Text = " +13. ";       //DESCARTAMOS DOCUMENTAL,TERROR,DRAMA                           lista3
            this.opcion3.Text = " +16.";        //      +5                                                      lista1
            this.opcion4.Text = " +18.";        //      +7                                                      lista1,lista2,lista3,lista4
            seleccion++;
        }

        private void pregunta4()
        {
            this.pregunta.Text = " ¿QUÉ PELICULA NO VOLVERIAS A VER ? ";
            this.opcion1.Text = " Santana."; //ACCION, EXTRANJERAS                            lista1
            this.opcion2.Text = " Robin Hood."; //ACCION                                      lista1
            this.opcion3.Text = " Visions."; //TERROR Y THRILLER                              lista2
            this.opcion4.Text = " Un mundo azul: La carrera para resolver la crisis del agua."; //DOCUM Y EXTRANJ  lista3,lista4
            seleccion++;
        }
        private void pregunta5()
        {
            this.pregunta.Text = " ¿CUAL DE ESTAS PELICULAS VERIAS MÁS DE UNA VEZ? ";
            this.opcion1.Text = " Bumblebee. "; //ACCION, CF, FANTASIAS           lista1
            this.opcion2.Text = " Pokémon: Mewtwo contraataca."; //ANIME          lista4
            this.opcion3.Text = " Animas "; //TERROR                              lista2
            this.opcion4.Text = " El Árbol de la Sangre. "; //Dramas, Españolas, Extranjeras    lista2 y lista3
            seleccion++;
        }
        private void pregunta6()
        {
            this.pregunta.Text = " SELECCIONA UNA DE ESTAS PELICULAS QUE VERIAS. ";
            this.opcion1.Text = " Destino Final.";  //terror            lista2
            this.opcion2.Text = " Tsunami. ";         //cienciaf        lista3
            this.opcion3.Text = " Cómo deshacerte de tu jefe. "; //Com  lista1
            this.opcion4.Text = " Joker. "; //drama                     lsita2
            seleccion++;
        }
        private void pregunta7()
        {
            this.pregunta.Text = " ¿QUÉ PELICULA VERIAS CON TU PAREJA? ";               
            this.opcion1.Text = " Flechazo a primera vista. "; //COME, EXTRAN, ROMANTIC     lista1 y lista 3
            this.opcion2.Text = " Nadie duerme en el bosque esta noche"; //TERROR           lista2
            this.opcion3.Text = " El Silencio de Otros";  //doc , extranjeras               lista 4
            this.opcion4.Text = " No tengo pareja :'( . ";                       //         lista1
            seleccion++;
        }
        private void pregunta8()
        {
            this.pregunta.Text = " ¿QUÉ PELICULA ANTIGUA VOLVERIAS A MIRAR ? ";     
            this.opcion1.Text = " Jumanji. "; //ciencia y aventura              lista3 y lista2
            this.opcion2.Text = " Rambo. ";   //accion                          lista1
            this.opcion3.Text = " Scary Movie"; //comedi                        lista1
            this.opcion4.Text = " Star Wars"; //Fantasia ciencia f              lista3 y lista 4
            seleccion++;
        }
        private void pregunta9()
        {
            this.pregunta.Text = " ¿QUÉ TIPO DE DOCUMENTAL ESTARIA DISPUESTO A VER? ";
            this.opcion1.Text = " LOS SECRETOS DE LA TUMBA DE SAQQARA. ";   //extranjeras       lista3 y lista4
            this.opcion2.Text = " TODOS CON ROONA. ";                       //extranjeras       lista3 y lista4
            this.opcion3.Text = " UN MUNDO AZUL: LA CARRERA PARA RESOLVER LA CRISIS DEL AGUA. ";  // lista4
            this.opcion4.Text = " BENDING THE ARC: SANIDAD SIN FRONTERA. ";         //          lista4
            seleccion++;
        }
        private void pregunta10()
        {
            this.pregunta.Text = " ¿QUÉ PELICULA HAS VISTO MAS DE UNA VEZ? ";
            this.opcion1.Text = " En busca de la felicidad. "; //drama  lista2
            this.opcion2.Text = " Oso Ted."; //comedia                  lista1
            this.opcion3.Text = " Paranormal Activity."; // Terror      lista2
            this.opcion4.Text = " Sherk "; //aventura                   lista1
            seleccion++;
        }
        private void Limpiar()
        {
            this.opcion1.Checked = false;
            this.opcion2.Checked = false;
            this.opcion3.Checked = false;
            this.opcion4.Checked = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            switch (seleccion)
            {
                case 1:

                    if (this.opcion1.Checked == true)
                    {
                        totalLista1++;
                    }
                    else
                    if (this.opcion2.Checked == true)
                    {
                        totalLista2++;
                    }
                    else
                    if (this.opcion3.Checked == true)
                    {
                        totalLista3++;
                    }
                    else
                    if (this.opcion4.Checked == true)
                    {
                        totalLista4++;
                    }

                    pregunta2();
                    Limpiar();


                    break;

                case 2:
                    if (this.opcion1.Checked == true)
                    {
                        totalLista1++;
                    }
                    else
                    if (this.opcion2.Checked == true)
                    {
                        totalLista2++;
                    }
                    else
                    if (this.opcion3.Checked == true)
                    {
                        totalLista3++;
                    }
                    else
                    if (this.opcion4.Checked == true)
                    {
                        totalLista4++;
                    }
                    pregunta3();
                    Limpiar();
                    break;

                case 3:
                    if (this.opcion1.Checked == true)
                    {
                        totalLista1++;
                    }
                    else
                     if (this.opcion2.Checked == true)
                    {
                        totalLista2++;
                    }
                    else
                     if (this.opcion3.Checked == true)
                    {
                        totalLista3++;
                    }
                    else
                     if (this.opcion4.Checked == true)
                    {
                        totalLista4++;
                    }
                    pregunta4();
                    Limpiar();
                    break;

                case 4:
                    if (this.opcion1.Checked == true)
                    {
                        totalLista1++;
                    }
                    else
                    if (this.opcion2.Checked == true)
                    {
                        totalLista2++;
                    }
                    else
                    if (this.opcion3.Checked == true)
                    {
                        totalLista3++;
                    }
                    else
                    if (this.opcion4.Checked == true)
                    {
                        totalLista4++;
                    }
                    pregunta5();
                    Limpiar();
                    break;

                case 5:
                    if (this.opcion1.Checked == true)
                    {
                        totalLista1++;
                    }
                    else
                    if (this.opcion2.Checked == true)
                    {
                        totalLista2++;
                    }
                    else
                    if (this.opcion3.Checked == true)
                    {
                        totalLista3++;
                    }
                    else
                    if (this.opcion4.Checked == true)
                    {
                        totalLista4++;
                    }
                    pregunta6();
                    Limpiar();
                    break;

                case 6:
                    if (this.opcion1.Checked == true)
                    {
                        totalLista1++;
                    }
                    else
                    if (this.opcion2.Checked == true)
                    {
                        totalLista2++;
                    }
                    else
                    if (this.opcion3.Checked == true)
                    {
                        totalLista3++;
                    }
                    else
                    if (this.opcion4.Checked == true)
                    {
                        totalLista4++;
                    }
                    pregunta7();
                    Limpiar();
                    break;

                case 7:
                    if (this.opcion1.Checked == true)
                    {
                        totalLista1++;
                    }
                    else
                     if (this.opcion2.Checked == true)
                    {
                        totalLista2++;
                    }
                    else
                     if (this.opcion3.Checked == true)
                    {
                        totalLista3++;
                    }
                    else
                     if (this.opcion4.Checked == true)
                    {
                        totalLista4++;
                    }
                    pregunta8();
                    Limpiar();
                    break;

                case 8:
                    if (this.opcion1.Checked == true)
                    {
                        totalLista1++;
                    }
                    else
                      if (this.opcion2.Checked == true)
                    {
                        totalLista2++;
                    }
                    else
                      if (this.opcion3.Checked == true)
                    {
                        totalLista3++;
                    }
                    else
                      if (this.opcion4.Checked == true)
                    {
                        totalLista4++;
                    }
                    pregunta9();
                    Limpiar();
                    break;

                case 9:
                    if (this.opcion1.Checked == true)
                    {
                        totalLista1++;
                    }
                    else
                     if (this.opcion2.Checked == true)
                    {
                        totalLista2++;
                    }
                    else
                     if (this.opcion3.Checked == true)
                    {
                        totalLista3++;
                    }
                    else
                     if (this.opcion4.Checked == true)
                    {
                        totalLista4++;
                    }
                    pregunta10();
                    Limpiar();
                    break;

                case 10:
                    if (this.opcion1.Checked == true)
                    {
                        totalLista1++;
                    }
                    else
                    if (this.opcion2.Checked == true)
                    {
                        totalLista2++;
                    }
                    else
                    if (this.opcion3.Checked == true)
                    {
                        totalLista3++;
                    }
                    else
                    if (this.opcion4.Checked == true)
                    {
                        totalLista4++;
                    }

                    Limpiar();

                    resultado = verificarMayor(totalLista1, totalLista2, totalLista3, totalLista4);
                    
                    if(totalLista1==resultado)
                    {
                        generosResultantes = " AVENTURAS, ACCIÓN , COMEDIAS, INTERNACIONALES.";
                        consultaFinal = "'aventuras','accion','comedias','internacionales',R1,R2,R3,R4";
                    }      
                    else
                        if(totalLista2==resultado)
                        {
                            generosResultantes = " TERROR , DRAMA , ROMANTICO , TRHILLERS/SUSPENSE";
                            consultaFinal = "'terror','drama','romantico','thrillers',R1,R2,R3,R4";
                        }  
                        else
                            if(totalLista3==resultado)
                            {
                                generosResultantes = " FAMILIA , CIENCIA FICCIÓN , FANTASTICAS , ROMANTICAS. ";
                                consultaFinal = "'familia','ciencia_ficcion','fantasticas','romanticas',R1,R2,R3,R4";
                            }
                            else
                                if (totalLista4 == resultado)
                                {
                                    generosResultantes = " ANIMES , DOCUMENTALES , INFANTILES , PREMIADAS";
                                    consultaFinal = "'anime','documentales','infantiles','premiadas',R1,R2,R3,R4";
                                }
                                    

                    MessageBox.Show("LA LISTA DE GENEROS QUE SE ADAPTAN A TUS GUSTOS SON: "+ generosResultantes.ToString() + "\n \n SE PRESENTARA LA LISTA DE PELICULAS RECOMENDADAS PARA TI", 
                                        " RESULTADO DE TEST ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    /*string datox = "X";
                    string enviar = "jogador(" + datox + ")";*/

                    //CONSULTA FINAL
                    //listaPeliculas1('aventuras','accion','comedias','internacionales',R1,R2,R3,R4).

                    PlQuery pelicula = new PlQuery("listaPeliculas(" + consultaFinal + ")");
                    int cont = 0;
                    foreach (PlQueryVariables v in pelicula.SolutionVariables)
                        listJogador.Items.Add(v["R1"].ToString()+ v["R2"].ToString()+ v["R3"].ToString()+ v["R4"].ToString());
                        //FALTA TERMINAR    SEPARAR DATOS POR FILAS

                    groupBoxPeliculas.Enabled = true;

                    //datavg.Rows[cont].Cells[0].Value = v["X"].ToString();
                    //cont++;
                    //datavg.Rows[0].Cells[v].Value = v["X"].ToString();
                    //listJogador.Items.Add(v["Y"].ToString());
                    //Application.Exit();
                    //LLAMAR A EL EVENTO CONSULTAR :  


                    this.pregunta.Text = " \n            CUESTIONARIO FINALIZADO.         ";
                    opcion1.Enabled = false;
                    opcion2.Enabled = false;
                    opcion3.Enabled = false;
                    opcion4.Enabled = false;
                    button1.Enabled = false;

                    break;
                default:
                   
                    break;
            }
        }

        private int verificarMayor(int d1,int d2,int d3,int d4)
        {
            list.Add(d1);
            list.Add(d2);
            list.Add(d3);
            list.Add(d4);
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            int mayor = list.Max();

            return mayor;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            groupBoxDatos.Enabled = true;
            string peliculaSeleccionada = listJogador.SelectedItem.ToString();
            
            if (peliculaSeleccionada == null)
            {
                MessageBox.Show(this, "NO SELECCIONO NINGUNA PELICULA", "SISTEMA EXPERTO - SISIN 2020", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string consulta = "pelicula('" + peliculaSeleccionada + "',R)";
                txtNombre.Text = peliculaSeleccionada;
                PlQuery pelicula = new PlQuery(consulta);
                foreach (PlQueryVariables v in pelicula.SolutionVariables)
                    listBoxDescripcion.Items.Add(v["R"].ToString());
                //FALTA TERMINAR    SEPARAR DATOS 
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {

            listJogador.Items.Clear();

            if(checkAño.Checked==true && checkGenero.Checked == true && checkEdad.Checked == true)
            {
                int año = Convert.ToInt16(comboAño.SelectedItem);
                string genero = Convert.ToString(comboGenero.SelectedItem);
                int edad = Convert.ToInt16(comboEdad.SelectedItem);
                
                string consulta = "filtrarPeliculaAñoGeneroEdad("+año+","+"'"+ genero +"',"+edad+",R)";
                
                PlQuery pelicula = new PlQuery(consulta);
                foreach (PlQueryVariables v in pelicula.SolutionVariables)
                    listBoxDescripcion.Items.Add(v["R"].ToString());
            }
            else
                if (checkAño.Checked == true && checkGenero.Checked == true && checkEdad.Checked == false)
                { 
                    int año = Convert.ToInt16(comboAño.SelectedItem);
                    string genero = Convert.ToString(comboGenero.SelectedItem);
                    
                
                    string consulta = "filtrarPeliculaAñoGenero("+año+","+"'"+ genero +"'"+",R)";
                
                    PlQuery pelicula = new PlQuery(consulta);
                    foreach (PlQueryVariables v in pelicula.SolutionVariables)
                        listJogador.Items.Add(v["R"].ToString());
                }
                else
                    if (checkAño.Checked == true && checkGenero.Checked == false && checkEdad.Checked == true)
                    {
                            int año = Convert.ToInt16(comboAño.SelectedItem);
                            
                            int edad = Convert.ToInt16(comboEdad.SelectedItem);

                            string consulta = "filtrarPeliculaAñoEdad(" + año + "," + edad + ",R)";

                            PlQuery pelicula = new PlQuery(consulta);
                            foreach (PlQueryVariables v in pelicula.SolutionVariables)
                                listJogador.Items.Add(v["R"].ToString());
                    }
                    else
                        if (checkAño.Checked == true && checkGenero.Checked == false && checkEdad.Checked == false)
                        {
                            int año = Convert.ToInt16(comboAño.SelectedItem);

                            string consulta = "peliculasPorAnio(" + año + ",R)";

                            PlQuery pelicula = new PlQuery(consulta);
                            foreach (PlQueryVariables v in pelicula.SolutionVariables)
                                listJogador.Items.Add(v["R"].ToString());
                        }
                        else
                            if (checkAño.Checked == false && checkGenero.Checked == true && checkEdad.Checked == true)
                            {
                                string genero = Convert.ToString(comboGenero.SelectedItem);
                                int edad = Convert.ToInt16(comboEdad.SelectedItem);
                                string consulta = "filtrarPeliculaGeneroEdad('" + genero + "',"+edad+",R)";

                                PlQuery pelicula = new PlQuery(consulta);
                                foreach (PlQueryVariables v in pelicula.SolutionVariables)
                                    listJogador.Items.Add(v["R"].ToString());
                            }
                            else
                                if (checkAño.Checked == false && checkGenero.Checked == true && checkEdad.Checked == false)
                                {
                                    string genero = Convert.ToString(comboGenero.SelectedItem);
                                    
                                    string consulta = "peliculasPorGenero('" + genero + "',R)";

                                    PlQuery pelicula = new PlQuery(consulta);
                                    foreach (PlQueryVariables v in pelicula.SolutionVariables)
                                        listJogador.Items.Add(v["R"].ToString());
                                }
                                else
                                    if (checkAño.Checked == false && checkGenero.Checked == false && checkEdad.Checked == true)
                                    {
                                        int edad = Convert.ToInt16(comboEdad.SelectedItem);

                                        string consulta = "peliculasPorEdad(" + edad + ",R)";

                                        PlQuery pelicula = new PlQuery(consulta);
                                        foreach (PlQueryVariables v in pelicula.SolutionVariables)
                                            listJogador.Items.Add(v["R"].ToString());
                                    }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupFiltrado.Enabled = true;
        }

        private void checkAño_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAño.Checked == true)
                comboAño.Enabled = true;
            else
                if (checkAño.Checked == false)
                    comboAño.Enabled = false;
        }

        private void checkGenero_CheckedChanged(object sender, EventArgs e)
        {
            if (checkGenero.Checked == true)
                comboGenero.Enabled = true;
            else
                if (checkGenero.Checked == false)
                    comboGenero.Enabled = false;
        }

        private void checkEdad_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdad.Checked == true)
                comboEdad.Enabled = true;
            else
                if (checkEdad.Checked == false)
                    comboEdad.Enabled = false;
        }
    }
}
