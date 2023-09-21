using Models;

public class Program
{
    public static void Main()
    {
        //criar um objeto da classe Pessoa
        /*
        //Instanciando objeto sem método construtor 
        Pessoa pessoa1 = new Pessoa();
        pessoa1.nome = "Alberto";
        pessoa1.idade = 16;
        

        //Alternativa de um objeto instanciado sem construtor
        Pessoa pessoa1 = new Pessoa{
        nome = "Xauxau",
        idade = 28
        }
        */

        //Instanciando um objeto com o método construtor
         Pessoa pessoa1 = new Pessoa("Xuxa furacão", 60);

        //Chamando o método cantar da classe pessoa
        pessoa1.Cantar();

         Pessoa pessoa2 = new Pessoa("Sasha furacão", 23);
         pessoa2.Cantar();
         Pessoa pessoa3 = new Pessoa("Gaga furacão", 40);
         pessoa3.Cantar();
    }
}