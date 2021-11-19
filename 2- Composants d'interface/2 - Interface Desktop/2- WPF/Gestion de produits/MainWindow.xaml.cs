using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Gestion_de_produits
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Produits> liste;
        string path = @"../../Produits.json";

        public MainWindow()
        {
            InitializeComponent();
            //liste = CreerListe(); // Pour initialiser le jeu de données
            liste = TransformeJson();
            RemplirGrid();
            CreerFichier();
        }
        public void RemplirGrid()
        {
            dataProduit.ItemsSource = liste;
        }

        private List<Produits> CreerListe()
        {
            List<Produits> liste = new List<Produits>();

            for (int i = 1; i < 15; i++)
            {
                Produits p = new Produits(1, "Produit" + i, "Catégorie "+i,i+1);
                liste.Add(p);
            }
            return liste;
        }

        private void CreerFichier()
        {
            File.WriteAllText(path, JsonConvert.SerializeObject(liste, Formatting.Indented));
        }

        private string LireFichier()
        // Renvoi un tableau de chaine contenant les informations stockées dans le fichier 
        {
            string chaine;
            try
            {
                // Lecture et stockage dans chaine
                chaine = File.ReadAllText(path);
            }
            catch (Exception e)
            {
                Console.WriteLine("Une exception s'est produite : " + e.Message);
                Console.WriteLine("Indiquer le path :");
                path = Console.ReadLine();
                chaine = LireFichier();
            }
            return chaine;
        }

        private List<Produits> TransformeJson()
        {
            string chaine = LireFichier();
            List<Produits> liste = JsonConvert.DeserializeObject<List<Produits>>(chaine);
            return liste;
        }

        private void btnActions_Click(object sender, RoutedEventArgs e)
        {
            Produits p = (Produits)dataProduit.SelectedItem;
            string nom = (string)((Button)sender).Content;
            if (p == null && ( nom=="Modifier" || nom== "Supprimer") )
            {
                MessageBox.Show("Pas de sélection");
            }
            else
            {
                Actions actions = new Actions(sender, this, p);
                this.Opacity = 0.7;
                actions.ShowDialog();
                this.Opacity = 1;
            }
            
        }

        public void AjouterProduit(Produits p)
        {
            liste.Add(p);
            ActualiserTableau();
        }

        public void ModifierProduit(Produits p)
        {
            int index=liste.FindIndex(x => x.IdProduit == p.IdProduit);
            this.liste[index]=p;
            ActualiserTableau();
        }

        public void SupprimerProduit(Produits p)
        {
            int index = liste.FindIndex(x => x.IdProduit == p.IdProduit);
            this.liste.RemoveAt(index);
            ActualiserTableau();
        }

        private void ActualiserTableau()
        {
            dataProduit.Items.Refresh();
            CreerFichier();
        }

    }
}
