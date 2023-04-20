using System;
using System.Collections.Generic;
using MediaTekDocuments.model;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MediaTekDocuments.controller;

namespace MediaTekDocuments.view
{
    public partial class FrmAlerteFinAbonnement : Form
    {
        private readonly BindingSource bdgAbonnementsAEcheance = new BindingSource();
        private readonly List<Abonnement> lesAbonnementsAEcheance = new List<Abonnement>();
        public FrmAlerteFinAbonnement(FrmMediatekController controller)
        {
            InitializeComponent();
            lesAbonnementsAEcheance = controller.GetAbonnementsEcheance();
            RemplirAbonnementsAEcheance(lesAbonnementsAEcheance);
        }

        /// <summary>
        /// Remplissage de la grille des abonnements qui se terminent
        /// </summary>
        /// <param name="lesAbonnementsAEcheance"></param>
        private void RemplirAbonnementsAEcheance(List<Abonnement> lesAbonnementsAEcheance)
        {
            bdgAbonnementsAEcheance.DataSource = lesAbonnementsAEcheance;
            dgvFinAbonnements.DataSource = bdgAbonnementsAEcheance;
            dgvFinAbonnements.Columns["dateCommande"].Visible = false;
            dgvFinAbonnements.Columns["montant"].Visible = false;
            dgvFinAbonnements.Columns["idRevue"].Visible = false;
            dgvFinAbonnements.Columns["id"].Visible = false;
            dgvFinAbonnements.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvFinAbonnements.Columns[0].HeaderCell.Value = "Date de fin d'abonnement";
            dgvFinAbonnements.Columns[1].HeaderCell.Value = "Titre";
        }

        /// <summary>
        /// Tri sur les colonnes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvAbonnementsAEcheance_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string titreColonne = dgvFinAbonnements.Columns[e.ColumnIndex].HeaderText;
            List<Abonnement> sortedList = new List<Abonnement>();
            switch (titreColonne)
            {
                case "Titre":
                    sortedList = lesAbonnementsAEcheance.OrderBy(o => o.Titre).ToList();
                    break;
                case "Date de fin d'abonnement":
                    sortedList = lesAbonnementsAEcheance.OrderBy(o => o.DateFinAbonnement).Reverse().ToList();
                    break;
            }
            RemplirAbonnementsAEcheance(sortedList);
        }

        /// <summary>
        /// Fermeture de la fenêtre d'alerte
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
