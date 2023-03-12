using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using aula_2.interfaces;

namespace aula_2.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string? cnpj {get; set;}
        public string? razaoSocial {get; set;}


        public string? Caminho {get; private set;} = "Database/PessoaJuridica.csv";


        public override float CalcularImposto(float rendimento)
        {
          if (rendimento <= 3000)
            {
              return rendimento * .03f;
               
            } else if (rendimento > 3000 && rendimento <= 6000)
            {

              return rendimento  * 0.05f;
               
            }
            else if (rendimento > 6000 && rendimento <= 10000)
            {

              return   rendimento * 0.07f;
               
            } 
            else
            {

              return  rendimento * 0.09f;
                               
            }                 
        }

        public bool ValidarCnpj(string cnpj)

        // 767734150000160 (14)
        // 76.773.415.00001-60(18)


        {
            // Comparando atraves do metodo Regex o valor informado, do cnpj 
          bool retornoCnpjValido = Regex.IsMatch(cnpj, @"^(\d{14}) | (\d{2}.\d{3}.\d{3}/\d{4}-\d{2}) $");

          if (retornoCnpjValido)
          {
            string subStringCnpj14 = cnpj.Substring(8, 4);

            if (subStringCnpj14 == "0001")
            {
               return true; 
            }else 

            return false;

          }
          string subStringCnpj18 = cnpj.Substring(11, 4);
            if (subStringCnpj18 == "0001")
            {
               return true; 
            }

        return false;      
        } 

        public void Inserir(PessoaJuridica pj){

          Utils.VerificarPastaArquivos(Caminho);

          string [] pjstring = {$"{pj.razaoSocial},{pj.cnpj}"};

          File.AppendAllLines(Caminho, pjstring);

        }

        public List<PessoaJuridica> LerArquivo()
        {
          //razaoSocial, cnpj
          List<PessoaJuridica> listaPj = new List<PessoaJuridica>();
          string [] linhas = File.ReadAllLines(Caminho);

          foreach (var cadalinha in linhas)
          {
            string [] atributos = cadalinha.Split(",");

            PessoaJuridica cadaPj = new PessoaJuridica();
            cadaPj.razaoSocial = atributos[0];
            cadaPj.cnpj = atributos[1];

            listaPj.Add(cadaPj);
          }

          return listaPj;
        }

    }
}