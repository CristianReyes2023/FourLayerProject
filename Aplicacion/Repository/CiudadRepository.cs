using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia.Data;

namespace Aplicacion.Repository
{
    public class CiudadRepository : GenericRepository<Ciudad>, ICiudadRepository
    {
        private readonly ApiIncidenciasContext _context;

        public CiudadRepository(ApiIncidenciasContext context) : base(context)
        {
            _context = context;
        }
        // public override async Task<IEnumerable<Ciudad>> GetAllAsync()
        // {
        //     return await _context.Ciudades.Include(x=>x.)//Este metodo es para cuando tengo FK y no he ingresados datos para que no me salga NULL
        // }
    }
}