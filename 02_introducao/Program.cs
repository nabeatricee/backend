//somente declaramos a variável inteira e não atribuimos valor 
int num1;

//declarando uma variável do tipo inteira e atribuindo o valor 5
int num2 = 5;

//declarando uma variável do tipo string 
string nomeAluno;

//variável do tipo lógico (verdadeiro ou falso)
bool resultado = true;

//variável do tipo valor com casas decimais - para valores mais precisos 
double coordenada = 1.80;

//variável do tipo decimal - mais usada para valores monetários
decimal valor = 1.80M;

int idade = 16;
string nome = "Beatriz";
Console.WriteLine($" Meu nome é {nome} e tenho {idade} anos");

Console.WriteLine("Em que cidade você nasceu?");
//recebendo uma informação do usuário e atribuindo na variável cidade 
string cidade = Console.ReadLine();
Console.WriteLine($"Você nasceu em {cidade}");

int novaIdade = idade + 5;
int anoNascimento = 2023 - idade;
Console.WriteLine($"Você nasceu em {anoNascimento} e daqui 5 anos terá {novaIdade}");