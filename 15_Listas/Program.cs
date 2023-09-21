using System.Collections.Generic;
using Sesi.Models;
public class Program
{
    public static void Main()
    {
        //Criando uma lista de números inteiros 
        List<int> ListaNumeros = new List<int>();

        //Adicionando elementos á lista
        ListaNumeros.Add(10); //posição [0]
        ListaNumeros.Add(20); //posição [1]
        ListaNumeros.Add(45); //posição [2]

        Console.WriteLine($"Neste momento temos {ListaNumeros.Count} números");

        //acessando os dados da lista peld índice
        Console.WriteLine(ListaNumeros[1]);

        ListaNumeros.Add(6); //posição[3]
        Console.WriteLine($"Neste momento temos {ListaNumeros.Count} números");

        Console.WriteLine("-------------------------------------------------");

        List<string> ListaNomes = new List<string>();

        ListaNomes.Add("piupiu");
        ListaNomes.Add("gatinho");
        ListaNomes.Add("velhinha");

        foreach (string item in ListaNomes)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine($"Neste momento temos {ListaNomes.Count} nomes");
        Console.WriteLine(ListaNomes[2]);

        Console.WriteLine("-------------------------------------------------");

        //criando uma lista já atribuindo valores
        List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        numeros.Add(10);

        //Iterando sobre todos os itens da lista
        foreach (int item in numeros)
        {
            Console.WriteLine(item);
        }

        numeros.Remove(2);  //remove o elemento buscando pelo conteúdo
        numeros.RemoveAt(4);  //remove o elemento pela posição (índice)
        numeros.RemoveRange(2, 2);  //remove o elemento da posição 2 e os próximos 2

        foreach (int item in numeros)
        {
            Console.WriteLine(item);
        }

        //criando uma nova lista com objetos da classe alunos
        List<Aluno> listaAlunos = new List<Aluno>();

        //adicionando um novo aluno à listaAluno
        Aluno novoAluno = new Aluno("Marcos", 15);
        listaAlunos.Add(novoAluno);

        listaAlunos.Add(new Aluno("César", 17));
        listaAlunos.Add(new Aluno("Patrícia", 19));
        listaAlunos.Add(new Aluno("Carlos", 20));
        listaAlunos.Add(new Aluno("Alice", 12));
        
        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine("Lista de Alunos:");
        foreach (Aluno item in listaAlunos)
        {
            Console.WriteLine($"Nome Aluno: {item.nome}, idade {item.idade}");
        }

        //criando uma nova lista, filtrando e ordenando por nome 
        //LINQ utilizando Sintaxe de consulta
        var consulta = from aluno in listaAlunos
                       where aluno.idade > 18
                       orderby aluno.nome
                       select aluno;
        foreach (var item in consulta)
        {
            Console.WriteLine($"Nome aluno: {item.nome}, idade {item.idade}");
        }

        //LINQ utilizando Sintaxe do método
        var metodo = listaAlunos
                            .Where(aluno => aluno.idade < 18)
                            .OrderBy(aluno => aluno.nome);
        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine("Lista de alunos menores de 18 anos");
        foreach (var item in metodo)
        {
            Console.WriteLine($"Nome aluno: {item.nome}, idade {item.idade}");
        }
    }
}