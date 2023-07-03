using System.ComponentModel.DataAnnotations;

namespace livro_api.Data.Dtos;

public class CreateEditoraDto
{
    // Propriedade obrigatória que define o nome da editora
    [Required(ErrorMessage = "O nome da editora é obrigatório")]
    public string Nome { get; set; }
}
