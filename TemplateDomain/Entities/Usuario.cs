using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateDomain.Models;

namespace TemplateDomain.Entities
{
    public class Usuario: Entity
    {
        public string Nome { get; set; }

        public string Email{ get; set; }
    }
}
