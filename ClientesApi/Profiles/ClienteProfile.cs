using AutoMapper;
using ClientesApi.Dtos;
using ClientesApi.Models;

namespace ClientesApi.Profiles;

public class ClienteProfile : Profile
{
    public ClienteProfile()
    {
        CreateMap<CreateClienteDto, Cliente>();
    }
}
