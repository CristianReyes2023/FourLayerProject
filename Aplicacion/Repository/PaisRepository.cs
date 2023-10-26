using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia.Data;

namespace Aplicacion.Repository
{
    public class PaisRepository : GenericRepositoryString<Pais>, IPaisRepository
    {
        private readonly ApiIncidenciasContext _context;

        public PaisRepository(ApiIncidenciasContext context) : base(context)
        {
            _context = context;
        }
    }
}