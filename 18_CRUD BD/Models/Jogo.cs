using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _18_CRUD_BD.Models
{
    //DataAnnotation de como será criado o nome na tabela do BD
    [Table("Jogos")]
    public class Jogo
    {
        [Key] //Falando para o BD que este atributo será uma chave
        public int JogoId {get; set;}
        [Required(ErrorMessage="Nome é obrigatório")]
        [Display(Name="Nome do jogo")]
        public int Nome {get; set;}
        public int Descricao {get; set;}
        public int Imagem {get; set;}
        public bool Ativo {get; set;}
    }
}