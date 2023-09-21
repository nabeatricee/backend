//o namespace é um nome em que usaremos para fazer referência quando usarmos 
namespace Sesi.Model
{
    //declarando a classe aluno
    public class Aluno
    {
        //declarando os atributos (propriedades) da classe Aluno
        public string nome { get; set; }
        public int idade { get; set; }
        public string turma { get; set; }

        //declarando um atributo privado
        public int nrFaltas{ get; set; }

        

        //criando um método
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {nome}, eu tenho {idade} anos e estudo na turma {turma} e tenho {nrFaltas} faltas");
            
        }
        public void AdicionarFaltas(int nr){
            Console.WriteLine($"O aluno {nome} faltou hoje e somou {nr}");
            nrFaltas = nrFaltas + nr;
        }

        //método ResumoFaltas
        public void ResumoFaltas(){
            Console.WriteLine($"O aluno {nome} tem {nrFaltas}");
        }
    }
}