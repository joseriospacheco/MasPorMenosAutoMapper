using Dominio.Entities;
using Repositorio.Data;
using Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class VehiculoRepository : IVehiculoRepository
    {
        private readonly AppDbContext _context;

        public VehiculoRepository(AppDbContext context)
        {
            _context = context;
        }

        public bool Registrar(Vehiculo vehiculo)
        {
             _context.Vehiculo.Add(vehiculo);
            return _context.SaveChanges()>0;
        }
    }
}
