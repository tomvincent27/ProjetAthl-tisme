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

namespace ProjetAthlétisme
{
    public partial class VueAllAthlètes : Form
    {

        private Controleur ctrl; 

        public VueAllAthlètes()
        {
            InitializeComponent();
        }

        public Controleur Ctrl
        {
            set
            {
                ctrl = value;
            }

            get
            {
                return ctrl;
            }
        }


        public void getData()
        {
            try
            {
                //bdsChantier.DataSource = ctrl.GetInfoChantier();
                //dataGridView1.DataSource = bdsChantier;

                dataGridView1.DataSource = ctrl.GetInfoAthlètes();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur : \n" + e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // throw e;   // Q : qu'est-ce que cette instruction produit ?
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
