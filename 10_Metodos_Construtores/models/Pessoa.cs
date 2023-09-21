namespace Models
{
    public class Pessoa
    {
        //atributos da nossa classe Pessoa
        public string nome { get; set; }
        public int idade { get; set; }

        //Criando nosso método construtor
        public Pessoa(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }

        //Método da classe Pessoa
        public void Cantar()
        {
            Console.WriteLine($"{nome} está cantando");
        }
    }
}