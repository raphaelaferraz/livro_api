using AutoMapper;
using livro_api.Data.Dtos;
using livro_api.Models;

namespace livro_api.Profiles;

public class AutorProfile : Profile
{
    public AutorProfile()
    {
        CreateMap<CreateAutorDto, Autor>();

        CreateMap<Autor, ReadAutorDto>();

        CreateMap<UpdateAutorDto, Autor>();
    }
}
