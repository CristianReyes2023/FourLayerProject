using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia.Data;

namespace Aplicacion.Repository
{
    public class DepartamentoRepository : GenericRepositoryString<Departamento>, IDepartamentoRepository
    {
        private readonly ApiIncidenciasContext context;

        public DepartamentoRepository(ApiIncidenciasContext context) : base(context)
        {
            this.context = context;
        }
    }
}