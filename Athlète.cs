using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commande.Modèle
{
    public class Athlète  //pour athlète tri aie accès ?
    {
        //les données membres
        //private static int dernierNumero = 0;
        private string nom;
        private string prenom;
        private int idAthlete;
       // private DateTime dateNaissance;
        //private int tel;
        //private int taille;
        //private int poids;

        //CONSTRUCTEUR
        public Athlète(int idAthlete_, string prenom_,string nom_ )// DateTime dateNaissance_, int tel_, int taille_, int poids_)
        {
            nom = nom_;
            prenom = prenom_;
            idAthlete = idAthlete_;
            //dateNaissance = dateNaissance_;
            //tel = tel_;
            //taille = taille_;
            //poids = poids_;

        }
        public int IdAthlete
        {
            get { return idAthlete; }
        }
        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        

       

        /*
        public DateTime DateNaissance
        {
            get { return dateNaissance; }
            set { dateNaissance = value; }
        }
        public int Tel
        {
            get { return tel; }
            set { tel = value; }
        }
        public int Taille
        {
            get { return taille; }
            set { taille = value; }
        }
        public int Poids
        {
            get { return poids; }
            set { poids = value; }
        }
       */
    }

}
