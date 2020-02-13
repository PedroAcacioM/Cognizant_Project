using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            Detail = new NavigationPage(new MenuDetail());
        }


        private void GoPage1(object sender, System.EventArgs e)
        {
            Detail.Navigation.PushAsync(new Page1());
            IsPresented = false;
        }
        private void GoPage2(object sender, System.EventArgs e)
        {
            Detail.Navigation.PushAsync(new Sobre());
            IsPresented = false;
        }
        private void GoPage3(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new teste1());
            IsPresented = false;
        }
       
    }
}
