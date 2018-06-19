using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MinhaAgenda.Banco;
using MinhaAgenda.Model;
using MinhaAgenda.Paginas;

namespace MinhaAgenda.Paginas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EditarPagina : ContentPage
	{
        private Vagas vaga { get; set; }

		public EditarPagina (Vagas vaga)
		{
			InitializeComponent ();
            this.vaga = vaga;

            NomeCadas.Text = vaga.NomeVaga;
            LocalCad.Text = vaga.Local;
            DataCad.Date = vaga.Data;
            DescriCad.Text = vaga.Descricao;
            TipoDia.IsToggled = (vaga.TipoDia == "Dia") ? false : true;
            TelefoneCadas.Text = vaga.Telefone;
            EMAILCadas.Text = vaga.Email;

        }

        public void SalvarAction(object sender, EventArgs args)
        {
            vaga.NomeVaga = NomeCadas.Text;
            vaga.Local = LocalCad.Text;
            vaga.Data = DataCad.Date;
            vaga.Descricao = DescriCad.Text;
            vaga.TipoDia = (TipoDia.IsToggled) ? "Noite" : "Dia";
            vaga.Email = EMAILCadas.Text;
            vaga.Telefone = TelefoneCadas.Text;

            BancoDB database = new BancoDB();
            database.Atualizacao(vaga);

            App.Current.MainPage.DisplayAlert("Mensagem", "Alterado com sucesso", "Ok");
            Navigation.PushAsync(new ConsultarVagas());

            InitializeComponent();

        }
	}
}