using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace casGSB
{
    /// <summary>
    /// Class gsb.
    /// </summary>
    public partial class gsb : Form
    {
        /// <summary>
        /// constructeur de la classe gsb
        /// </summary>
        public gsb()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Handles the Load event of the gsb control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void gsb_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the Tick event of the timAction control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void timAct_Tick(object sender, EventArgs e)
        {
            try
            {
                //connexion à la base de données
                ConnexionBD cnxion = new ConnexionBD();
                cnxion.initConnexion();
                // condition pour savoir si l'on est entre le 1 et le 10 jour du mois
                if (casGSB.DateGsb.entre(1, 10, DateTime.Today))
                {
                    // exécution d'un requête d'administration qui clôture tous les fiches du mois passé
                    cnxion.reqAdmin("update fichefrais set idEtat = 'CL' where mois ='" + casGSB.DateGsb.getYear(DateTime.Now) + casGSB.DateGsb.getMoisPrecedent() + "'");
                    MessageBox.Show("Fiche cloturée avec succès");
                }
                if (casGSB.DateGsb.entre(20, 31, DateTime.Today))
                {
                    // exécution d'un requête d'administration qui met à l'état remboursée tous les fiches validée du mois passé
                    cnxion.reqAdmin("update fichefrais set idEtat = 'RB' where mois ='" + casGSB.DateGsb.getYear(DateTime.Now) + casGSB.DateGsb.getMoisPrecedent() + "' And idEtat ='VA'");
                    MessageBox.Show("Remboursement effectué avec succès");
                }
            }
            catch (System.IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
