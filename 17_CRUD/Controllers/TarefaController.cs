
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using _17_CRUD.Models;

namespace _17_CRUD.Controllers
{
    //criando a classe TarefaController e herdando seus métodos de controller
    public class TarefaController : Controller
    {
        //criando um objeto_tarefas que armazenará uma lista de tarefas 
        private static List<Tarefa> _tarefas = new List<Tarefa>();
        public IActionResult Index()
        {
            return View(_tarefas);
        }
        public IActionResult Adicionar()
        {
            return View();
        }
    }
}