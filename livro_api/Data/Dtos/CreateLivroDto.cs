using System.ComponentModel.DataAnnotations;

namespace livro_api.Data.Dtos;

public class CreateLivroDto
{
    // Propriedade obrigatória que define o título do livro
    [Required(ErrorMessage = "O título do livro é obrigatório")]
    public string Titulo { get; set; }

    // Propriedade obrigatória que define a quantidade de páginas do livro
    [Required(ErrorMessage = "A quantidade de páginas do livro é obrigatória")]
    public int QuantidadeDePaginas { get; set; }

    // Propriedade obrigatória que define o idioma do livro
    [Required(ErrorMessage = "O idioma do livro é obrigatório")]
    public string Idioma { get; set; }
}
