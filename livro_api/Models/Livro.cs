using System.ComponentModel.DataAnnotations;

namespace livro_api.Models;

public class Livro
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required(ErrorMessage = "O título do livro é obrigatório")]
    public string Titulo { get; set; }

    [Required(ErrorMessage = "A quantidade de páginas do livro é obrigatória")]
    public int QuantidadeDePaginas { get; set; }

    [Required(ErrorMessage = "O idioma do livro é obrigatório")]
    public string Idioma { get; set; }
}
