using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia.Data;

namespace Aplicacion.Repository
{
    public class GeneroRepository : GenericRepository<Genero>, IGeneroRepository
    {
        private readonly ApiIncidenciasContext _context;

        public GeneroRepository(ApiIncidenciasContext context) : base(context)
        {
            _context = context;
        }
    }
}