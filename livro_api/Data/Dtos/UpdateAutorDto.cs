using System.ComponentModel.DataAnnotations;

namespace livro_api.Data.Dtos;

public class UpdateAutorDto
{
    // Propriedade obrigatória que define o nome do autor
    [Required(ErrorMessage = "O nome do autor é obrigatório")]
    public string Nome { get; set; }

    // Propriedade obrigatória que define a biografia do autor
    [Required(ErrorMessage = "A biografia do autor é obrigatória")]
    [StringLength(250, ErrorMessage = "A biografia pode ter apenas 250 caracteres")]
    public string Biografia { get; set; }
}
