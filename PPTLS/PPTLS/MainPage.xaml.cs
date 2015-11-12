using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace PPTLS
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void pedra_Checked(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();

            int el = rand.Next(100);

            if (el <= 20) //Juga pedra
            {
                resultat.Text = "Màquina juga pedra. Empat";
            }
            if (el> 20 && el <= 40) //Juga paper
            {
                resultat.Text = "Màquina juga paper. Perds";
            }
            if (el > 40 && el <= 60) //Juga tisores
            {
                resultat.Text = "Màquina juga tisora. Guanyes";
            }
            if (el > 60 && el <= 80) //Juga llangardaix
            {
                resultat.Text = "Màquina juga llangardaix. Guanyes";
            }
            if (el > 80 && el <= 100) //Juga Spock
            {
                resultat.Text = "Màquina juga Spock. Perds";
            }
        }

        private void paper_Checked(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();

            int el = rand.Next(100);

            if (el <= 20) //Juga pedra
            {
                resultat.Text = "Màquina juga pedra. Guanyes";
            }
            if (el > 20 && el <= 40) //Juga paper
            {
                resultat.Text = "Màquina juga paper. Empat";
            }
            if (el > 40 && el <= 60) //Juga tisores
            {
                resultat.Text = "Màquina juga tisora. Perds";
            }
            if (el > 60 && el <= 80) //Juga llangardaix
            {
                resultat.Text = "Màquina juga llangardaix. Perds";
            }
            if (el > 80 && el <= 100) //Juga Spock
            {
                resultat.Text = "Màquina juga Spock. Guanyes";
            }
        }

        private void tisora_Checked(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();

            int el = rand.Next(100);

            if (el <= 20) //Juga pedra
            {
                resultat.Text = "Màquina juga pedra. Perds";
            }
            if (el > 20 && el <= 40) //Juga paper
            {
                resultat.Text = "Màquina juga paper. Guanyes";
            }
            if (el > 40 && el <= 60) //Juga tisores
            {
                resultat.Text = "Màquina juga tisora. Empat";
            }
            if (el > 60 && el <= 80) //Juga llangardaix
            {
                resultat.Text = "Màquina juga llangardaix. Guanyes";
            }
            if (el > 80 && el <= 100) //Juga Spock
            {
                resultat.Text = "Màquina juga Spock. Perds";
            }
        }

        private void llangardaix_Checked(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();

            int el = rand.Next(100);

            if (el <= 20) //Juga pedra
            {
                resultat.Text = "Màquina juga pedra. Perds";
            }
            if (el > 20 && el <= 40) //Juga paper
            {
                resultat.Text = "Màquina juga paper. Guanyes";
            }
            if (el > 40 && el <= 60) //Juga tisores
            {
                resultat.Text = "Màquina juga tisora. Perds";
            }
            if (el > 60 && el <= 80) //Juga llangardaix
            {
                resultat.Text = "Màquina juga llangardaix. Empat";
            }
            if (el > 80 && el <= 100) //Juga Spock
            {
                resultat.Text = "Màquina juga Spock. Guanyes";
            }
        }

        private void spock_Checked(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();

            int el = rand.Next(100);

            if (el <= 20) //Juga pedra
            {
                resultat.Text = "Màquina juga pedra. Guanyes";
            }
            if (el > 20 && el <= 40) //Juga paper
            {
                resultat.Text = "Màquina juga paper. Perds";
            }
            if (el > 40 && el <= 60) //Juga tisores
            {
                resultat.Text = "Màquina juga tisora. Guanyes";
            }
            if (el > 60 && el <= 80) //Juga llangardaix
            {
                resultat.Text = "Màquina juga llangardaix. Perds";
            }
            if (el > 80 && el <= 100) //Juga Spock
            {
                resultat.Text = "Màquina juga Spock. Empat";
            }
        }
    }
}