using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia.Data;

namespace Aplicacion.Repository
{
    public class DireccionRepository : GenericRepository<Direccion>, IDireccionRepository
    {
        private readonly ApiIncidenciasContext _context;

        public DireccionRepository(ApiIncidenciasContext context) : base(context)
        {
            _context = context;
        }
    }
}