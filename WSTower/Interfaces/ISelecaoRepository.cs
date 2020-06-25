using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSTower.Domains;

namespace WSTower.Interfaces
{
    public interface ISelecaoRepository : IRepositoryBase<Selecao>
    {
        public int Pontos(int id);
        public Dictionary<Selecao, int> OrdemPontos(int id);
    }
}
