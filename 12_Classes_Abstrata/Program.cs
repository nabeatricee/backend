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
    //Sobrescevendo O método EmitirSom

    public override void EmitirSom()
    {
        Console.WriteLine($"Gato da cor {cor} está miando! Miau Miau")
    }

    public void Ronronar()
    {
        Console.WriteLine("O gato está ronronando")
    }

}
//Filha que herdará a classe animal
class Cachorro : Animal 
class Gato : Animal 

class Program{
    /*
    //Não é permitido criar um objeto de uma classe abstrata 
    //Só conseguimos criar se sua classe derivada
    public static void Main(){
        Animal animalGenerico = new Animal();
        animalGenerico.cor = "preto";
        animalGenerico.EmitirSom();
        */

        Cachorro meuCachorro = new Cachorro();
        meuCachorro.cor = "caramelo";
        meuCachorro.EmitirSom();

        //meuCachorro.Ronronar();  //não posso chamar este método pois não existe nessa classe
        Gato meuGato = new Gato(); 
        meuGato.cor = "cinza";
        meuGato.EmitirSom();
        meuGato.Ronronar();
    }
    
}