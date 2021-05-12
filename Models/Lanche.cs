using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lanches_Prof_Macoratti.Models
{
    public class Lanche
    {
        public int LancheId { get; set; } // chave primária identidade
        [StringLength(100)]
        public string Nome { get; set; }
        public string DescricaoCurta { get; set; }
        public string DescricaoDetalhada { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Preco { get; set; }
        public string ImagemUrl { get; set; }
        public string ImagemThumbNailUrl { get; set; } // miniatura
        public bool IsLanchePreferido { get; set; }
        public bool EmEstoque { get; set; }
        public int CategoriaId { get; set; } 
        public virtual Categoria Categoria { get; set; }
    }
}