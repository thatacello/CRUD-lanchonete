using System.Collections.Generic;
using Lanches_Prof_Macoratti.Models;

namespace Lanches_Prof_Macoratti.Repositories
{
    public interface ILancheRepository
    {
         IEnumerable<Lanche> Lanches { get; }
         IEnumerable<Lanche> LanchesPreferidos { get; }
         Lanche GetLancheById(int lancheId);
    }
}