using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using yazokulu1.CustomControls;
using yazokulu1.Droid.CustomControls;

[assembly: ExportRenderer(typeof(CustomEntry),
    typeof(CustomEntryRenderer))]
namespace yazokulu1.Droid.CustomControls
{
    public class CustomEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            Control.SetBackgroundColor(
                Android.Graphics.Color.Red);
            Control.SetTextColor(
                Android.Graphics.Color.White);
        }
    }
}