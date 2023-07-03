using System.ComponentModel.DataAnnotations;

namespace livro_api.Data.Dtos;

public class ReadEditoraDto
{
    // Propriedade obrigatória que define o nome da editora
    public string Nome { get; set; }
}
