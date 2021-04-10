using System.ComponentModel.DataAnnotations;

namespace testeWeb.Models
{
    public class Category{
        [Key]

        public int Id{get; set;}

        [Required(ErrorMessage = "Este capo é obrigatório")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter entre 3 e 0 caracters")]
        [MinLength(3, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]

        public string Title {get;set;}

    }
    
}