using System.Collections.Generic;

namespace Lanches_Prof_Macoratti.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string CategoriaNome { get; set; }
        public string Descricao { get; set; }
        public List<Lanche> Lanches { get; set; } // 1 categoria tem muitos lanches (relacionamento 1 para muitos)
    }
}