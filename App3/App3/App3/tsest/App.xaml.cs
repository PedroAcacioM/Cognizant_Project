using App3;
using System;
using System.IO;
using Xamarin.Forms;

namespace App3
{
    public partial class App : Application
    {
        
        public App()
        {
            MainPage = new NavigationPage(new teste1());// new MainPage();
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