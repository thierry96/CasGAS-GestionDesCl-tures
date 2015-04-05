using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace casGSB
{
    /// <summary>
    /// Class ConnexionBD.
    /// </summary>
    class ConnexionBD
    {
        private MySqlConnection connexion;
        /// <summary>
        /// Initialise la connexion à la base de données
        /// </summary>
        public void initConnexion()
        {
            String connexionString = "SERVER=localhost;DATABASE=kephrem0_gsb;UID=kephrem0; PASSWORD=bahena2013";
            this.connexion = new MySqlConnection(connexionString);
        }

        /// <summary>
        /// Constructeur de la classe ConnexionBD
        /// </summary>
        public  ConnexionBD()
        {
            this.initConnexion();
        }
        /// <summary>
        /// Cette fonction permet de faire des requêtes d'administration vers la base de données.
        /// </summary>
        /// <param name="req">Contiendra la requête sql qui sera utilisé.</param>
        public void reqAdmin(string req)
        {
            this.connexion.Open();
            MySqlCommand cmd = this.connexion.CreateCommand();
            cmd.CommandText =  req ;
            cmd.ExecuteNonQuery();
            this.connexion.Close();
        }
        /// <summary>
        /// Cette fonction permet de faire des requêtes d'interrogations vers la base de données
        /// </summary>
        /// <param name="req">Contiendra la requête sql qui sera utilisé.</param>
        /// <returns>MySqlDataReader.</returns>
        public MySqlDataReader ReqSelect(String req)
        {
            this.connexion.Open();
            MySqlCommand cmd = new MySqlCommand(req, connexion);
            MySqlDataReader Dt = cmd.ExecuteReader();
            cmd.Dispose();
            this.connexion.Close();
            return Dt;
        }
    }
}
