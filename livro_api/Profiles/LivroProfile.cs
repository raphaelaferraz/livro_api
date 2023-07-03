using AutoMapper;
using livro_api.Data.Dtos;
using livro_api.Models;

namespace livro_api.Profiles;

public class LivroProfile : Profile
{
    public LivroProfile()
    {
        CreateMap<CreateLivroDto, Livro>();

        CreateMap<Livro, ReadLivroDto>();

        CreateMap<UpdateLivroDto, Livro>();
    }
}
