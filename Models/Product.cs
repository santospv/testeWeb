using System.ComponentModel.DataAnnotations;

namespace testeWeb.Models
{
    public class Product{
        [Key]

        public int Id{get; set;}

        [Required(ErrorMessage = "Este capo é obrigatório")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter entre 3 e 0 caracters")]
        [MinLength(3, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]

        public string Title {get;set;}

        [MaxLength(1024, ErrorMessage = "Este campo deve conter no maximo 1024 caracters")]

        public string Description {get;set;}

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Range(1, int.MaxValue, ErrorMessage = "O preço deve ser maior que zero")]
        
        public decimal Price {get; set;}

         public Category Category {get; set;}

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Range(1, int.MaxValue, ErrorMessage = "O preço deve ser maior que zero")]
        public int CategoryId {get; set;}
        

    }
    
}