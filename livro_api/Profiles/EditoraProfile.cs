using AutoMapper;
using livro_api.Data.Dtos;
using livro_api.Models;

namespace livro_api.Profiles;

public class EditoraProfile : Profile
{
    public EditoraProfile()
    {
        // Criação do mapeamento da classe básica de criação para a classe principal Editora
        CreateMap<CreateEditoraDto, Editora>();

        // Criação do mapeamento da classe principal Editora para a classe básica de leitura
        CreateMap<Editora, ReadEditoraDto>();

        // Criação do mapeamento da classe básica de atualização para a classe principal Editora
        CreateMap<UpdateEditoraDto, Editora>();
    }
}
