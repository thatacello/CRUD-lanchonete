using System.Collections.Generic;
using Lanches_Prof_Macoratti.Models;

namespace Lanches_Prof_Macoratti.ViewModels
{
    public class LancheListViewModel
    {
        public IEnumerable<Lanche> Lanches { get; set; }
        public string CategoriaAtual { get; set; }
    }
}