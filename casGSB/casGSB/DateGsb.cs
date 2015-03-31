// ***********************************************************************
// Assembly         : casGSB
// Author           : Sam thierry
// Created          : 03-30-2015
//
// Last Modified By : Sam thierry
// Last Modified On : 04-04-2015
// ***********************************************************************
// <copyright file="DateGsb.cs" company="">
//     Copyright ©  2015
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// The casGSB namespace.
/// </summary>
namespace casGSB
{
    /// <summary>
    /// Class DateGsb.
    /// </summary>
    class DateGsb
    {
        /// <summary>
        /// Cette fonction permet de faire des opérations sur la date passée en paramètre
        /// Elle retourne le mois sous forme de deux chiffres
        /// </summary>
        /// <param name="tme">l'heure au format dateTime</param>
        /// <param name="value">La valeur.</param>
        /// <returns>mois.</returns>
        private static String opDate(DateTime tme,int value)
        {
            tme = tme.AddMonths(value);
            String mois = tme.ToString("MM");
           // Console.WriteLine(mois);
            return mois;
        }

        /// <summary>
        /// Gets the mois precedent.
        /// Cette fonction retourne sous forme de 2 chiffres
        /// le numéro du mois précédent par rapport à la date actuelle
        /// </summary>
        /// <returns>String.</returns>
        public static String getMoisPrecedent()
        {
            //--- Appel à la fonction getMoisPrecedent qui attend une date en paramètre ----        
            return getMoisPrecedent (DateTime.Today);
           
        }
        /**
         * 
         * @param DateTime tme
         * @return mois
         */
        /// <summary>
        /// Gets the mois precedent.
        /// Cette fonction est une surcharge de la fonction getMoisPrecedent()
        /// Elle retourne  sous forme de 2 chiffres
        /// le numéro du mois précédent en fonction de la date passeé en paramètre
        /// </summary>
        /// <param name="tme">The tme.</param>
        /// <returns>String.</returns>
        public static String getMoisPrecedent(DateTime tme)
        {  
            //---- Appel à la fonction opDate avec en paramètre la date passé dans la fonction. La valeur ici est -1  -----
          return opDate(tme,-1);
        }
        /// <summary>
        /// Cette fonction permet d'obtenir le numéro de l'année qui correspond au mois passé
        /// Gets the year.
        /// </summary>
        /// <param name="tme">L'heure.</param>
        /// <returns>year.</returns>
        public static String getYear(DateTime tme)
        {
            tme = tme.AddMonths(-1);
            String year = tme.ToString("yyyy");
            return year;
        }
        /// <summary>
        /// Gets the mois suivant.
        /// Cette fonction retourne le mois suivant sous forme de 2 chiffres
        /// par rapport au mois actuel
        /// </summary>
        /// <returns>String.</returns>
        public static String getMoisSuivant()
        {
           //---- Appel à la fonction getMoisSuivant qui attend une date en paramètre ---- 
            return getMoisSuivant (DateTime.Today);

        }
        /// <summary>
        /// Gets the mois suivant.
        /// Cette fonction est une surcharge de la fonction getMoisSuivant()
        /// Elle retourne le mois suivant sous forme de 2 chiffres par rapport au mois passé en paramètre
        /// </summary>
        /// <param name="tme">The tme.</param>
        /// <returns>String.</returns>
        public static  String getMoisSuivant(DateTime tme)
        {
            //----- Appel à la fonction opDate -------
            return opDate(tme,1);
        }

        /// <summary>
        /// Cette fonction retourne vrai si le numéro du jour actuel est comprise entre
        /// le numéro des deux jours passé en paramètre
        /// </summary>
        /// <param name="j1">Premier jour.</param>
        /// <param name="j2">Deuxième jour.</param>
        /// <returns>Boolean.</returns>
        public static Boolean entre(int j1 , int j2)
        { 
            //---- Appel à la fonction entre -------
            return entre(j1,j2,DateTime.Today) ;
        }
        /// <summary>
        /// Entres the specified j1.
        /// Cette fonction est une surcharge de la fonction entre()
        /// Elle retourne vrai si le numéro du jour de la date passé en paramètre est compris entre
        /// les deux valeurs passé en paramètre
        /// </summary>
        /// <param name="j1">The j1.</param>
        /// <param name="j2">The j2.</param>
        /// <param name="tme">The tme.</param>
        /// <returns>Boolean.</returns>
        public static Boolean entre(int j1 , int j2 , DateTime tme)
        {
            // récupération du numéro du jour
            int jour=tme.Day;
            // Si le jour récupéré est compris entre les deux jours on retourne vrai
            if ( jour >= j1 && jour <= j2 ) 
            {
                return true ;
            }
            return false ;
        }
    }
}
