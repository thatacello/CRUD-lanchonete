using System.Collections.Generic;
using Lanches_Prof_Macoratti.Models;

namespace Lanches_Prof_Macoratti.Repositories
{
    public interface ICategoriaRepository
    {
         IEnumerable<Categoria> Categorias { get; }
    }
}