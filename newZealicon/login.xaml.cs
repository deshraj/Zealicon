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
    public partial class login : PhoneApplicationPage
    {
        public login()
        {
            InitializeComponent();

        }
        private void GetDetails(string id)
        {
            string address = "localhost:8080";
            string requestUri = "http://" + address + "/newZealicon/webService.php?user_id=" + id;
            Uri uri = new Uri(requestUri);
            productClient.OpenReadAsync(uri);
        }
    }
}