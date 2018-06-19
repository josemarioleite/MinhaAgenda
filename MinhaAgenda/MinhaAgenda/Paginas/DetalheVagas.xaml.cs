using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using MinhaAgenda.Model;
using Xamarin.Forms.Xaml;

namespace MinhaAgenda.Paginas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetalheVagas : ContentPage
	{
		public DetalheVagas (Vagas vaga)
		{
			InitializeComponent ();

            BindingContext = vaga;
		}
	}
}