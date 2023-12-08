using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _17_CRUD.Models
{
    public class Tarefa
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public bool Concluida { get; set; }
    }
}