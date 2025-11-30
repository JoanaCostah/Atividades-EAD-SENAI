using EAD_27._11;

 MaiorNumero maiorNumero = new MaiorNumero();

 Console.WriteLine("Insira o primeiro número:");
 maiorNumero.NumberX = int.Parse(Console.ReadLine());

 Console.WriteLine("Insira o Segundo número:");
 maiorNumero.NumberY = int.Parse(Console.ReadLine());

 Console.WriteLine("Insira o Terceiro número:");
 maiorNumero.NumberZ = int.Parse(Console.ReadLine());

 maiorNumero.NumberMaior();


 ConverterParaCelsius converterParaCelsius = new ConverterParaCelsius();

 Console.WriteLine("Insira a temperatura em Fahrenheit:");
 converterParaCelsius.Fahrenheit = double.Parse(Console.ReadLine());

 converterParaCelsius.Converter();

 ContarVogais contarVogais = new ContarVogais();

 Console.WriteLine("Insira uma frase:");
 contarVogais.Frase = Console.ReadLine();

contarVogais.Contar();

 GerarSenha gerarSenha = new GerarSenha();

 Console.WriteLine("Insira o tamanho da senha a ser gerada:");
 gerarSenha.Tamanho = int.Parse(Console.ReadLine()); 

gerarSenha.Gerar();

Media media = new Media();


Console.WriteLine("Insira 5 números para calcular a média:");
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Insira o " + (i + 1) + "º número:");
    media.arrayNumeros[i] = double.Parse(Console.ReadLine());
}       

media.CalcularMedia();

EhPalindromo ehPalindromo = new EhPalindromo();

Console.WriteLine("Insira uma frase para verificar se é um palíndromo:");
ehPalindromo.Frase = Console.ReadLine();


Console.WriteLine(ehPalindromo.Verificar());


Calculando calculadora1 = new Calculando();

Console.WriteLine("Insira o primeiro número");
calculadora1.Numero1 = int.Parse(Console.ReadLine());

Console.WriteLine("Insira o segundo número");
calculadora1.Numero2 = int.Parse(Console.ReadLine());

Console.WriteLine($" Selecione a operação que deseja realizar: \n 1 - Somar \n 2 - Subtrair \n 3 - Multiplicar");
int operacao = int.Parse(Console.ReadLine());

if (operacao == 1)
{
    Console.WriteLine("Resultado da soma: " + calculadora1.Somar());
}
else if (operacao == 2)
{
    Console.WriteLine("Resultado da subtração: " + calculadora1.Subtrair());
}
else if (operacao == 3)
{
    Console.WriteLine("Resultado da multiplicação: " + calculadora1.Multiplicar());
}
else
{
    Console.WriteLine("Operação inválida, tente novamente.");
}

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

Pessoa pessoa = new Pessoa();

Console.WriteLine("Insira o nome.");
pessoa.Nome = Console.ReadLine();

Console.WriteLine("");

Console.WriteLine("Insira a idade.");
pessoa.Idade = int.Parse(Console.ReadLine());

Console.WriteLine("");

pessoa.Apresentar();


ContaBancaria contaBancaria = new ContaBancaria();

Console.WriteLine("Insira o número da conta.");
contaBancaria.NumeroConta = Console.ReadLine();

contaBancaria.ExibirSaldo();
Console.WriteLine("");

Console.WriteLine("Qual valor deseja depositar");
double valorDeposito = double.Parse(Console.ReadLine());

contaBancaria.Depositar(valorDeposito);
contaBancaria.ExibirSaldo();
Console.WriteLine("");

Console.WriteLine("Qual valor deseja sacar");
double valorSaque = double.Parse(Console.ReadLine());

contaBancaria.Sacar(valorSaque);
contaBancaria.ExibirSaldo();
Console.WriteLine("");

Calculadora calculadora = new Calculadora();

Console.WriteLine("Insira o primeiro número");
calculadora.Numero1 = double.Parse(Console.ReadLine());

Console.WriteLine("Insira o segundo número");
calculadora.Numero2 = double.Parse(Console.ReadLine());

Console.WriteLine($" Selecione a operação que deseja realizar: \n 1 - Somar \n 2 - Subtrair \n 3 - Multiplicar \n 4 - Dividir");
int escolha = int.Parse(Console.ReadLine());

if (escolha == 1)
{
    Console.WriteLine("Resultado da soma: " + calculadora.Somar());
}
else if (escolha == 2)
{
    Console.WriteLine("Resultado da subtração: " + calculadora.Subtrair());
}
else if (escolha == 3)
{
    Console.WriteLine("Resultado da multiplicação: " + calculadora.Multiplicar());
}
else if(escolha == 4)
{
    Console.WriteLine("Resultado da divisão: " + calculadora.Dividir());
}
else
{
    Console.WriteLine("Operação inválida, tente novamente.");
}

Produto produto = new Produto("Monitor", 600.0, 3);

double total = produto.CalcularTotal();

Console.WriteLine("Produto: " + produto.Nome);
Console.WriteLine("Preço: " + produto.Preco);
Console.WriteLine("Quantidade: " + produto.Quantidade);
Console.WriteLine("Total: " + total);

Aluno aluno = new Aluno();

Console.WriteLine("Digite o nome do aluno ");
aluno.Nome = Console.ReadLine();

Console.WriteLine("Digite a primeira nota do aluno ");
aluno.NotaUm = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a segunda nota do aluno ");
aluno.NotaDois = double.Parse(Console.ReadLine());

aluno.Media();