using AutoMapper;
using Dominio.Dtos;
using Dominio.Entities;
using Repositorio.Interfaces;
using Servicio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio
{
    public class VehiculoService : IVehiculoService
    {
        private readonly IVehiculoRepository _repository;
        private readonly IMapper _mapper;

        public VehiculoService(IVehiculoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public Vehiculo Consultar(int id)
        {
            throw new NotImplementedException();
        }

        public VehiculoCreadoDto Registrar(CrearVehiculoDto dto)
        {
            var Vehiculo = _mapper.Map<Vehiculo>(dto);
            _repository.Registrar(Vehiculo);
            return _mapper.Map<VehiculoCreadoDto>(Vehiculo);
        }
    }
}
