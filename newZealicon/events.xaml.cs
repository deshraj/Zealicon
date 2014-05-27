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


namespace newZealicon
{
    public partial class events : PhoneApplicationPage
    {
        public events()
        {
            InitializeComponent();
        }

     

      

    }

    //void productClient_OpenReadCompleted(object sender, OpenReadCompletedEventArgs e)
    //    {
    //         if (e.Error != null)
    //        {
    //            MessageBox.Show("An Error Occured");
    //            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
    //        }
    //        // progressBar1.Visibility = Visibility.Collapsed;
             
    //        var serializer = new DataContractJsonSerializer(typeof(Details));
    //        var s = (Details)serializer.ReadObject(e.Result);
    //        if (string.IsNullOrWhiteSpace(s.events_id))
    //        {
    //            MessageBox.Show("ID Not Assigned");
    //            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
    //        }
    //        string nam = s.ename;
    //        string cat = s.category;
    //        string abo = s.about;
    //        string des = s.desc;
    //        string rul = s.rules;
    //        string 1pr = s.1prizes;
    //        string 2pr = s.2prizes;
    //        string 3pr = s.3prizes;
    //        string 1co = s.1contact;
    //        string 2co = s.2contact;
            

    //    }
    //    public class Details
    //    {
    //        public string events_id { get; set; }
    //        public string ename { get; set; }
    //        public string society { get; set; }
    //        public string category { get; set; }
    //        public string about { get; set; }
    //        public string desc { get; set; }
    //        public string rules { get; set; }
    //        public string 1prizes { get; set; }
    //        public string 2prizes { get; set; }
    //        public string 3prizes { get; set; }
    //        public string 1contact { get; set; }
    //        public string 2contact { get; set; }
    //        public int uploaded { get; set; }

    //    }
}