using System.ComponentModel.DataAnnotations;

namespace livro_api.Models;

public class Editora
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required(ErrorMessage = "O nome da editora é obrigatório")]
    public string Nome { get; set; }
}
