using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using MinhaAgenda.Interface;
using UIKit;
using Xamarin.Forms;
using MinhaAgenda.Banco;
using System.IO;
using MinhaAgenda.iOS.Banco;

[assembly:Dependency(typeof(Caminho))]
namespace MinhaAgenda.iOS.Banco
{
    public class Caminho :ICaminho
    {
        public string ObterCaminho(string NomeArquivoBanco)
        {
            string caminhoDaPasta = System.Environment.GetFolderPath(System.Environment.Personal);

            string caminhoBiblioteca = Path.Combine(caminhoDaPasta, "..", "Library");

            string caminhoBanco = Path.Combine(caminhoBiblioteca, NomeArquivoBanco);

            return caminhoBanco;
        }
    }
}