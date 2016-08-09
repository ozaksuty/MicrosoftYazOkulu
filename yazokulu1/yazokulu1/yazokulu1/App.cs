
using Xamarin.Forms;
using yazokulu1.Dependency;
using yazokulu1.Views;

namespace yazokulu1
{
    public class App : Application
    {
        public static string dbName { get; set; } = "yazokulu.db3";
        public App()
        {
            //string deviceName = 
            //    DependencyService.Get<IDeviceHelper>().
            //    GetDeviceName();
            MainPage = new NavigationPage(new DataBind());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
