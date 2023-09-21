namespace Sesi.Models
{
    public class Animal
    {
        public int cor { get; set; }
        public int especie { get; set; }
        public int peso { get; set; }

        public void EmitirSom()
        {
            Console.WriteLine("Emitindo som");
        }
    }
}