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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculatrice
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double total = 0;
        string ope = "";
        bool calculLong = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnNumeric_Click(object sender, RoutedEventArgs e)
        {
            if (Affichage.Text=="0" || calculLong==true)
            {
                Affichage.Text = (string)((Button)sender).Content;
                AffichageComplet.Text += ((Button)sender).Content;
            }
            else
            {
                Affichage.Text += ((Button)sender).Content;
                AffichageComplet.Text += ((Button)sender).Content;
            }  
        }

        private void btnOperateur_Click(object sender, RoutedEventArgs e)
        {
            if (ope == "")
            {
                total = double.Parse(Affichage.Text);
                AffichageComplet.Text += ((Button)sender).Content;
                Affichage.Text = "0";
                switch (((Button)sender).Content)
                {
                    case "+":
                        ope = "+";
                        break;
                    case "-":
                        ope = "-";
                        break;
                    case "/":
                        ope = "/";
                        break;
                    case "*":
                        ope = "*";
                        break;
                    default:
                        break;
                }
            }
            else
            {
                calculLong = true;
                AffichageComplet.Text += ((Button)sender).Content;
                Calcul(false);
                ope = "";
            }
            

        }

        private void btnEgal_Click(object sender, RoutedEventArgs e)
        {
            Calcul(true);
        }

        private void Calcul(bool egal)
        {
            if (egal)
            {
                AffichageComplet.Text += "=";
            }

            switch (ope)
            {
                case "+":
                    total = total + double.Parse(Affichage.Text);
                    break;
                case "-":
                    total = total - double.Parse(Affichage.Text);
                    break;
                case "/":
                    total = total / double.Parse(Affichage.Text);
                    break;
                case "*":
                    total = total * double.Parse(Affichage.Text);
                    break;
                default:
                    break;
            }
            Affichage.Text = total.ToString();
        }
    }
}
