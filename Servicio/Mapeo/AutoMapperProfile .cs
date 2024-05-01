using AutoMapper;
using Dominio.Dtos;
using Dominio.Entities;

namespace Servicio.Mapeo
{
    public class AutoMapperProfile: Profile
    {

        public AutoMapperProfile()
        {
            CreateMap<CrearProductoDto, Producto>();
            CreateMap<Producto, ProductoCreadoDto>();
            //CreateMap<CrearProductoDto, Producto>();
            //CreateMap<Producto, CrearProductoDto>();
        }


    }
}
