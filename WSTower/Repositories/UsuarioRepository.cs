﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSTower.Contexts;
using WSTower.Domains;
using WSTower.Interfaces;

namespace WSTower.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        WSTowerContext ctx = new WSTowerContext();

        public void Add(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public Usuario BuscarEmailSenha(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public void Delete(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Usuario> GetAll()
        {
            throw new NotImplementedException();
        }

        public Usuario GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Usuario obj)
        {
            throw new NotImplementedException();
        }
    }
}