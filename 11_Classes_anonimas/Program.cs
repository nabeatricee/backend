public class Program
{
    public static void Main()
    {
        var pessoa1 = new
        {
            nome = "João",
            idade = 20
        };
        var pessoa2 = new
        {
            nome = "Maria",
            idade = 17
        };
        Console.WriteLine($"A pessoa 1 se chama {pessoa1.nome} e a pessoa 2 {pessoa2.nome}");

        Console.WriteLine("Digite a marca do carro");
        string marcaDigitado = Console.ReadLine();
        Console.WriteLine("Digite o modelo do carro");
        string modeloDigitado = Console.ReadLine();
        Console.WriteLine("Digite a cor do carro");
        string corDigitado = Console.ReadLine();

        var carro1 = new
        {
            marca = marcaDigitado,
            modelo = modeloDigitado,
            cor = corDigitado
        };

        Console.WriteLine($"O carro é da marca {carro1.marca}, modelo {carro1.modele} e sua cor é {carro1.cor}");

    }
}