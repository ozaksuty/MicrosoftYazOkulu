using System;
using System.Collections.Generic;
using System.Text;
using yazokulu1.Dependency;
using yazokulu1.iOS.Dependency;

[assembly: Xamarin.Forms.Dependency(typeof(DeviceHelper))]
namespace yazokulu1.iOS.Dependency
{
    public class DeviceHelper : IDeviceHelper
    {
        public string GetDeviceName()
        {
            return "iOS";
        }
    }
}
