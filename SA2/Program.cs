using aula_2.Classes;
using System;

List<PessoaJuridica> listaPj = new List<PessoaJuridica>();


string? opcao;
string? opcaoPJ;

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

            do
            {

                Console.Clear();
                Console.WriteLine(@$"
                  =======================================================
                  |       digite o numero de uma das opções a baixo       |      
                  =======================================================
                  |                                                       |
                  |             1 - Cadastrar Pessoa Juridíca             |
                  |             2 - Lista Pessoa Juridíca                 |
                  |                                                       |
                  |             0 - Voltar  ao menu anterior              |
                  =======================================================
");

                opcaoPJ = Console.ReadLine();

                switch (opcaoPJ)
                {
                    case "1":

                        PessoaJuridica novoPj = new PessoaJuridica();
                        Endereco novoEndPj = new Endereco();

                        Console.Clear();
                        // Console.WriteLine($"Digite o nome da Razão Social");
                        // novoPj.razaoSocial = Console.ReadLine();

                        // // StreamWriter sw = new StreamWriter($"{novoPj.razaoSocial}.txt");
                        // // sw.WriteLine(novoPj.razaoSocial);
                        // // sw.Close();

                        // using (StreamWriter sw = new StreamWriter($"{novoPj.razaoSocial}.txt"))
                        // {
                        //     sw.WriteLine(novoPj.razaoSocial);
                        // }








                        // Console.WriteLine($"Digite o CNPJ da empresa");
                        // novoPj.cnpj = Console.ReadLine();

                        // Console.WriteLine($"Digite o rendimento da sua Empresa");
                        // string? rendEntrada = Console.ReadLine();

                        // float.TryParse(rendEntrada, out float rendConvertido);
                        // novoPj.rendimento = rendConvertido;

                        // // ******************************

                        // Console.WriteLine($"Digite o nome da Rua");
                        // novoEndPj.logradouro = Console.ReadLine();

                        // Console.WriteLine($"Digite o numero do Imóvel");
                        // string? numEntrada = Console.ReadLine();
                        // int.TryParse(numEntrada, out int numConvertido);
                        // novoEndPj.numero = numConvertido;

                        // novoPj.endereco = novoEndPj;
                        // listaPj.Add(novoPj);

                        // Console.WriteLine($"Cadastro realizado com susseço.");
                        // Console.WriteLine($"Pressione uma tecla para continuar");
                        // Console.ReadLine();



                        novoPj.razaoSocial = "Thiago costa";
                        novoPj.cnpj= "14235375000123";

                        novoPj.Inserir(novoPj);
                        // // novoPj.rendimento = 7500;

                        // // novoEndPj.logradouro = "Rua João Agapito";
                        // // novoEndPj.numero = 131;        
                        // // novoEndPj.complemento = "Casa A";
                        // // novoEndPj.endComercial= false;

                        // // novoPj.endereco = novoEndPj;

                        // // interpolação

                        // // Console.WriteLine(@$"
                        // // Nome da Razão Social: {novoPj.razaoSocial}
                        // // Enderecço: {novoEndPj.logradouro}, Num: {novoEndPj.numero}
                        // // CNPJ: {novoPj.cnpj} - Valido {novoPj.ValidarCnpj(novoPj.cnpj)}
                        // // ");
                        // // Console.WriteLine($"comandos para cadastrar uma nova pessoa juridica");
                        // // Thread.Sleep(1000);

                         Console.WriteLine($"Cadastro ok/ arquivo cadastrado");
                         Console.ReadLine();
                         
                        
                        break;
                    case "2":

                        Console.Clear();                    
                                               
                        // using (StreamReader sr = new StreamReader("Th-invest.txt"))
                        // {
                        //     string? linha;
                        //     while ((linha = sr.ReadLine()) != null)
                        //     {
                        //        linha = sr.ReadLine(); 
                        //        Console.WriteLine($"{linha}");
                        //     }
                        // }

                             PessoaJuridica novoPj2 = new PessoaJuridica();
                            List<PessoaJuridica> listaExibicaoPj = novoPj2.LerArquivo();

                            foreach (var cadaItem in listaExibicaoPj)
                            {

                                Console.WriteLine(@$"
                                
                                Razão Social: {cadaItem.razaoSocial}
                                CNPJ: {cadaItem.cnpj}                                
                                
                                ");
                                Console.WriteLine($"Linha ok, Enter para Continuar");
                                Console.ReadLine();  
                                Console.Clear();                           

                            }

                            Console.WriteLine($"Leitura Total Completa");
                            Console.ReadLine(); 
                            Console.Clear();                                                                 
                       



                    //     if (listaPj.Count > 0)
                    //     {
                    //      foreach (PessoaJuridica cadaPj in listaPj)                           
                    //     {

                    //         Console.Clear();                           
                                            
                        
                    //         Console.WriteLine(@$"
                    // Nome da Razão Social: {cadaPj.razaoSocial}
                    // Enderecço: {cadaPj.endereco.logradouro}, Num: {cadaPj.endereco.numero}
                    // CNPJ: {cadaPj.cnpj} - Valido: {cadaPj.ValidarCnpj(cadaPj.cnpj)}
                    // ");

                    //         Console.WriteLine($"Pressione qualquer tecla para continuar.");
                    //         Console.ReadLine();
                    //     }
                    //     }else
                    //     {
                    //        Console.WriteLine($"Não temos dados para exibir, listagem vazia.");
                    //        Thread.Sleep(4000);                            
                    //     }                   

                       
                        break;

                    case "0":
                        Console.WriteLine($"Voltar ao menu anterior");

                        break;

                    default:
                        Console.WriteLine($"Digite o valor correto!");
                        Thread.Sleep(2000);

                        break;
                }
            } while (opcaoPJ != "0");



            Thread.Sleep(2500);
            break;
        // ----------------Pessoa Juridica ---------------------
        // PessoaJuridica novoPj = new PessoaJuridica();
        // Endereco novoEndPj = new Endereco();

        // novoPj.nome = "Thiago costa";
        // novoPj.cnpj= "14235375000123";
        // novoPj.rendimento = 7500;

        // novoEndPj.logradouro = "Rua João Agapito";
        // novoEndPj.numero = 131;        
        // novoEndPj.complemento = "Casa A";
        // novoEndPj.endComercial= false;

        // novoPj.endereco = novoEndPj;

        // interpolação



        // ======== validar cnpj =================

        // Console.WriteLine(novoPj.ValidarCnpj("15283345000129"));

        //=========== calculando imposto a pagar =============

        // float impostoPg = novaPj.CalcularImposto(novaPj.rendimento);
        // Console.WriteLine(impostoPg.ToString("c"));




        case "2":
            // ----------------------Pessoa Fisica -------------------------

            PessoaFisica novaPF = new PessoaFisica();
            Endereco novoEndPf = new Endereco();


            novaPF.nome = "Thiago";
            novaPF.cpf = "9876543210";
            novaPF.rendimento = 6600.5f;
            novaPF.dataNasc = new DateTime(06 / 01 / 1988);

            novoEndPf.logradouro = "Rua João Agapito";
            novoEndPf.numero = 131;
            novoEndPf.complemento = "Casa A";
            novoEndPf.endComercial = true;

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

} while (opcao != "0");









