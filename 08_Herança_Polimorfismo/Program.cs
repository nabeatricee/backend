using Sesi.Models;

class Program
{
    public static void Main()
    {
        Gato meuGato = new Gato();
        meuGato.nome = "Gergilim";
        meuGato.cor = "Preto";
        meuGato.idade = "3 meses";
        meuGato.especie = "Gato-de-bengala";
        meuGato.genero = "Fêmea";
        meuGato.peso = 3;

        Peixe meuPeixe = new Peixe();
        meuPeixe.especie = "Tilápia";
        meuPeixe.nome = "Maria Clara";
        meuPeixe.cor = "Marrom";
        meuPeixe.tamanho = 0.10M;
        meuPeixe.peso = 0.100M;
    }
}