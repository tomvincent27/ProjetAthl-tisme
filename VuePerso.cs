using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Commande.Controleur;
using Commande.Données;

namespace ProjetAthlétisme
{
    public partial class VuePerso : Form
    {
        private Controleur ctrl;

        public VuePerso()
        {
            InitializeComponent();
        }

        public Controleur Ctrl  // propriété set Contrôleur pour modifier la donnée membre privée controleur
        {
            set
            {
                ctrl = value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                VueAllAthlètes fAthlètes = new VueAllAthlètes();  // création de la fenêtre (Vue) qui permet de voir les chantiers

                fAthlètes.Ctrl = ctrl;  // initialisation du contrôleur de la fenêtre
                fAthlètes.getData();  // demande à la fenêtre fChantier d'obtenir les données
                fAthlètes.Visible = true;  // la fenêtre est visible - comparer avec fChantier.Show() ou ShowDialog()
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
