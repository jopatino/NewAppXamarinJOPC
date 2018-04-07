using System;
using System.Collections.Generic;
using System.Globalization;
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
            //this.btnEnviar.Clicked += BtnEnviar_Clicked;
            //this.dtpFechaInicial.DateSelected += DtpFechaInicial_DateSelected;
            //this.edDesc.Completed += EdDesc_Completed;
            //this.edDesc.TextChanged += EdDesc_TextChanged;
		}

        //private void EdDesc_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    DisplayAlert("Cambio de Texto", "Cambiando", "Aceptar");
        //}

        //private void EdDesc_Completed(object sender, EventArgs e)
        //{
        //    DisplayAlert("Completado", "Se ha cambiado el texto", "Ok");
        //}

        //private void DtpFechaInicial_DateSelected(object sender, DateChangedEventArgs e)
        //{
        //    CultureInfo culture = new CultureInfo("es-ES");
        //    DisplayAlert("Fecha", e.NewDate.ToString(), "Aceptar");
        //    DisplayAlert("Fecha", e.NewDate.ToString("D", culture), "Aceptar");
        //    CultureInfo cultureEn = new CultureInfo("en-US");
        //    DisplayAlert("Fecha", e.NewDate.ToString("D", cultureEn), "Aceptar");
        //}

        //private void BtnEnviar_Clicked(object sender, EventArgs e)
        //{
        //    DisplayAlert("Mensaje", "Evento desde el codebehind", "Aceptar");
        //}

        //private void btn_Clicked (Object sender, EventArgs e)
        //{
        //    DisplayAlert("Mensaje","Perro Canequero", "Aceptar");
        //}
	}
}
