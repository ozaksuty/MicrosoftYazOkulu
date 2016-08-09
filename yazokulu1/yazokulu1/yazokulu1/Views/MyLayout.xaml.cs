using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace yazokulu1.Views
{
    public partial class MyLayout : ContentPage
    {
        public MyLayout()
        {
            InitializeComponent();

            AbsoluteLayout layout = new AbsoluteLayout();

            BoxView box1 = new BoxView();
            box1.BackgroundColor = Color.Red;

            layout.Children.Add(box1, 
                new Rectangle(50, 50, 100, 100));

            BoxView box2 = new BoxView();
            box2.BackgroundColor = Color.Blue;

            layout.Children.Add(box2, 
                new Rectangle(70, 70, 100, 100));

            Content = layout;
        }
    }
}
