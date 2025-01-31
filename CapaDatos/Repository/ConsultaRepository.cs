﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Interfaces;
using CapaDatos.Models;
using Microsoft.EntityFrameworkCore;

namespace CapaDatos.Repository
{
    public class ConsultaRepository : IGenericRelations<Consultas>, IConsultasRepository
    {
        private readonly AppDbContext _context;

        public ConsultaRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Consultas>> GetAllRelationsAsync()
        {
            return await _context.Consultas.Include(d=> d.Diagnostico)
                .Include(t=> t.Tratamientos).Include(p=> p.Pagos).Include(pa=> pa.Paciente).ToListAsync();
        }

        public async Task<IEnumerable<Consultas>> SearchByTermAsync(string term)
        {
            return await _context.Consultas.Include(pa => pa.Paciente)
                .Where(c => c.Motivo.ToLower().Contains(term) || c.Paciente.Nombre.ToLower().Contains(term) 
                || c.Paciente.Apellido.ToLower().Contains(term) || c.Fecha.Contains(term)
                ).ToListAsync();
        }


    }
}
