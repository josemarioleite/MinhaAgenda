using MinhaAgenda.Paginas;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace MinhaAgenda
{
	public partial class App : Application
	{
        public static MasterDetailPage MasterPage { get; set; }

        public static async Task NavigateMaster (Page page)
        {
            App.MasterPage.IsPresented = false;
            await App.MasterPage.Detail.Navigation.PushAsync(page);
        }

		public App ()
		{
			InitializeComponent();

            //MainPage = new NavigationPage(new ConsultarVagas());
            MainPage = new MasterDetail();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
