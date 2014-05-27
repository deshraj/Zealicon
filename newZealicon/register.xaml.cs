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
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace newZealicon
{
    public partial class register : PhoneApplicationPage
    {
        public register()
        {
            InitializeComponent();
        }

        public class Details
        {
            public string events_id { get; set; }
            public string name { get; set; }
            public string email { get; set; }
            public string contact { get; set; }
            public string clgname { get; set; }
            public string branch { get; set; }
            public string password { get; set; }
            public string zealicon_id { get; set; }
            public string icard { get; set; }
            public string nib_10 { get; set; }
            public string nib_11 { get; set; }
        }

        void productClient_OpenReadCompleted(object sender, OpenReadCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show("An Error Occured");
                NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
            }
            // progressBar1.Visibility = Visibility.Collapsed;

            var serializer = new DataContractJsonSerializer(typeof(Details));
            var s = (Details)serializer.ReadObject(e.Result);
            if (string.IsNullOrWhiteSpace(s.events_id))
            {
                MessageBox.Show("ID Not Assigned");
                NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
            }
            string nam = s.name;
            string em = s.email;
            string contact = s.contact;
            string clg = s.clgname;
            string brnch = s.branch;
            string pwd = s.password;
            string zeal_id = s.zealicon_id;
            string icard = s.icard;
            string nib_10 = s.nib_10;
            string nib_11 = s.nib_11;
        }

        private void submit_Click(object sender, RoutedEventArgs e)
        {
     
        }
    }
}