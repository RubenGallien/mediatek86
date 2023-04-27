using MediaTekDocuments.controller;
using MediaTekDocuments.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaTekDocuments.view
{
    public partial class FrmAuthentification : Form
    {
        /// <summary>
        /// classe d'affichage de la fenetre d'authentification
        /// </summary>
        private FrmAuthentificationController controller;

        /// <summary>
        /// constructeur : création du controller lié à ce formulaire
        /// </summary>
        public FrmAuthentification()
        {
            InitializeComponent();
            this.controller = new FrmAuthentificationController();
        }

        /// <summary>
        /// Connexion à l'application en fonction de l'utilisateur et mdp saisis
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAuthentificationConnexion_Click(object sender, EventArgs e)
        {
            string utilisateur = txbAuthentificationUser.Text;
            string password = txbAuthentificationMdp.Text;

            if (!txbAuthentificationUser.Text.Equals("") && !txbAuthentificationMdp.Text.Equals(""))
            {
                if (!controller.GetUtilisateur(utilisateur, password))
                {
                    MessageBox.Show("Erreur d'authentification", "Alerte");
                    txbAuthentificationMdp.Text = "";
                }
                else if (Service.Libelle == "culture")
                {
                    MessageBox.Show("Vous n'avez pas les droits d'accès à l'application.", "Alerte");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Vous êtes connecté", "Information");
                    FrmMediatek frmMediatek = new FrmMediatek();
                    frmMediatek.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Tous les champs sont obligatoires");
            }
        }
    }
}
