using aula_2.Classes;
using System;



string? opcao;

Utils.BarraCarregamento("Inicializando");
Console.Clear();

Console.WriteLine(@$"
              ==============================================
            |       Bem vindo ao Sistema de  cadastro de    |
            |           Pessoa Física e Juridíca            |
              ==============================================
");
Thread.Sleep(2000);


do
{
  Console.Clear();
  Console.WriteLine(@$"
                  =======================================================
                  |               Digite uma das opções abaixo            |
                  |               e tecle Enter para continuar            |
                  =======================================================
                  |                                                       |
                  |                  1 - Pessoa Juridíca                  |
                  |                  2 - Pessoa Física                    |
                  |                                                       |
                  |                  0 - Sair                             |
                  =======================================================
");


    opcao = Console.ReadLine();

// Console.WriteLine($"Você digitou: {opcao}");

switch (opcao)
{
    case "1":
    // ----------------Pessoa Juridica ---------------------
        PessoaJuridica novoPj = new PessoaJuridica();
        Endereco novoEndPj = new Endereco();

        novoPj.nome = "Thiago costa";
        novoPj.cnpj= "14235375000123";
        novoPj.rendimento = 7500;

        novoEndPj.logradouro = "Rua João Agapito";
        novoEndPj.numero = 131;        
        novoEndPj.complemento = "Casa A";
        novoEndPj.endComercial= false;

        novoPj.endereco = novoEndPj;

        // interpolação

        Console.WriteLine(@$"
        Nome: {novoPj.nome}
        Enderecço: {novoEndPj.logradouro}, Num: {novoEndPj.numero}
        CNPJ: {novoPj.cnpj} - Valido {novoPj.ValidarCnpj(novoPj.cnpj)}
        ");

        // ======== validar cnpj =================

        // Console.WriteLine(novoPj.ValidarCnpj("15283345000129"));

        //=========== calculando imposto a pagar =============

        // float impostoPg = novaPj.CalcularImposto(novaPj.rendimento);
        // Console.WriteLine(impostoPg.ToString("c"));

        Thread.Sleep(8000);
        break;


    case "2":
// ----------------------Pessoa Fisica -------------------------
        
        PessoaFisica novaPF = new PessoaFisica();
        Endereco novoEndPf = new Endereco();


        novaPF.nome = "Thiago";
        novaPF.cpf ="9876543210";
        novaPF.rendimento = 6600.5f;
        novaPF.dataNasc = new DateTime(06/01/1988);

        novoEndPf.logradouro = "Rua João Agapito";
        novoEndPf.numero = 131;        
        novoEndPf.complemento = "Casa A";
        novoEndPf.endComercial= true;

        novaPF.endereco = novoEndPf;

  
        
        // interpolação
    Console.WriteLine(@$"
        Nome: {novaPF.nome}
        Endereço: {novoEndPf.logradouro}, num: {novoEndPf.numero}
        Maior de idade: {novaPF.ValidarDataNasc(novaPF.dataNasc)}
    ");
     
        // ========== calculando imposto a pagar ================
        // float impostoPagar = novaPF.CalcularImposto(novaPF.rendimento);
        // Console.WriteLine(impostoPagar.ToString("c"));


        // =======valida data de nascimento =============
        // DateTime temp = new DateTime(2008,01,02);
        // Console.WriteLine(novaPF.ValidarDataNasc("01/01/2000"));


        Console.WriteLine($"Pressione qualquer tecla para continuar");
        Console.ReadLine();           
        break;

    case "0":
   Utils.BarraCarregamento("Finalizando");
   Console.Clear();
        break;


    default:
    Console.WriteLine($"Digite o valor correto");
      Thread.Sleep(2000);

        break;
}

} while(opcao != "0");









