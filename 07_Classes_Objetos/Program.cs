using Sesi.Model;

class Program
{
    public static void Main()
    {
        //criando ema variável aluno1 e instanciando da classe Aluno
        var aluno1 = new Aluno();
        aluno1.nome = "Ana";
        aluno1.idade = 16;
        aluno1.turma = "2º EM";

        //chamando o método da classe aluno
        aluno1.Apresentar();

        Aluno aluno2 = new Aluno();
        aluno2.nome = "Ricardo";
        aluno2.idade = 33;
        aluno2.turma = "3º EM";

        aluno2.Apresentar();
        aluno2.AdicionarFaltas(10);
        aluno2.Apresentar();

        //chamar método ResumoFaltas
        aluno2.ResumoFaltas();
    }
}