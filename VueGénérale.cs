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
    public partial class VueGénérale : Form
    {

        private Controleur controle;

        public VueGénérale()
        {
            InitializeComponent();
        }

        public Controleur Controle  // propriété set Contrôleur pour modifier la donnée membre privée controle
        {
            set
            {
                controle = value;
            }
        }

        private void FrmPrincipale_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string prénom = txtBoxPrénom.Text;
            string nom = txtBoxNom.Text;

            try
            {
                controle.ouvreBD();  // demande au contrôleur l'ouverture de la BD

                if (controle.Login(prénom, nom))
                {
                    VuePerso fVueperso = new VuePerso();  // création de la fenêtre (Vue) qui permet de voir les tarifs des produits
                    fVueperso.Ctrl = controle;
                    // fTarif.Show();
                    fVueperso.Visible = true;
                }
                else
                    MessageBox.Show("Utilisateur introuvable ! Enregistrez vous d'abord. ");

            }

            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }
        private void btnEnregistre_Click(object sender, EventArgs e)
        {
            try
            {
                VueEnregistrement fEnreg = new VueEnregistrement();  // création de la fenêtre (Vue) qui permet de voir les chantiers
                fEnreg.Visible = true;  // la fenêtre est visible - comparer avec fChantier.Show() ou ShowDialog()
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }


        }
        private void button2_Click(object sender, EventArgs e)
        {
            

        }

        
    }
}
