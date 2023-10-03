using COMMON.Entidades;
using COMMON.Validadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIZ
{
    public class DepartamentoManager : GenericManager<Departamento>
    {
        public DepartamentoManager(string urlBase, BaseValidator<Departamento> validador) : base(urlBase, validador)
        {
        }
    }
}
