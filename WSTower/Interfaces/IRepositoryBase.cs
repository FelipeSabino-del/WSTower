using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WSTower.Interfaces
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Add();
        void Update();
        void Delete();
        IEnumerable<TEntity> GetAll();
    }
}
