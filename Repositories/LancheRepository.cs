using System.Net.Mime;
using System.Collections.Generic;
using Lanches_Prof_Macoratti.Models;
using Lanches_Prof_Macoratti.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Lanches_Prof_Macoratti.Repositories
{
    public class LancheRepository : ILancheRepository
    {
        private readonly ApplicationDbContext _contexto;
        public LancheRepository(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }
        public IEnumerable<Lanche> Lanches => _contexto.Lanches.Include(c => c.Categoria);

        public IEnumerable<Lanche> LanchesPreferidos => _contexto.Lanches.Where(p => p.IsLanchePreferido)
                                                                        .Include(c => c.Categoria);

        public Lanche GetLancheById(int lancheId)
        {
            return _contexto.Lanches.FirstOrDefault( l => l.LancheId == lancheId);
        }
    }
}