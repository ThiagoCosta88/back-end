using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aula_2.interfaces;

namespace aula_2.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        public string? cpf{get; set;}

        public DateTime dataNasc {get; set;}

        public override float CalcularImposto(float rendimentos)
        {
            throw new NotImplementedException();
        }

        public bool ValidarDataNasc(DateTime dataNasc)
        {
            throw new NotImplementedException();
        }
    }
}