using AutoMapper;
using UsuariosApi.Data.Dtos;

namespace UsuariosApi.Profiles;

public class UsuarioProfile : Profile
{

    public UsuarioProfile()
    {
        CreateMap<CreateUsuarioDto, Usuario>();
    }

}
