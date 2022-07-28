using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateDomain.Entities;

namespace TemplateDomain.Interfaces
{
    public interface IUsuarioRepository:IRepository<Usuario>
    {
        public IEnumerable<Usuario> GetAll();

        

    }
}
