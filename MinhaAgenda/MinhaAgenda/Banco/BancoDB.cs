using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MinhaAgenda.Interface;
using MinhaAgenda.Model;
using SQLite;
using Xamarin.Forms;

namespace MinhaAgenda.Banco
{
   
    public class BancoDB
    {
        private SQLiteConnection _conexao;
        
        public BancoDB()
        {
            var dep = DependencyService.Get<ICaminho>();
            string caminho = dep.ObterCaminho("database.sqlite");

            _conexao = new SQLiteConnection(caminho);
            _conexao.CreateTable<Vagas>();
        }

        public List<Vagas> Consultar()
        {
          return  _conexao.Table<Vagas>().ToList();
        }

        public List<Vagas> Pesquisar(string palavra)
        {
            return _conexao.Table<Vagas>().Where(a=>a.NomeVaga.Contains(palavra)).ToList();
        }

        public Vagas ObterVagasPorId (int id)
        {
            return _conexao.Table<Vagas>().Where(a=>a.Id == id).FirstOrDefault() ;
        }

        public void Cadastro(Vagas vagas)
        {
            _conexao.Insert(vagas);
        }

        public void Atualizacao(Vagas vagas)
        {
            _conexao.Update(vagas);
        }

        public void Exclusao(Vagas vagas)
        {
            _conexao.Delete(vagas);
        }
    }
}
