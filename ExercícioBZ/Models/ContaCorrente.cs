namespace Models
{
    public class ContaCorrente
    {
        public string titular { get; set; }
        public decimal saldo { get; set; }

        public ContaCorrente(string titular, int saldo)
        {
            this.titular = titular;
            this.saldo = saldo;
        }

        public void ConsultarSaldo()
        {

            Console.WriteLine($"{titular}, o seu saldo é de R${saldo}.");

        }
        public void Depositar(decimal valor)
        {
            saldo += valor;
        }
        public void Sacar(decimal valor)
        {
            if (valor <= 0 || valor > saldo)
            {
                Console.WriteLine($"Não é possível sacar este valor");
            }
            else
            {
                saldo -= valor;
                Console.WriteLine($"Seu saldo é de R${saldo}");
            }
            
        }
    }
}