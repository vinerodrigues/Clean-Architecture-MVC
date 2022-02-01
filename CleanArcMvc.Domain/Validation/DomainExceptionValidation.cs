using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArcMvc.Domain.Validation
{
    public class DomainExceptionValidation : Exception
    {
        public DomainExceptionValidation(string error) : base(error) { }
        //Uma classe que herda de exception pode usar os atributos de acption ou sobre escrever um metodo adptando alguma funcionalidade
        public static void When(bool hasError, string error) {
            //Um metodo estatico que caso receba true, passa o error para Exception

            if (hasError)
                throw new DomainExceptionValidation(error);
        }

    }
}
