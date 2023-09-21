//classe pai que será herdada - SuperClasse
class Animal
{
    public string cor { get; set; }
    public virtual void EmitirSom()
    {
        Console.WriteLine($"Animal da cor {cor} fazendo algum som");
    }
}

//Classe filha que herdará da classe animal
class Cachorro : Animal
{
    public override void EmitirSom()
    {
        Console.Write($"Cachorro da cor {cor} está latindo");
    }
}

class Gato : Animal
{


}

class Program{
    public static void Main(){
        Animal animalGenerico = new Animal();
        animalGenerico.cor = "preto";
        animalGenerico.EmitirSom();
        Cachorro meuCachorro = new Cachorro();
        meuCachorro.cor = "caramelo";
        meuCachorro.EmitirSom();
        //meuCachorro.Ronronar();  //ná posso chamar este método pois não existe nessa classe
        Gato meuGato = new Gato(); 
        meuGato.cor = "cinza";
        meuGato.EmitirSom();
        meuGato.Ronronar();
    }
}