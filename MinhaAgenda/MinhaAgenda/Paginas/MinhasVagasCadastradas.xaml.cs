using MinhaAgenda.Banco;
using MinhaAgenda.Model;
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
	public partial class MinhasVagasCadastradas : ContentPage
	{
        List<Vagas> Lists { get; set; }

        public MinhasVagasCadastradas ()
		{
			InitializeComponent ();
            ConsultarVagas();
        }

        private void ConsultarVagas()
        {
            BancoDB database = new BancoDB();
            Lists = database.Consultar();
            ListVagas.ItemsSource = Lists;

            lblCount.Text = Lists.Count.ToString();
            
        }
        public void EditarAction (object sender, EventArgs args)
        {

            Label lblEditar = (Label)sender;
            TapGestureRecognizer tapGest = (TapGestureRecognizer)lblEditar.GestureRecognizers[0];
            Vagas vaga = tapGest.CommandParameter as Vagas;

            BancoDB database = new BancoDB();


            Navigation.PushAsync(new EditarPagina(vaga));
            
        }

        public void ExcluirAction(object sender, EventArgs args)
        {
            Label lblExcluir = (Label)sender;
            TapGestureRecognizer tapGest = (TapGestureRecognizer)lblExcluir.GestureRecognizers[0];
            Vagas vaga = tapGest.CommandParameter as Vagas;

            BancoDB database = new BancoDB();
            database.Exclusao(vaga);
            
            App.Current.MainPage.DisplayAlert("Atenção", "Dados excluídos com sucesso", "Ok");
            InitializeComponent();
            Navigation.PushAsync(new ConsultarVagas());
            
        }

        public void PesquisarAction(object sender, TextChangedEventArgs args)
        {

            ListVagas.ItemsSource = Lists.Where(a => a.NomeVaga.Contains(args.NewTextValue)).ToList();
        }
    }
}