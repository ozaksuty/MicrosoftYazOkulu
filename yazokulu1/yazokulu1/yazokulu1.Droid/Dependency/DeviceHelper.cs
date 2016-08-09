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
using yazokulu1.Dependency;
using yazokulu1.Droid.Dependency;

[assembly: Xamarin.Forms.Dependency(typeof(DeviceHelper))]
namespace yazokulu1.Droid.Dependency
{
    public class DeviceHelper : IDeviceHelper
    {
        public string GetDeviceName()
        {
            return "Android";
        }
    }
}