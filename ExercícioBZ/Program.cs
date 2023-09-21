using Models;

class Program
{
    public static void Main()
    {
        Console.Clear();
        Console.WriteLine("------------------------------");
        Console.WriteLine("Bem-vindo a sua Conta Corrente");
        Console.WriteLine("------------------------------");

        Console.WriteLine("Digite o seu nome");
        string titular = Console.ReadLine();
        ContaCorrente contcorr1 = new ContaCorrente(titular, 0);



        string opcao = "";

        do
        {
            Console.WriteLine("--------------- M E N U ---------------");
            Console.WriteLine("1. Para consultar o saldo");
            Console.WriteLine("2. Para depositar seu valor");
            Console.WriteLine("3. Para sacar seu valor");
            Console.WriteLine("0. Para fechar sistemas");
            opcao = Console.ReadLine();
            Console.Clear();

            switch (opcao)
            {
                case "0":
                    Console.WriteLine("Obrigado(a), volte sempre! :)");
                    System.Threading.Thread.Sleep(2000);
                    break;
                case "1":
                    contcorr1.ConsultarSaldo();
                    break;
                case "2":
                    Console.WriteLine($"Digite o valor do depósito: ");
                    decimal valor = decimal.Parse(Console.ReadLine());
                    contcorr1.Depositar(valor);
                    break;
                case "3":
                    Console.WriteLine("Digite o valor do saque:");
                    contcorr1.Sacar(decimal.Parse(Console.ReadLine()));
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }

        } while (opcao != "0");
    }

}