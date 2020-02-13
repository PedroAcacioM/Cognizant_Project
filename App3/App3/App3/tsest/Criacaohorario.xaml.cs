using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class Criacaohorario : ContentPage
    {
        public Criacaohorario()
        {
            InitializeComponent();
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
                {
                    Device.BeginInvokeOnMainThread(() =>
                    {
                        hora.Text = DateTime.Now.ToString("HH:mm:ss");
                    });
                    return true;
                });
        }

        private void Entrar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MenuDetail());
        }

        private void Saida_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new Menu());
        }

    }
}