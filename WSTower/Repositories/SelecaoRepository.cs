using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSTower.Contexts;
using WSTower.Domains;
using WSTower.Interfaces;

namespace WSTower.Repositories
{
    public class SelecaoRepository : ISelecaoRepository
    {
        WSTowerContext ctx = new WSTowerContext();

        public void Add(Selecao obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Selecao obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Selecao> GetAll()
        {
            throw new NotImplementedException();
        }

        public Selecao GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Selecao obj)
        {
            throw new NotImplementedException();
        }
    }
}
