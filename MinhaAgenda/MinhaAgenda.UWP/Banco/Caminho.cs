using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using MinhaAgenda.Banco;
using MinhaAgenda.Interface;
using System.IO;
using Windows.Storage;
using MinhaAgenda.UWP.Banco;

[assembly:Dependency(typeof(Caminho))]
namespace MinhaAgenda.UWP.Banco
{
    public class Caminho : ICaminho
    {
        public string ObterCaminho(string NomeArquivoBanco)
        {
            string caminhoDaPasta = ApplicationData.Current.LocalFolder.Path;

            string caminhoBanco = Path.Combine(caminhoDaPasta, NomeArquivoBanco);

            return caminhoBanco;
        }
    }
}
