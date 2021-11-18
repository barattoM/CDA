using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace Gestion_de_produits
{
    /// <summary>
    /// Logique d'interaction pour Actions.xaml
    /// </summary>
    public partial class Actions : Window
    {
        MainWindow Window;
        Produits Produit;
        public Actions(object sender, MainWindow window, Produits p)
        {
            InitializeComponent();
            this.Produit = p;
            this.Window = window;
            InitPage(sender);
        }

        private void InitPage(object sender)
        {
            string nom = (string) ((Button)sender).Content;
            labTitreAction.Content = nom + " un produit";
            
            switch (nom)
            {
                case "Ajouter":
                    //Button valider
                    btnValider.Click += (s,e) =>AjouterProduit();
                    break;
                case "Modifier":
                    //Id Produit
                    labIdProduit.Visibility = Visibility.Hidden;
                    txbIdProduit.Visibility = Visibility.Hidden;
                    //Libelle
                    txbLibelle.Text = Produit.Libelle;
                    //Rayon
                    txbRayon.Text = Produit.Rayon.ToString();
                    //Categorie
                    txbCategorie.Text = Produit.Categorie;
                    //Button valider
                    btnValider.Click += (s, e) => ModifierProduit();
                    break;
                case "Supprimer":
                    //Id Produit
                    txbIdProduit.Text = Produit.IdProduit.ToString();
                    txbIdProduit.IsEnabled = false;
                    //Libelle
                    txbLibelle.Text = Produit.Libelle;
                    txbLibelle.IsEnabled = false;
                    //Rayon
                    txbRayon.Text = Produit.Rayon.ToString();
                    txbRayon.IsEnabled = false;
                    //Categorie
                    txbCategorie.Text = Produit.Categorie;
                    txbCategorie.IsEnabled = false;
                    //Button valider
                    btnValider.Click += (s, e) => SupprimerProduit();
                    break;
                default:
                    break;
            }
        }


        private void AjouterProduit()
        {
            Produit = new Produits(int.Parse(txbIdProduit.Text),txbLibelle.Text,txbCategorie.Text,int.Parse(txbRayon.Text));
            //Ajout du nouveau produit
            this.Window.AjouterProduit(Produit);

            //Retour à la fenetre principale
            Retour();
        }

        private void SupprimerProduit()
        {
            //Ajout du nouveau produit
            this.Window.SupprimerProduit(Produit);

            //Retour à la fenetre principale
            Retour();
        }

        private void ModifierProduit()
        {
            Produit.Libelle = txbLibelle.Text;
            Produit.Rayon = int.Parse(txbRayon.Text);
            Produit.Categorie = txbCategorie.Text;
            //Ajout du nouveau produit
            this.Window.ModifierProduit(Produit);

            //Retour à la fenetre principale
            Retour();
        }

        public void Retour(object sender, RoutedEventArgs e)
        {    
           this.Close();
        }

        public void Retour()
        { 
            this.Close();
        }

    }
}
