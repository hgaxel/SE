using System;
using System.Windows.Forms;
using SbsSW.SwiPlCs;

namespace MundodaBola
{
    public partial class FormJogador : Form
    {
        public FormJogador()
        {
            InitializeComponent();
        }

        void mostra()
        {

         
            // listAdd.Items.Clear();
        }

        private void FormJogador_Load(object sender, EventArgs e)
        {
            /* usando o método Environment.SetEnvironmentVariable para crear variable de ambiente de swipl .
             * para trabajar com prolog*/
            Environment.SetEnvironmentVariable("SWI_HOME_DIR", @"prolog"); // establecer las variables en el archivo PL
            Environment.SetEnvironmentVariable("Path", @"prolog");         // establecer las variables en el archivo PL
            Environment.SetEnvironmentVariable("Path", @"prolog\\bin");    // establecer las variables en el archivo PL

            string[] p = { "-q", "-f", @"jogador.pl" };
            PlEngine.Initialize(p);
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
                    PlQuery zagueiro = new PlQuery("prueba(X)");
                    foreach (PlQueryVariables v in zagueiro.SolutionVariables)
                        listJogador.Items.Add(v["X"].ToString());
                    break;


            }

            
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            //limpar tela de consulta
            listJogador.Items.Clear();
        }

        private void cbOpcoes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
