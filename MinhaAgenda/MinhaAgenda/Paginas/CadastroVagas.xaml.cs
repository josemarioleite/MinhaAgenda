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
	public partial class CadastroVagas : ContentPage
	{
		public CadastroVagas ()
		{
			InitializeComponent ();

            BindingContext = new Vagas();
		}

        public void SalvarAction (object sender, EventArgs args)
        {
           

                Vagas vaga = new Model.Vagas();
                vaga.NomeVaga = NomeVagaCad.Text;
                vaga.Local = LocalCad.Text;
                vaga.Data = DataCad.Date.Date;
                vaga.Horas = HorasCad.Time;
                vaga.Descricao = DescCad.Text;
                vaga.TipoDia = (TipoDia.IsToggled) ? "Dia" : "Noite";                      

                vaga.Email = EMAILCad.Text;                

                BancoDB database = new BancoDB();
                database.Cadastro(vaga);

                App.Current.MainPage.DisplayAlert("Atenção", "Agendado com sucesso!", "Ok");
                InitializeComponent();                
                Navigation.PushAsync(new ConsultarVagas());


        }
    }
}