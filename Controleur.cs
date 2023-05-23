using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Commande.Données;
using Commande.Modèle;

namespace Commande.Controleur
{
   public class Controleur
    {

        private BD _bd;

        public Controleur()
        {
            _bd = new BD();
        }

        public void ouvreBD()
        {
            if (_bd == null)
                _bd = new BD();
        }

        public void fermeBD()
        {
            if (_bd != null)
                _bd.CloseConnexionBD();
            _bd = null;
        }

        public List<Athlète> GetInfoAthlètes()
        {
            //if (_bd == null) return null;
            return _bd.ObtientInfoAthlètes();
        }
        
        public bool Login(string prénom, string nom)
        {
            return _bd.VerifLogin(prénom,nom);
        }
        
    }
}
