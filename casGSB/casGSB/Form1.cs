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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timAction_Tick(object sender, EventArgs e)
        {
            try{
            ConnexionBD cnxion = new ConnexionBD();
            cnxion.initConnexion();
            if ( casGSB.DateGsb.entre(1 , 10 , DateTime.Today) )
            {
                cnxion.reqAdmin("update fichefrais set idEtat = 'CL' where mois ='"+ casGSB.DateGsb.getYear(DateTime.Now)+ casGSB.DateGsb.getMoisPrecedent()+"'");
                MessageBox.Show("Fiche cloturée avec succès");
            }
            if (casGSB.DateGsb.entre(20, 31, DateTime.Today))
            {
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
