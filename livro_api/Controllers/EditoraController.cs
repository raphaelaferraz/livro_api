using AutoMapper;
using livro_api.Data.Dtos;
using livro_api.Data;
using livro_api.Models;
using Microsoft.AspNetCore.Mvc;

namespace livro_api.Controllers;

// Classe principal de Editora
[ApiController]
[Route("[controller]")]
public class EditoraController : ControllerBase
{
    // Campo privado que define o contexto de banco de dados
    private LivroContext _context;

    // Campo priavado que define as funcionalidades do AutoMapper
    private IMapper _mapper;

    // Construtor que define o contexto do banco de dados as funcionalidades do AutoMapper
    public EditoraController(LivroContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    // Método que adiciona uma editora no banco de dados 
    [HttpPost]
    public IActionResult AdicionaEditora(CreateEditoraDto editoraDto)
    {
        // Converte a editoraDto para o objeto classa principal Editora
        var editora = _mapper.Map<Editora>(editoraDto);

        // Adiciona a editora na tabela Editora do banco de dados
        _context.Editora.Add(editora);

        // Salva as alterações no banco de dados
        _context.SaveChanges();

        // Retorna o status code de criação e o endereço de criação da editora
        return CreatedAtAction(nameof(ExibeEditoraPorId), new { id = editora.Id }, editora);
    }

    // Método que exibe as editoras por ID
    [HttpGet("{id}")]
    public IActionResult ExibeEditoraPorId(int id)
    {
        // Armazena a editora encontrada no banco de dados de acordo com o ID
        var editora = _context.Editora.FirstOrDefault(editora => editora.Id == id);

        // Se a editora for nula, retorna o status code 404
        if (editora == null) return NotFound();

        // Se a editora for encontrada, converte para o objeto da classe de leitura (ReadEditoraDto)
        ReadEditoraDto editoraDto = _mapper.Map<ReadEditoraDto>(editora);

        // Retorna o status code 200 e a editora criada
        return Ok(editoraDto);
    }

    // Método que exibe todas as editoras criadas 
    [HttpGet]
    public IEnumerable<ReadEditoraDto> ExibeEditoras()
    {
        // Retorna o mapeamento dos objetos da entidade Editora convertidos para a classe básica de leitura (ReadEditoraDto)
        return _mapper.Map<List<ReadEditoraDto>>(_context.Editora.ToList());
    }
}
