using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace MinhaAgenda.Interface
{
    public interface ICaminho
    {
        string ObterCaminho(string NomeArquivoBanco);
    }
}
