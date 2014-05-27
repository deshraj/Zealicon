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

namespace newZealicon
{
    public partial class COLORALO_EVENTS : PhoneApplicationPage
    {
        public COLORALO_EVENTS()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/eventDesc.xaml?name=LIVE WIRE", UriKind.Relative));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/eventDesc.xaml?name=FEST BIOSCOPE", UriKind.Relative));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/eventDesc.xaml?name='DANCE 141'", UriKind.Relative));
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/eventDesc.xaml?name='BURN THE FLOOR'", UriKind.Relative));
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/eventDesc.xaml?name='TWO TO TANGO'", UriKind.Relative));
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/eventsDesc.xaml?name='VOX POPULI'", UriKind.Relative));
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/eventsDesc.xaml?name='INGANIOUS JAMBOORIE'", UriKind.Relative));
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/eventsDesc.xaml?name='CONSONANCE'", UriKind.Relative));
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/eventsDesc.xaml?name='ALAAP'", UriKind.Relative));
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/eventsDesc.xaml?name='MOOKHIABHINAYA'", UriKind.Relative));
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/eventsDesc.xaml?name='MNM'", UriKind.Relative));
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/eventsDesc.xaml?name='PRATIBIMBA'", UriKind.Relative));
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/eventsDesc.xaml?name='HALLA BOL'", UriKind.Relative));
        }
    }
}