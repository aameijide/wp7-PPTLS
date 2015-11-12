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

using System.Globalization;
using System.Threading;

using Microsoft.Phone.Shell;


namespace PPTLS
{
    public partial class MainPage : PhoneApplicationPage
    {
        int mWP=0;
        int mTU=0;

        // Constructor
        public MainPage()
        {
            InitializeComponent();

            marcadorWP.Text = mWP.ToString();
            marcadorTU.Text = mTU.ToString();
        }

        private void pedra_Click(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();

            int el = rand.Next(100);

            if (el <= 20) //Juga pedra
            {
                resultat.Text = AppResource.pedra_empat;
                resultat.Foreground = new SolidColorBrush(Colors.Yellow);
            }
            if (el> 20 && el <= 40) //Juga paper
            {
                resultat.Text = AppResource.paper_perd;
                resultat.Foreground = new SolidColorBrush(Colors.Red);
                mWP++;
            }
            if (el > 40 && el <= 60) //Juga tisores
            {
                resultat.Text = AppResource.tisora_guanya;
                resultat.Foreground = new SolidColorBrush(Colors.Green);
                mTU++;
            }
            if (el > 60 && el <= 80) //Juga llangardaix
            {
                resultat.Text = AppResource.llangardaix_guanya;
                resultat.Foreground = new SolidColorBrush(Colors.Green);
                mTU++;
            }
            if (el > 80 && el <= 100) //Juga Spock
            {
                resultat.Text = AppResource.spock_perd;
                resultat.Foreground = new SolidColorBrush(Colors.Red);
                mWP++;
            }
            marcadorWP.Text = mWP.ToString();
            marcadorTU.Text = mTU.ToString();
        }

        private void paper_Click(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();

            int el = rand.Next(100);

            if (el <= 20) //Juga pedra
            {
                resultat.Text = AppResource.pedra_guanya;
                resultat.Foreground = new SolidColorBrush(Colors.Green);
                mTU++;
            }
            if (el > 20 && el <= 40) //Juga paper
            {
                resultat.Text = AppResource.paper_empat;
                resultat.Foreground = new SolidColorBrush(Colors.Yellow);
            }
            if (el > 40 && el <= 60) //Juga tisores
            {
                resultat.Text = AppResource.tisora_perd;
                resultat.Foreground = new SolidColorBrush(Colors.Red);
                mWP++;
            }
            if (el > 60 && el <= 80) //Juga llangardaix
            {
                resultat.Text = AppResource.llangardaix_perd;
                resultat.Foreground = new SolidColorBrush(Colors.Red);
                mWP++;
            }
            if (el > 80 && el <= 100) //Juga Spock
            {
                resultat.Text = AppResource.spock_guanya;
                resultat.Foreground = new SolidColorBrush(Colors.Green);
                mTU++;
            }
            marcadorWP.Text = mWP.ToString();
            marcadorTU.Text = mTU.ToString();
        }

        private void tisora_Click(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();

            int el = rand.Next(100);

            if (el <= 20) //Juga pedra
            {
                resultat.Text = AppResource.pedra_perd;
                resultat.Foreground = new SolidColorBrush(Colors.Red);
                mWP++;
            }
            if (el > 20 && el <= 40) //Juga paper
            {
                resultat.Text = AppResource.paper_guanya;
                resultat.Foreground = new SolidColorBrush(Colors.Green);
                mTU++;
            }
            if (el > 40 && el <= 60) //Juga tisores
            {
                resultat.Text = AppResource.tisora_empat;
                resultat.Foreground = new SolidColorBrush(Colors.Yellow);
            }
            if (el > 60 && el <= 80) //Juga llangardaix
            {
                resultat.Text = AppResource.llangardaix_guanya;
                resultat.Foreground = new SolidColorBrush(Colors.Green);
                mTU++;
            }
            if (el > 80 && el <= 100) //Juga Spock
            {
                resultat.Text = AppResource.spock_perd;
                resultat.Foreground = new SolidColorBrush(Colors.Red);
                mWP++;
            }
            marcadorWP.Text = mWP.ToString();
            marcadorTU.Text = mTU.ToString();
        }

        private void llangardaix_Click(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();

            int el = rand.Next(100);

            if (el <= 20) //Juga pedra
            {
                resultat.Text = AppResource.pedra_perd;
                resultat.Foreground = new SolidColorBrush(Colors.Red);
                mWP++;
            }
            if (el > 20 && el <= 40) //Juga paper
            {
                resultat.Text = AppResource.paper_guanya;
                resultat.Foreground = new SolidColorBrush(Colors.Green);
                mTU++;
            }
            if (el > 40 && el <= 60) //Juga tisores
            {
                resultat.Text = AppResource.tisora_perd;
                resultat.Foreground = new SolidColorBrush(Colors.Red);
                mWP++;
            }
            if (el > 60 && el <= 80) //Juga llangardaix
            {
                resultat.Text = AppResource.llangardaix_empat;
                resultat.Foreground = new SolidColorBrush(Colors.Yellow);
            }
            if (el > 80 && el <= 100) //Juga Spock
            {
                resultat.Text = AppResource.spock_guanya;
                resultat.Foreground = new SolidColorBrush(Colors.Green);
                mTU++;
            }
            marcadorWP.Text = mWP.ToString();
            marcadorTU.Text = mTU.ToString();
        }

