class calma
{
    public static void Main()
    {
        Console.WriteLine("Digite um número para o dobro:");
        int nmr1 = int.Parse(Console.ReadLine());

        Dobro(nmr1);
        Metade(nmr1);

        Tabuada(nmr1);
        SomaComDoWhile();

    }
    public static void Dobro(int nmr1)
    {
        int multiplicação = nmr1 * 2;
        Console.WriteLine("Dobro: " + multiplicação);

    }

    public static void Metade(int nmr1)
    {
        int divisão = nmr1 / 2;
        Console.WriteLine("Metade: " + divisão);
    }

    public static void Tabuada(int nmr1){
        int cont = 1;

        while (cont <= 10){
            Console.WriteLine($"{nmr1} x {cont} = {cont * nmr1}");
            cont++;
        }
}

public static void SomaComDoWhile(){
    int maior = 0;
    int menor = 10000;
    int soma = 0;

    do{
        Console.WriteLine("Informe um número positivo, negativo para encerrar");
        int nmr1 = int.Parse(Console.ReadLine());

        if(nmr1 > maior)
        maior = nmr1;

        if(nmr1 < menor && nmr1 > 0)
        menor = nmr1;

        if(nmr1 > 0)
        soma = soma + nmr1;
    }while (nmr1 < 0);
    Console.WriteLine($"Menor nº {menor} - maior nº {maior} - soma dos nº {soma}");
}
}