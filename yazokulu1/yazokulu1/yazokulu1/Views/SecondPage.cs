using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace yazokulu1.Views
{
    public class SecondPage : ContentPage
    {
        public SecondPage()
        {
            Content = new StackLayout
            {
                Children =
                {
                    new Label
                    {
                        Text = "Yaz Okulu - SecondPage",
                        FontSize = 48,
                        FontAttributes = FontAttributes.Bold
                    }
                }
            };
            
        }
    }
}
