using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.IO;
using Commande.Controleur;
using Commande.Modèle;


namespace Commande.Données
{
    class BD
    {
        private OleDbConnection _oleConnection;

        public BD()
        {
            string connString;
            string repCourant;

            repCourant = Directory.GetCurrentDirectory();  // répertoire de l'exécutable

            connString = @"Provider=Microsoft.ACE.OLEDB.12.0;"; // In computing, a connection string is a string that specifies information
            connString += @"Data Source=" + repCourant + @"/../../BD/Database1.accdb";  // about a data source and the means of connecting to it.
                                                                              

            //Instanciation de l'objet assurant la connexion à la BD
            _oleConnection = new OleDbConnection(connString);
            _oleConnection.Open();
        }

        public void CloseConnexionBD()
        {
            if (_oleConnection != null)
                _oleConnection.Close();
            _oleConnection = null;
        }

        private OleDbCommand ExecuteRequest(string req)
        {
            OleDbCommand cmd = new OleDbCommand(req, _oleConnection);
            return cmd;
        }

        public IDataReader ExecuteReaderRequest(string req)
        {
            OleDbCommand cmd = ExecuteRequest(req);
            return cmd.ExecuteReader();
        }

        public void ExecuteNonQueryRequest(string req)
        {
            OleDbCommand cmd = ExecuteRequest(req);
            cmd.ExecuteNonQuery();
        }

        public bool VerifLogin(string prénom, string nom)
        {
            string req = "SELECT * FROM Athlète WHERE Athlète_Prénom = '"+prénom+ "' AND Athlète_Nom = '" + nom + "'"; // la requête SQL est à stocker dans une String
            IDataReader reader = ExecuteReaderRequest(req);

            int count = 0;

            while (reader.Read())
            {
                count++;
            }
            reader.Close();

            if (count > 0)
                return true;
            else
                return false;
            
        }


        public List<Athlète> ObtientInfoAthlètes()  // Charge le contenu de la BD dans une List de Chantier
        {
            List<Athlète> listeAthlètes = new List<Athlète>();  // création d'une collection (List) vide de Chantier

            string req = "SELECT * FROM Athlète";  // la requête SQL est à stocker dans une String
            IDataReader reader = ExecuteReaderRequest(req);

            while (reader.Read())  // lecture de chaque tuple 1 par 1 (n tuples sont en résultat de la reqête SQL)
            {
                // champs : ID Prenom et nom, obtenus respectivement par reader.GetValue(0) et reader.GetValue(1) et reader.GetValue(2)
                listeAthlètes.Add(new Athlète(Convert.ToInt32(reader.GetValue(0)), Convert.ToString(reader.GetValue(1)),Convert.ToString(reader.GetValue(2))));
            }

            reader.Close();
            return listeAthlètes;
        }



    }
}
