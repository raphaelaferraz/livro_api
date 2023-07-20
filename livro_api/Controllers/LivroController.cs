using AutoMapper;
using livro_api.Data.Dtos;
using livro_api.Data;
using livro_api.Models;
using Microsoft.AspNetCore.Mvc;

namespace livro_api.Controllers;

// Classe principal de Editora
[ApiController]
[Route("[controller]")]
public class LivroController : ControllerBase
{
    // Campo privado que define o contexto do banco de dados
    private LivroContext _context;

    // Campo privado que define o funcionamento do AutoMapper
    private IMapper _mapper;

    // Construtor que define o contexto do banco de dados e o mapeamento do AutoMapper
    public LivroController(LivroContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    // Método que adiciona um livro no banco de dados
    [HttpPost]
    public IActionResult AdicionaLivro(CreateLivroDto livroDto)
    {
        // Convertendo o livroDto para a classe principal Livro
        var livro = _mapper.Map<Livro>(livroDto);

        // Adiciona o livro criado na tabela Livro do banco de dados
        _context.Livro.Add(livro);

        // Salva a alteração no banco de dados
        _context.SaveChanges();

        // Retorna o status code de criação e o endereço de acesso ao livro criado
        //return CreatedAtAction(nameof(ListaLivroPorId), new { autorId = livro.AutorId, editoraId = livro.EditoraId }, livro);
        return Ok(livro);
    }

    // Método que lista os livros de acordo com o ID
    [HttpGet("{id}")]
    public IActionResult ListaLivroPorId(int id)
    {
        // Armazena o livro que é encontrado no banco de dados de acordo com o id fornecido
        var livro = _context.Livro.FirstOrDefault(livro => livro.Id == id);

        // Se o livro for nulo, retorna um status code 404
        if (livro == null) return NotFound();

        // Se o livro for encontrado, converte o objeto da classe básica de leitura para a classe Livro
        ReadLivroDto livroDto = _mapper.Map<ReadLivroDto>(livro);

        // Retorna o status code 200 com o livro criado 
        return Ok(livroDto);
    }

    // Método que exibe todos os livros
    [HttpGet]
    public IEnumerable<ReadLivroDto> ExibeLivros()
    {
        // Retorna o mapeamento dos objetos da entidade Livro para a classe básica de leitura (ReadLivroDto)
        return _mapper.Map<List<ReadLivroDto>>(_context.Livro.ToList());
    }
}
