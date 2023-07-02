using System.ComponentModel.DataAnnotations;

namespace livro_api.Models;

public class Autor
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required(ErrorMessage = "O nome do autor é obrigatório")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "A biografia do autor é obrigatória")]
    [StringLength(250, ErrorMessage = "A biografia pode ter apenas 250 caracteres")]
    public string Biografia { get; set; }
}
