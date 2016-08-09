using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace yazokulu1.Views
{
    public class MyTabbedPage : TabbedPage
    {
        public MyTabbedPage()
        {
            Children.Add(new MyCarouselPage());
            Children.Add(new YazOkuluSayfa2());
        }
    }
}
