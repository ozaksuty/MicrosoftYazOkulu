using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using yazokulu1.CustomControls;

namespace yazokulu1.Views
{
    public partial class CustomPage : ContentPage
    {
        public CustomPage()
        {
            InitializeComponent();

            CustomEntry cEntry = new CustomEntry();
            Entry nEntry = new Entry();

            cEntry.Text = "Ben Custom Renderer ile Yazıldım";
            nEntry.Text = "Normal Entry";

            Content = new StackLayout
            {
                Children =
                {
                    cEntry,
                    nEntry
                }
            };
        }
    }
}
