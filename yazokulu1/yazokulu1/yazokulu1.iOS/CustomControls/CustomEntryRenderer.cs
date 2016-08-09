using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using yazokulu1.CustomControls;
using yazokulu1.iOS.CustomControls;

[assembly: ExportRenderer(typeof(CustomEntry),
    typeof(CustomEntryRenderer))]
namespace yazokulu1.iOS.CustomControls
{
    public class CustomEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            Control.BackgroundColor = UIKit.UIColor.Blue;

        }
    }
}
