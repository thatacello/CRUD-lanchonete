using System.Net.Mime;
using System.Collections.Generic;
using Lanches_Prof_Macoratti.Models;
using Lanches_Prof_Macoratti.Data;

namespace Lanches_Prof_Macoratti.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly ApplicationDbContext _contexto;
        public CategoriaRepository(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }
        public IEnumerable<Categoria> Categorias => _contexto.Categorias;
    }
}