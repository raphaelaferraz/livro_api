using AutoMapper;
using livro_api.Data.Dtos;
using livro_api.Data;
using livro_api.Models;
using Microsoft.AspNetCore.Mvc;

namespace livro_api.Controllers;

// Classe principal de Autor
[ApiController]
[Route("[controller]")]
public class AutorController
{
    // Campo privado que define o contexto do banco de dados
    private LivroContext _context;

    // Campo privado que define o funcionamento do AutoMapper
    private IMapper _mapper;

    // Construtor que define o contexto do banco de dados e o mapeamento do AutoMapper
    public AutorController(LivroContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    // Método que adiciona um autor no banco de dados
    [HttpPost]
    public IActionResult AdicionaAutor(CreateAutorDto autorDto)
    {
        // Converte o autorDto para um objeto da classe principal Autor
        var autor = _mapper.Map<Autor>(autorDto);

        // Adiciona o autor no banco de dados na tabela Autor
        _context.Autor.Add(autor);

        // Salva as alterações no banco de dados
        _context.SaveChanges();

        // Retorna o status code de criação e o endereço de acesso ao autor criado
        return CreatedAtAction(nameof(ExibeAutorPorId), new { id = autor.Id }, autor);
    }

    // Método que exibe os autores de acordo com o ID
    [HttpGet("{id}")]
    public IActionResult ExibeAutorPorId(int id)
    {
        // Armazena o autor encontrado no banco de dados de acordo com o ID passado
        var autor = _context.Autor.FirstOrDefault(autor => autor.Id == id);

        // Se o autor passado for nulo, retorna um status code 404
        if (autor == null) return NotFound();

        // Se o autor for encontrado, converte para o objeto de leitura (ReadAutorDto)
        ReadAutorDto autorDto = _mapper.Map<ReadAutorDto>(autor);

        // Retorna o status code 200 e o autor criado
        return Ok(autorDto);
    }

    // Método que exibe todos os autores
    [HttpGet]
    public IEnumerable<ReadAutorDto> ExibeAutores()
    {
        // Retorna o mapeamento dos objetos da entidade Autor mapeados para a classe básica de leitura (ReadAutorDto)
        return _mapper.Map<List<ReadAutorDto>>(_context.Autor.ToList());
    }
}
