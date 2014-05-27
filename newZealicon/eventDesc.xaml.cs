using System;
using System.IO;
using System.Text;
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
using System.Runtime.Serialization.Json;
using Microsoft.Phone.Tasks;

namespace newZealicon
{
    public partial class eventDesc : PhoneApplicationPage
    {
        WebClient productClient;
        string name = "";
        public eventDesc()
        {
            InitializeComponent();

        }
        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            string querystringvalue = "";

            if (NavigationContext.QueryString.TryGetValue("name", out querystringvalue))
                name = querystringvalue;
            ttl.Title = name;
            productClient = new WebClient();
            productClient.OpenReadCompleted +=
            new OpenReadCompletedEventHandler(productClient_OpenReadCompleted);
            GetDetails(name);

        }

        private void GetDetails(string name)
        {
            //string address = "localhost";
            string requestUri = "http://localhost/1.php?ename=%27LIVE%20WIRE%27";
            Uri uri = new Uri(requestUri);
            productClient.OpenReadAsync(uri);
        }

        void productClient_OpenReadCompleted(object sender, OpenReadCompletedEventArgs e)
        {

            if (e.Error != null)
            {
                MessageBox.Show("An Error Occured");
               // NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
            }
            // progressBar1.Visibility = Visibility.Collapsed;

            var serializer = new DataContractJsonSerializer(typeof(Details));
            var s = (Details)serializer.ReadObject(e.Result);


            //string nam = s.ename;
            //string cat = s.category;
            //string abo = s.about;
            //string des = s.desc;
            //string rul = s.rules;
            //string pri1 = s.__invalid_name__1prizes;
            //string pri2 = s.__invalid_name__2prizes;
            //string pri3 = s.__invalid_name__3prizes;
            //string co1 = s.__invalid_name__1contact;
            //string co2 = s.__invalid_name__2contact;

            about.Text = s.events_id;
            //c1.Text = co1;
            //c2.Text = co2;
            //pr1.Text = pri1;
            //pr2.Text = pri2;
            //pr3.Text = pri3;
            //rule.Text = rul;
            //desc.Text = des;

        }
        public class Details
        {
            public string events_id { get; set; }
            //public string ename { get; set; }
            //public string society { get; set; }
            //public string category { get; set; }
            //public string about { get; set; }
            //public string desc { get; set; }
        //    public string rules { get; set; }
        //    public string __invalid_name__1prizes { get; set; }
        //    public string __invalid_name__2prizes { get; set; }
        //    public string __invalid_name__3prizes { get; set; }
        //    public string __invalid_name__1contact { get; set; }
        //    public string __invalid_name__2contact { get; set; }
        //    public string uploaded { get; set; }
        //
        }

    }
}