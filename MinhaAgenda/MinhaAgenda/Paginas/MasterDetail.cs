using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MinhaAgenda.Paginas
{
	public class MasterDetail : MasterDetailPage
	{
		public MasterDetail ()
		{

            this.Master = new Menu();
            this.Detail = new NavigationPage(new ConsultarVagas());
            App.MasterPage = this;
		}
	}
}