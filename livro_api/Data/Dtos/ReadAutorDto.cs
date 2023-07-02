using System.ComponentModel.DataAnnotations;

namespace livro_api.Data.Dtos;

public class ReadAutorDto
{
    // Propriedade obrigatória que define o nome do autor
    public string Nome { get; set; }

    // Propriedade obrigatória que define a biografia do autor
    public string Biografia { get; set; }
}
