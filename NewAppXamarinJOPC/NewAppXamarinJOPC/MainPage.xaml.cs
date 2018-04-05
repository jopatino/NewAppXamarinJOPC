using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NewAppXamarinJOPC
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            this.btnEnviar.Clicked += BtnEnviar_Clicked;
		}

        private void BtnEnviar_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Mensaje", "Evento desde el codebehind", "Aceptar");
        }

        private void btn_Clicked (Object sender, EventArgs e)
        {
            DisplayAlert("Mensaje","Perro Canequero", "Aceptar");
        }
	}
}
