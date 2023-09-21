Console.WriteLine("Digite o nome do aluno:");
string aluno = Console.ReadLine();

Console.WriteLine("Digite a nota 1:");
int nota1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a nota 2:");
int nota2 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a nota 3:");
int nota3 = int.Parse(Console.ReadLine());

int media = (nota1 + nota2 + nota3 )/ 3;

if(media > 7){
    Console.WriteLine($"{aluno} Aprovado(a)!");
} else{
    Console.WriteLine($"{aluno} Reprovado(a) X");
}
