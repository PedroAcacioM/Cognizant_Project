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
	public partial class MenuDetail : ContentPage
	{
		public MenuDetail ()
		{
			InitializeComponent ();
		}
		private void Criar_Clicked_1(object sender, EventArgs e)
		{
			Navigation.PushAsync(new Criacaohorario());
		}

		private void Modificar_Clicked(object sender, EventArgs e)
		{
			Navigation.PushAsync(new modificaohorario());
		}

	}
}