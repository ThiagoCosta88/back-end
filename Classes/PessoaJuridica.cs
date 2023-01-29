using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aula_2.interfaces;

namespace aula_2.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string? cnpj {get; set;}

        public string? razaoSocial {get; set;}

        public override float CalcularImposto(float rendimento)
        {
          if (rendimento <= 3000)
            {
             float resultado = rendimento * .03f;
               return resultado; 

            } else if (rendimento > 3000 && rendimento <= 6000)
            {
              float resultado = rendimento  * 0.05f;
               return resultado;

            }
            else if (rendimento > 6000 && rendimento <= 10000)
            {
                float resultado = rendimento * 0.07f;
               return resultado; 

            } 
            else
            {
                float resultado = rendimento * 0.09f;
               return resultado; 
               
            }
                 
        }

        public bool ValidarCnpj(string cnpj)
        {
            throw new NotImplementedException();
        }
    }
}