using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace MinhaAgenda.Model
{
    [Table("Vagas")]
    public class Vagas
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string NomeVaga { get; set; }
        public string Local { get; set; }
        public DateTime Data { get; set; }
        public TimeSpan Horas { get; set; }
        public string Descricao { get; set; }
        public string TipoDia { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
    }
}
