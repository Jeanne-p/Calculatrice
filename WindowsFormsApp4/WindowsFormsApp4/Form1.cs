using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibGN.GrandsNombres;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        #region initialisation
        //Attributs
        string[] variables = { "0", "0", "0", "0", "0", "0", "0", "0", "0" };
        int compteur = 0;
        bool rcl; bool sto;
        string nb1 = ""; string op = ""; string nb2 = ""; string resultat = "";


        public Form1()
        {
            InitializeComponent();
 
        }
        //Préférences de départ
        private void Form1_Load(object sender, EventArgs e)
        {
            AffCalcul();
            gbOperations.Enabled = false;
            bEgal.Enabled = false;
            bSigne.Enabled = false;
            tbNombre.Text = "0";
        }
        #endregion
        #region Entrer

        //Gérer si le nombre entrer est le nombre #1 ou le nombre #2
        private void bEntrer_Click(object sender, EventArgs e)
        {
            if (compteur == 0||compteur==-1)
            {
                nb1 = tbNombre.Text;
                if(compteur ==-1)
                {
                    op = ""; nb2 = ""; resultat = "";
                    compteur++;

                }
                gbOperations.Enabled = true;
            }
            if (compteur == 2)
            {
                nb2 = tbNombre.Text;
                bEgal.Enabled = true;
            }
            AffCalcul();
            tbNombre.Text = "0";
            tbNombre.Enabled = false;
            gbVariables.Enabled = false;
            gbGN.Enabled = false;
            bEntrer.Enabled = false;
            bSigne.Enabled = true;
            compteur++;

        }
#endregion
        #region OPÉRATIONS

        //Ajouter l'opération selon le bouton sélectionné
        private void bAdd_Click(object sender, EventArgs e)
        {
            int operation = Convert.ToInt32(((Button)sender).Tag);
            if (tbNombre.Enabled == false)
            {
                
                switch (operation)
                {
                    //Ajoute l'opération au calcul
                    case 0:
                        {
                            op = "+";
                            compteur++;
                            break;

                        }
                    case 1:
                        {
                            op = "-";
                            compteur++;
                            break;
                        }
                    case 2:
                        {
                            op = "x";
                            compteur++;
                            break;
                        }
                    case 3:
                        {
                            op = "/";
                            compteur++;
                            break;
                        }
                    case 4:
                        {
                            op = "%";
                            compteur++;
                            break;
                        }
                    case 5:
                        {
                            op = "^";
                            compteur++;
                            break;
                        }
                    case 6:
                        {
                            resultat += "=";
                            tbNombre.Text = DoCalcul();
                            compteur = -1;
                            break;
                        }

                    case 7:
                        {
                            //change le signe sans changer l'opération
                            if (compteur == 1)
                            {
                                nb1 = ((new GN(nb1)) * -1).ToString();
                            }
                            if (compteur == 3)
                            {

                                nb2 = ((new GN(nb2))*-1).ToString();
                            }
                            break;
                        }
                

                }
                AffCalcul();
                if (compteur == -1 || compteur == 0 || compteur == 2 || compteur == 4)
                {
                    tbNombre.Enabled = true;
                    gbVariables.Enabled = true;
                    gbGN.Enabled = true;
                    bEntrer.Enabled = true;
                    gbOperations.Enabled = false;
                    bSigne.Enabled = false;
                    bEgal.Enabled = false;
                }


            }
        }
            #endregion
        #region VARIABLES
        //activer le recall
            private void bRCL_Click(object sender, EventArgs e)
        {
            enableVariable();
            rcl = true;

        }

        //activer l'enregistrement
        private void bSTO_Click(object sender, EventArgs e)
        {

            enableVariable();
            sto = true;
        }

        //changer la variable selon le bouton activé

        private void bA_Click(object sender, EventArgs e)
        {
            //Quelle variable changer dans le tableau selon le bouton pesé
            int a = Convert.ToInt32(((Button)sender).Tag);

            if (rcl == true || sto == true)
            {
                if (rcl == true)
                {
                    tbNombre.Text = variables[a];
                }
                if (sto == true)
                {
                    variables[a] = tbNombre.Text;
                }
                enableVariable();
            }
        }
        //Activer ou réactiver les composantes
        void enableVariable()
        {
            if (rcl == true || sto == true)
            {
                tbNombre.Enabled = true;
                gbGN.Enabled = true;
                bEntrer.Enabled = true;
                gbOperations.Enabled = true;
                rcl = false;
                sto = false;
            }


            else
            {
                tbNombre.Enabled = false;
                gbGN.Enabled = false;
                bEntrer.Enabled = false;
                gbOperations.Enabled = false;

            }

        }
        #endregion
        #region Calcul

        //Afficher le calcul
        void AffCalcul()
        {
            lCalcul.Text = nb1 + op + nb2 + resultat;
            lCalcul.Refresh();

        }

        //Faire le calcul selon l'opération sélectionnée
        string DoCalcul()
        {
            string res = "";
            try
            {
                GN a = new GN(nb1); GN b = new GN(nb2);
                switch (op)
                {
                    //Selon l'opération
                    case "+":
                        {
                            res = GN.Add(a, b).ToString();
                            break;
                        }
                    case "-":
                        {
                            res = GN.Substract(a, b).ToString();
                            break;
                        }
                    case "x":
                        {
                            res = GN.Mult(a, b).ToString();
                            break;
                        }
                    case "/":
                        {
                            res = (a / b).ToString();
                            break;
                        }
                    case "%":
                        {
                            res = (a % b).ToString();
                            break;
                        }
                    case "^":
                        {
                            GN exp = new GN(nb2);
                            GN resul = new GN(1);
                            do
                            {
                                resul = resul * a;
                                exp = exp - 1;
                            } while (exp != 0);
                            res = resul.ToString();
                            break;

                        }
                }
            }
            catch
            {
                res = " Opération impossible";
            }



            AffCalcul();
            return res;
        }
        #endregion
        #region Affichage de l'exposant

        //Mettre la bulle

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {
            if (tbNombre.Text.Length > 4)
            {
                toolTip2.SetToolTip(tbNombre, exposant(tbNombre.Text, 0));
            }
            else
            {
                toolTip2.SetToolTip(tbNombre, " ");
            }
        }

        //Méthode pour calculer l'exposant
        string exposant(string nb, int expos)
        {
            string nbAfficher="";
            if(nb.Length>4)
            {
                expos++;
                nb = nb.Substring(0, nb.Length - 1);
                nbAfficher = exposant(nb, expos);
            }
            else
            {
                nbAfficher = nb + "e" + expos.ToString();
            }
                return nbAfficher;
        }
        #endregion
        #region GN enregistrer

        //Enregistrer
        private void bEnregistrer_Click(object sender, EventArgs e)
        {
            GN a = new GN(tbNombre.Text);

            SaveFileDialog save = new SaveFileDialog();
    
            save.FileName = a.ToString()+".txt";
            save.Filter = "Fichier texte|*.txt";

            if (save.ShowDialog() == DialogResult.OK)
            {
                a.Write(save.FileName);
            }
            else
            {
                return;
            }
            toolTip1.SetToolTip(bEnregistrer, "GN enregistré");
        }
        //Lire un GN
        private void bLire_Click(object sender, EventArgs e)
        {
            GN a = new GN();
            OpenFileDialog open = new OpenFileDialog();

            if (open.ShowDialog() == DialogResult.OK)
            {
                tbNombre.Text = (GN.Load(open.FileName, 1)).ToString();
            }
            else
            {
                return;
            }


        }



        #endregion



    }
}
