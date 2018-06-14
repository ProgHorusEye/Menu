using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;//using pour le cryptage du mot de passe

namespace Menu
{
    public partial class identifie : Form
    {
        public identifie()
        {
            InitializeComponent();
        }

        internal static string prenom;//internal static permet la récupération de la valeur saisie dans une autre fenêtre (form)
        internal static StringBuilder mdp;//construction d'un stringbuilder pour stocker le bon mot de passe crypter
        internal static StringBuilder s; //construction d'un stringbuilder pour stocker le mot de passe saisie crypter

        /// <summary>
        ///Lors du clique sur le bouton valider de la fenêtre d'authentification 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Valide_Click(object sender, EventArgs e)
        {
            toSha256(motdepasse.Text);//Lance la méthode qui crypte le champs mot de passe saisie
            toSha256ivan();//Crypte le bon mot de passe
            

            if (Prenom.Text == string.Empty)//si le champs prénom est vide
                {
                   MessageBox.Show("Je crois que l'on t'a posé une question crétin", "Confirmation d'un trou'cul", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //j'envoie le message indiqué
                }

                else if (Prenom.Text != "Ivan")//sinon si le prénom saisie n'est pas Ivan
                {
                    MessageBox.Show("Essaye encore une fois trou du cul");//j'envoie le message suivant
                }

                else if (Prenom.Text == "Ivan" && mdp.ToString() != s.ToString())//sinon si si le prénom est Ivan mais que les mot de passe ne correspondent pas
                {
                MessageBox.Show("Mot de passe erroné");
                }

                else //if (Prenom.Text == "Ivan" && mdp.ToString() == s.ToString())//sinon
                {
                
                prenom = Prenom.Text;//je renvoi le prénom pour l'affichage
                Close();//je ferme la fenêtre

            }
                
        }

        /// <summary>
        /// Méthode pour crypter le contenu du mot de passe saisie
        /// </summary>
        /// <param name="_input"></param>
        /// <returns></returns>
        public static string toSha256(string _input)
        {

            s = new StringBuilder();//construction du string builder

            s.Clear();//vide s

            SHA256 _hash = SHA256Managed.Create();//crée un objet code appelé _hash
            byte[] inputTMP = _hash.ComputeHash(Encoding.UTF8.GetBytes(_input));//crée un tableau de byte temporaire pour récupérer le mot de passe crypté

            foreach (byte b in inputTMP)//parcours le tableau de byte pour le remplir
            {
                s.Append(b.ToString("x2"));//x2 est la clé de cryptage
            }
            
            return s.ToString();//il retourne S sous forme de chaîne de caractère
        }


        /// <summary>
        /// Crypte le mot de passe que je décide d'utiliser
        /// </summary>
        /// <returns></returns>
        public static string toSha256ivan()
        {
            //idem que le précédent sauf que je lui indique le texte à crypter
            mdp = new StringBuilder();
            
            SHA256 _hash = SHA256Managed.Create();
            byte[] inputTMP = _hash.ComputeHash(Encoding.UTF8.GetBytes("Ivan"));//entre " le texte à crypter
            foreach (byte b in inputTMP)
            {
                mdp.Append(b.ToString("x2"));
            }

            return mdp.ToString();
        }

        /// <summary>
        /// Lance la méthode valide si la touche entrée est appuyé et relâché
        /// dans la fonction keypress on est obligé de passer par Keychar car Keycode n'est pas dispo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Prenom_KeyPress(object sender, KeyPressEventArgs e)
        {

            //if (e.KeyChar == (char)Keys.Return)
            //{
            //    Valide_Click(sender, e);
            //}
        }

        /// <summary>
        /// lance la méthode si la touche est appuyé
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Prenom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)//je vérifie que la touche appuyé est bien la touche entrée
            {
                Valide_Click(sender, e);//Lance la fonction de validation
            }
        }

        /// <summary>
        /// Vérifie la saisie si un utilisateur tente de fermer la fenêtre de connexion en clique sur la croix ou autre sans avoir fait de saisie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (s==null)//si le champ mot de passe est vide
            {
                MessageBox.Show("Mange patouille");//Message à l'utilisateur
                e.Cancel = true;//annule l'évènement fermé
            }

            else if (Prenom.Text == string.Empty && s== null // sinon si prénom et le mot de passe est vide 
                || (Prenom.Text != "Ivan" && s != mdp))// que le prénom n'est pas bon et que le mot de passe ne correspond pas
                
            {
                MessageBox.Show("Je crois que l'on t'a posé une question crétin", "Confirmation d'un trou'cul", MessageBoxButtons.OK, MessageBoxIcon.Error);// message à l'utilisateur
                e.Cancel = true;//annule l'évènement fermé
            }
        }

        private void identifie_Load(object sender, EventArgs e)
        {

        }
    }
}
