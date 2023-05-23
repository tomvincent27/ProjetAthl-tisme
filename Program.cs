using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Commande.Données;
using Commande.Controleur;


namespace ProjetAthlétisme
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Controleur ctrl = new Controleur(); // création du contrôleur

            VueGénérale fenetrePrincipale = new VueGénérale // création de la fenêtre principale
            {
                //Il faut que la fenêtre principale connaisse le contrôleur 
                //Elle pourra le faire connaître aux autres vues
                Controle = ctrl // initialisation du contrôleur de la fenêtre principale
            };
            try
            {
                Application.Run(fenetrePrincipale);  // affichage de la fenêtre principale
            }
            catch (Exception exc)
            {
                MessageBox.Show("Erreur : \n" + exc.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
