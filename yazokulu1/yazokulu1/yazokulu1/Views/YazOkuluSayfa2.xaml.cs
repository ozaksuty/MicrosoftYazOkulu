using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace yazokulu1.Views
{
    public partial class YazOkuluSayfa2 : ContentPage
    {
        public YazOkuluSayfa2()
        {
            InitializeComponent();
            Icon = "menu.png";
            lblText.Text = "2. SAYFA";
            lblText.FontSize = 48;

            RelativeLayout layout = new RelativeLayout();

            BoxView box1 = new BoxView();
            box1.BackgroundColor = Color.Red;

            layout.Children.Add(box1, Constraint.Constant(70),
                Constraint.Constant(100), Constraint.Constant(100),
                Constraint.Constant(100));

            BoxView box2 = new BoxView();
            box2.BackgroundColor = Color.White;
            box2.Opacity = 0.6;

            //layout.Children.Add(box2, Constraint.Constant(70),
            //    Constraint.Constant(90), Constraint.Constant(100),
            //    Constraint.Constant(100));

            layout.Children.Add(box2, 
                Constraint.RelativeToView(box1, 
                (yigit, gokhan) =>
            {
                return gokhan.X + 20;
            }), Constraint.RelativeToView(box1,
            (parent, sibling) =>
            {
                return sibling.Y + 20;
            }),
                Constraint.Constant(100),
                Constraint.Constant(100));

            BoxView box3 = new BoxView();
            box3.BackgroundColor = Color.Yellow;

            layout.Children.Add(box3, 
                Constraint.RelativeToParent((gokhan) =>
            {
                return gokhan.X;
            }), Constraint.Constant(0),
            Constraint.RelativeToParent((parent) =>
            {
                return parent.Width;
            }));

            Content = layout;
        }
    }
}
