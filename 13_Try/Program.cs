using System;
public class Program
{
    //o try serve para tratar um erro e não parar a execusão do programa 
    //se ocorrer qualqier erro dentro do bloco try, o sistema interrompe
    //a execução do bloco e vai para o catch 
    public static void Main()
    {
        try
        {
            Console.WriteLine($"Digite um número inteiro");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine($"Você digitou o nº{numero}");
        }
        catch (FormaEsception){
            Console.WriteLine("O número digitado é maior que o limite aceito");
        }
        //cath é o tratamento do erro, normalmente colocamos as mensagens de acordo 
        //com o tipo de erro, para melhor compreensão do usuário
        catch (Exception erro)
        {
            Console.WriteLine($"Ocorreu um erro: {erro}");
        }
        finally{
            Console.WriteLine($"No bloco finally o programa entra independentemente de exceção");
        }
    }
}