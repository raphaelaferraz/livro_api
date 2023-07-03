using AutoMapper;
using livro_api.Data.Dtos;
using livro_api.Models;

namespace livro_api.Profiles;

public class EditoraProfile : Profile
{
    public EditoraProfile()
    {
        CreateMap<CreateEditoraDto, Editora>();

        CreateMap<Editora, ReadEditoraDto>();

        CreateMap<UpdateEditoraDto, Editora>();
    }
}