        private void spock_Click(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();

            int el = rand.Next(100);

            if (el <= 20) //Juga pedra
            {
                resultat.Text = AppResource.pedra_guanya;
                resultat.Foreground = new SolidColorBrush(Colors.Green);
                mTU++;
            }
            if (el > 20 && el <= 40) //Juga paper
            {
                resultat.Text = AppResource.paper_perd;
                resultat.Foreground = new SolidColorBrush(Colors.Red);
                mWP++;
            }
            if (el > 40 && el <= 60) //Juga tisores
            {
                resultat.Text = AppResource.tisora_guanya;
                resultat.Foreground = new SolidColorBrush(Colors.Green);
                mTU++;
            }
            if (el > 60 && el <= 80) //Juga llangardaix
            {
                resultat.Text = AppResource.llangardaix_perd;
                resultat.Foreground = new SolidColorBrush(Colors.Red);
                mWP++;
            }
            if (el > 80 && el <= 100) //Juga Spock
            {
                resultat.Text = AppResource.spock_empat;
                resultat.Foreground = new SolidColorBrush(Colors.Yellow);
            }
            marcadorWP.Text = mWP.ToString();
            marcadorTU.Text = mTU.ToString();
        }

        private void Lang_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            string select = (sender as ListBox).SelectedIndex.ToString();
            String Lang = " ";
            CultureInfo ci;

            //determine what culture is selected from UI
            //http://msdn.microsoft.com/en-us/library/system.globalization.cultureinfo%28v=vs.95%29.aspx
            switch (select)
            {
                case "0":
                    Lang = "ca";
                    break;
                case "1":
                    Lang = "es-ES";
                    break;
                case "2":
                    Lang = "en-GB";
                    break;
                case "3":
                    Lang = "fr-FR";
                    break;
                case "4":
                    Lang = "de-DE";
                    break;

            }

            //Set application's current culture/langugae to UI selection
            ci = new CultureInfo(Lang);
            Thread.CurrentThread.CurrentUICulture = ci;

            //Update UI with new resource strings
            resultat.Text = AppResource.resultat;
            cap.Text = AppResource.idioma2;
            pedra.Text = AppResource.pedra;
            paper.Text = AppResource.paper;
            tisora.Text = AppResource.tisora;
            llangardaix.Text = AppResource.llangardaix;
            spock.Text = AppResource.spock;
            ApplicationTitle.Text = AppResource.idioma2;
            tornar.Content = AppResource.tornar;
            marcador.Text = AppResource.marcador;
        }

        private void idioma_Click(object sender, EventArgs e)
        {
            if (LangList.Visibility == Visibility.Visible) { LangList.Visibility = Visibility.Collapsed; } else { LangList.Visibility = Visibility.Visible; }
            if (tornar.Visibility == Visibility.Visible) { tornar.Visibility = Visibility.Collapsed; } else { tornar.Visibility = Visibility.Visible; }
            if (marcador.Visibility == Visibility.Visible) { marcador.Visibility = Visibility.Collapsed; } else { marcador.Visibility = Visibility.Visible; }
            if (pedra_button.Visibility == Visibility.Visible) { pedra_button.Visibility = Visibility.Collapsed; } else { pedra_button.Visibility = Visibility.Visible; }
            if (paper_button.Visibility == Visibility.Visible) { paper_button.Visibility = Visibility.Collapsed; } else { paper_button.Visibility = Visibility.Visible; }
            if (tisora_button.Visibility == Visibility.Visible) { tisora_button.Visibility = Visibility.Collapsed; } else { tisora_button.Visibility = Visibility.Visible; }
            if (llangardaix_button.Visibility == Visibility.Visible) { llangardaix_button.Visibility = Visibility.Collapsed; } else { llangardaix_button.Visibility = Visibility.Visible; }
            if (spock_button.Visibility == Visibility.Visible) { spock_button.Visibility = Visibility.Collapsed; } else { spock_button.Visibility = Visibility.Visible; }
            if (spock_button.Visibility == Visibility.Visible) { cap.Text = AppResource.titol; ApplicationTitle.Text = AppResource.titol; } else { cap.Text = AppResource.idioma2; ApplicationTitle.Text = AppResource.idioma2; }
            if (resultat.Visibility == Visibility.Visible) { resultat.Visibility = Visibility.Collapsed; } else { resultat.Visibility = Visibility.Visible; }
            if (marcadorWP.Visibility == Visibility.Visible) { marcadorWP.Visibility = Visibility.Collapsed; } else { marcadorWP.Visibility = Visibility.Visible; }
            if (marcadorTU.Visibility == Visibility.Visible) { marcadorTU.Visibility = Visibility.Collapsed; } else { marcadorTU.Visibility = Visibility.Visible; }
        }

        private void sobre_Click(object sender, EventArgs e)
        {
            MessageBox.Show(AppResource.copy);
        }
    }
}