using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace yazokulu1.Views
{
    public class MyMasterDetailPage : MasterDetailPage
    {
        public MyMasterDetailPage()
        {
            Detail = new NavigationPage(new MyTabbedPage());
            Master = new YazOkuluSayfa2();
        }
    }
}
