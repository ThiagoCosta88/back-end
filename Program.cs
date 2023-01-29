using aula_2.Classes;
// Pessoa Fisica -------------------------
PessoaFisica novaPF = new PessoaFisica();
novaPF.nome = "Thiago";
novaPF.cpf ="9876543210";
novaPF.rendimento = 6600.5f;

// calculando imposto a pagar 
float impostoPagar = novaPF.CalcularImposto(novaPF.rendimento);
Console.WriteLine(impostoPagar.ToString("c"));


// Pessoa Juridica ------------------------
PessoaJuridica novaPj = new PessoaJuridica();
novaPj.rendimento = 7500;

//calculando imposto a pagar 
float impostoPg = novaPj.CalcularImposto(novaPj.rendimento);
Console.WriteLine(impostoPg.ToString("c"));




