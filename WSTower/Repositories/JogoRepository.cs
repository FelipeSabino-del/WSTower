using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSTower.Contexts;
using WSTower.Domains;
using WSTower.Interfaces;

namespace WSTower.Repositories
{
    public class JogoRepository : IJogoRepository
    {
        WSTowerContext ctx = new WSTowerContext();

        public void Add(Jogo obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Jogo obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Jogo> GetAll()
        {
            throw new NotImplementedException();
        }

        public Jogo GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Jogo obj)
        {
            throw new NotImplementedException();
        }
    }
}
