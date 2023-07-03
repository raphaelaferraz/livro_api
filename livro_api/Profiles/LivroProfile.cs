using AutoMapper;
using livro_api.Data.Dtos;
using livro_api.Models;

namespace livro_api.Profiles;

public class LivroProfile : Profile
{
    public LivroProfile()
    {
        // Criação do mapeamento da classe básica de criação para a classe principal Livro
        CreateMap<CreateLivroDto, Livro>();

        // Criação do mapeamento da classe principal Livro para a classe de leitura 
        CreateMap<Livro, ReadLivroDto>();

        // Criação do mapeamento da classe básica de atualização para a classe principal Livro
        CreateMap<UpdateLivroDto, Livro>();
    }
}
