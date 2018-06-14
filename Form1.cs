using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class FrmMenu : Form
    {

        /* Pour créer une interface gérant plusieurs application il faut :
        * créer un windows form et cocher la propriété isMidcontainer
        * importer les projets ou créer les projets directement dedans
        * avoir le même Namespace sur tous les projets
        * instancier un objet de la classe du projet
        * ajouter le projet dans les références du projet menu
        * sur l'action clique sur le bouton, créer l'objet de la classe du projet
        * et le lancer !!!!!
        */
        
        public FrmMenu()
        {
            InitializeComponent();
        }

        bool statut = false;

        /// <summary>
        /// au lancement, demande l'identifiant et le mot de passe
        /// gére la barre de statut de l'interface
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMenu_Load(object sender, EventArgs e)
        {
            statututilisateur.Text = "Déconnecté";//affiche déconnecté
            DateTime jour = new DateTime();//récupère la date du jour
            jour = DateTime.Now;
            StringBuilder datejour = new StringBuilder();//reconstruit le format de date
            datejour.Append(jour.Day);
            datejour.Append("/");
            datejour.Append(jour.Month);
            datejour.Append("/");
            datejour.Append(jour.Year);
            

            LabelDate.Text=datejour.ToString();//affiche la date du jour en bas de l'interface

            sidentifierToolStripMenuItem_Click(sender, e);//lance la fonction de mot de passe
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void sidentifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (statut == false)//si status est faux alors l'utilisateur n'est pas connecté donc
            {
                identifie ident = new identifie();//je crée un objet avec la classe identifie
                ident.ShowDialog();//je lance l'identification
                //StringBuilder welcome = new StringBuilder();// Je construit la phrase de bienvenue
                //welcome.Append("Bonjour ");
                //welcome.Append(identifie.prenom);
                //welcome.Append(", bienvenue dans la matrice");
                //toolStripMenuItem1.Enabled = true;

                //MessageBox.Show(welcome.ToString());

                if (identifie.prenom != string.Empty)//si le champs prenom est vide
                {
                    StringBuilder connect = new StringBuilder();// je construit le texte
                    connect.Append(identifie.prenom);
                    connect.Append(" est connecté");
                    statututilisateur.Text = connect.ToString();//j'affiche dans la barre de statut
                    statut = true;//je passe le statut à vrai pour que la fenêtre de connection ne s'ouvre pas 2 fois
                }
            }

            else
            {
                MessageBox.Show("Vous êtes déjà connecté");//Message en cas de tentative de connexion alors qu'un utilisateur soit déjà connecté
            }
        }
        
        /// <summary>
        /// Gére le clique sur le menu quitter de l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult fermer = MessageBox.Show("Voulez vous vraiment quitter l'application ?", "Fermeture", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);//affiche une boite de message pour vérifier si on quitte
            if (fermer == DialogResult.No)
            {
                Close();//ferme la fenêtre
            }
        }

        /// <summary>
        /// Permet de lancer l'application bouton depuis le menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void boutonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bouton boutonbouge = new bouton();//crée une instance de l'application bouton appelé boutonbouge
            boutonbouge.MdiParent = this;//indique quel est le form mdi parent
            boutonbouge.Show();//Lance l'application dans le form mdi
        }

        int i = 1;//initialise une variable pour la calculette
        
        /// <summary>
        /// lance l'application calculette
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lancementCalculette_Click(object sender, EventArgs e)
        {
            calcul boutoncalcul = new calcul();//instance de ma classe calcul et donc de ma calculette
            boutoncalcul.MdiParent = this;//définit le form mdi parent
            boutoncalcul.Show();//lance l'application calculette
            boutoncalcul.Text = "Additionneur n°" + i;//Change le nom du form calculette en additionneur et numérote à chaque lancement
            i++;//incrémente le compteur
        }

        /// <summary>
        /// lance l'application de couleur de texte
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lancecouleurtexte_Click(object sender, EventArgs e)
        {
            couleurtexte boutoncoultext = new couleurtexte();
            boutoncoultext.MdiParent = this;
            boutoncoultext.Show();
        }

        /// <summary>
        /// Lance l'application pour les prénoms
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lancelistbox_Click(object sender, EventArgs e)
        {
            listbox boutonlistbox = new listbox();
            boutonlistbox.MdiParent = this;
            boutonlistbox.Show();
        }

        /// <summary>
        /// Lance l'application pour les pays
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lancelistcombo_Click(object sender, EventArgs e)
        {
            listcombo boutonlistcombo = new listcombo();
            boutonlistcombo.MdiParent = this;
            boutonlistcombo.Show();
        }

        /// <summary>
        /// lance l'application pour le positionnement de la souris
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lancesouris_Click(object sender, EventArgs e)
        {
            Box boutonbox = new Box();
            boutonbox.MdiParent = this;
            boutonbox.Show();
        }

        /// <summary>
        /// lance l'application de changement de couleur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lancemelcoul_Click(object sender, EventArgs e)
        {
            melcoul boutonmelcoul = new melcoul();
            boutonmelcoul.MdiParent = this;
            boutonmelcoul.Show();
        }

        /// <summary>
        /// Lance l'application de validation de texte
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lancevalidation_Click(object sender, EventArgs e)
        {
            validsaisie boutonvalidation = new validsaisie();
            boutonvalidation.MdiParent = this;
            boutonvalidation.Show();
        }

        /// <summary>
        /// Lance l'application de calcul d'emprunt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lanceemprunt_Click(object sender, EventArgs e)
        {
            calculemprunt boutonemprunt = new calculemprunt();
            boutonemprunt.MdiParent = this;
            boutonemprunt.Show();
        }

        /// <summary>
        /// Mets les fenêtres en cascade
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {   
                this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }

        /// <summary>
        /// Mets les fenêtres à l'horizontale
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void boutonho_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }

        /// <summary>
        /// Mets les fenêtres à la verticale
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bvertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
        }


        private void FrmMenu_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void fenetresToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Ferme toutes les applications ouvertes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fermerToutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int nb = MdiChildren.Count();//compte le nombre d'applications ouverte
            for (int i = 0; i < nb; i++)//Boucle pour répéter l'opération autant de fois qu'il y a de d'appli ouverte
            {
                ActiveMdiChild.Close();//prends la fenêtre enfant ouverte et la ferme
            }

        }

        /// <summary>
        /// Gére la fermeture du formulaire principal par la croix en haut à droite
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            quitterToolStripMenuItem_Click(sender, e);//relance la fonction de vérification de fermeture par le bouton quitter
        }
        
    }
}
