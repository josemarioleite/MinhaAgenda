using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MinhaAgenda.Paginas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Menu : ContentPage
	{
		public Menu ()
		{
			InitializeComponent ();
		}

        //public void VagasCadastro(object sender, EventArgs args)
        //{

        //    Navigation.PushAsync(new CadastroVagas());
        //}

        private async void VagasCadastro(object sender, EventArgs args)
        {
            await App.NavigateMaster(new CadastroVagas());
        }

        //public void TodasMinhasVagas(object sender, EventArgs args)
        //{
        //    Navigation.PushAsync(new MinhasVagasCadastradas());
        //}

        private async void TodasMinhasVagas(object sender, EventArgs args)
        {
            await App.NavigateMaster(new MinhasVagasCadastradas());
        }
    }
}