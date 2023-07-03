using System.ComponentModel.DataAnnotations;

namespace livro_api.Data.Dtos;

public class ReadLivroDto
{
    // Propriedade obrigatória que define o título do livro
    public string Titulo { get; set; }

    // Propriedade obrigatória que define a quantidade de páginas do livro
    public int QuantidadeDePaginas { get; set; }

    // Propriedade obrigatória que define o idioma do livro
    public string Idioma { get; set; }
}
