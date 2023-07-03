using AutoMapper;
using livro_api.Data.Dtos;
using livro_api.Models;

namespace livro_api.Profiles;

public class AutorProfile : Profile
{
    public AutorProfile()
    {
        // Criação do mapeamento da classe básica de criação para a classe principal Autor
        CreateMap<CreateAutorDto, Autor>();

        // Criação do mapeamento da classe principal Autor para a classe básica de leitura 
        CreateMap<Autor, ReadAutorDto>();

        // Criação do mapeamento da classe básica de atualização para a classe principal Autor
        CreateMap<UpdateAutorDto, Autor>();
    }
}
