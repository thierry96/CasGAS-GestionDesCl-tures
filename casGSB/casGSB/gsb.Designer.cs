namespace casGSB
{
    partial class gsb
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gsb));
            this.timAct = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timAct
            // 
            this.timAct.Enabled = true;
            this.timAct.Interval = 10000;
            this.timAct.Tick += new System.EventHandler(this.timAct_Tick);
            // 
            // gsb
            // 
            this.ClientSize = new System.Drawing.Size(355, 173);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "gsb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de clôture GSB";
            this.Load += new System.EventHandler(this.gsb_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timAct;
    }
}

