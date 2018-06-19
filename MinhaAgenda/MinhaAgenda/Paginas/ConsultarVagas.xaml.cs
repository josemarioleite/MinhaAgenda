using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MinhaAgenda.Model;
using MinhaAgenda.Banco;

namespace MinhaAgenda.Paginas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ConsultarVagas : ContentPage
	{

        List<Vagas> Lists { get; set; }

		public ConsultarVagas ()
		{
			InitializeComponent ();

            BancoDB database = new BancoDB();
            Lists = database.Consultar();
            LISTVagas.ItemsSource = Lists;

            lblCount.Text = Lists.Count.ToString();
		}


        public void MaisDetalhesAction (object sender, EventArgs args)
        {
     
            Label lblDetalhe = (Label)sender;
            TapGestureRecognizer tapGest = (TapGestureRecognizer)lblDetalhe.GestureRecognizers[0];
            Vagas vaga = tapGest.CommandParameter as Vagas;


            Navigation.PushAsync(new DetalheVagas(vaga));
        }

        public void PesquisarAction(object sender, TextChangedEventArgs args)
        {

            LISTVagas.ItemsSource = Lists.Where(a => a.NomeVaga.Contains(args.NewTextValue)).ToList();
        }
	}
}