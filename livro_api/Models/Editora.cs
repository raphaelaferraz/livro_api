using System.ComponentModel.DataAnnotations;

namespace livro_api.Models;

public class Editora
{
    // Propriedade obrigatória que define o Id da editora
    [Key]
    [Required]
    public int Id { get; set; }

    // Propriedade obrigatória que define o nome da editora
    [Required(ErrorMessage = "O nome da editora é obrigatório")]
    public string Nome { get; set; }
}
