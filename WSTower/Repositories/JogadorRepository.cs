using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSTower.Contexts;
using WSTower.Domains;
using WSTower.Interfaces;

namespace WSTower.Repositories
{
    public class JogadorRepository : IJogadorRepository
    {
        WSTowerContext ctx = new WSTowerContext();

        public void Add(Jogador obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Jogador obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Jogador> GetAll()
        {
            throw new NotImplementedException();
        }

        public Jogador GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Jogador obj)
        {
            throw new NotImplementedException();
        }
    }
}
