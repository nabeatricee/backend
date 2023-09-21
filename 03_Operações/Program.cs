Console.WriteLine("Digite o valor de x:");
//Precisamos converter os dados que recebemos do ReadLine
//int.Parse() para converter para inteiro
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor de y:");
int y = int.Parse(Console.ReadLine());

//exemplos de operados aritméticos
int soma = x + y;
int subtração = x - y;
int multiplicação = x * y;
int divisão = x / y;
int resto = x % y;
int restoDiv2 = x % 2;

Console.WriteLine("Soma: " + soma);
Console.WriteLine("Subtração: " + subtração);
Console.WriteLine("Multiplicação: " + multiplicação);
Console.WriteLine("Divisão: " + divisão);
Console.WriteLine("Resto: " + resto);

if (restoDiv2 == 0)
{
    Console.WriteLine($"{x} é par");
}
else
{
    Console.WriteLine($"{x} é ímpar");
}

//operador temporário
//condição ? se verdade : senão
string ePar = (restoDiv2 == 0) ? " par " : "ímpar";

//Aprendendo Swith Case
int diaSemana = 4;
switch(diaSemana){
    case 1:
        Console.WriteLine("Hoje é Domingo!");
    break;
    case 2:
        Console.WriteLine("Hoje é Segunda!");
    break;
    case 3:
        Console.WriteLine("Hoje é Terça!");
    break;
    case 4:
        Console.WriteLine("Hoje é Quarta!");
    break;
    case 5:
        Console.WriteLine("Hoje é Quinta!");
    break;
    case 6:
        Console.WriteLine("Hoje é Sexta!");
    break;
    case 7:
        Console.WriteLine("Hoje é Sábado!");
    break;
    default:
        Console.WriteLine("Dia Inválido!");
        break;
}
