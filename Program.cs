using aula_2.Classes;

PessoaFisica novaPF = new PessoaFisica();

novaPF.nome = "Thiago";

novaPF.cpf ="9876543210";

Console.WriteLine(novaPF.nome);
Console.WriteLine(novaPF.cpf);

Console.WriteLine($"bem vindo: {novaPF.nome} de cpf: {novaPF.cpf}");