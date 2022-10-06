using BootcampDotNet.Models;

int soma = 0;
int numero = 0;

do
{
    Console.WriteLine("Digite um número (0 para parar)");
    numero = Convert.ToInt32(Console.ReadLine());
    soma += numero;
} while (numero != 0);

Console.WriteLine($"Total de soma dos números digitados é: {soma}");









// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

// int numero = 5;
// int contador = 0;

// while (contador <= 10)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//     contador++;
// }

// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

// int numero = 5;

// for (int contador = 0; contador <= 10; contador++)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }

// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

// int numeroIncremento = 10;

// Console.WriteLine($" O número a ser incrementado é o: " + numeroIncremento);
// Console.WriteLine("Incrementando o 10");
// numeroIncremento++;
// Console.WriteLine(numeroIncremento);



// int numeroDecremento = 10;
// Console.WriteLine($" O número a ser decrementado é o: " + numeroDecremento);
// Console.WriteLine("Decrementando o 10");
// numeroDecremento--;
// Console.WriteLine(numeroDecremento);

// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

// Calculadora calc = new Calculadora();

// calc.Somar(10, 30);
// calc.Dividir(10, 30);
// calc.Multiplicar(10, 30);
// calc.Subtrair(10, 30);
// calc.Potencia(3, 3);
// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);
// calc.RaizQuadrada(257);

// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

// bool tarde = true;
// bool choveu = true;

// if (!choveu && !tarde)
// {
//     Console.WriteLine("Vou pedalar");
// }
// else
// {
//     Console.WriteLine("Vou pedalar outro dia");
// }

// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

// bool possuiPresencaMinima = true;
// double media = 6;

// if (possuiPresencaMinima && media >= 7) // Se uma condição apenas for falsa, ele fará a condição FALSA do if
// {
//     Console.WriteLine("Aprovado");
// }
// else
// {
//     Console.WriteLine("Reprovado");
// }

// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

// bool maiorDeIdade = false; // Aqui eu defino que, de acordo com a maior idade, a informação é TRUE. na raíz da definição do pipe
// bool autorizacaoDoResponsavel = false; // Aqui eu defino que, de acordo com a maior idade, a informação é FALSE, na raíz da definição do pipe

// if (maiorDeIdade || autorizacaoDoResponsavel) // O operador OU verifica qual é a verdadeira. OU maiorIdade OU autorizaçãoDoResponsável
// {
//     Console.WriteLine("Condição Verdadeira!"); // Qual opção é VERDADEIRO(true)? Se qualquer uma das duas for TRUE, ele vai imprimir isso aqui
// }
// else
// {
//     Console.WriteLine("Condição Falsa"); // Essa opção só será exibida se as 2 opções forem falsas.
// }


// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();

// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal");
//         break;

//     default:
//         Console.WriteLine("Não é uma vogal");
//         break;
// }



// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 0;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

// if (quantidadeCompra == 0)
// {
//     Console.WriteLine("Venda inválida");
// }

// else if (possivelVenda)
// {
//     Console.WriteLine("Venda Realizada");
// }
// else
// {
//     Console.WriteLine("Desculpe, não temos estoque suficiente");
// }

// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

// string a = "15";
// int b = 0;
// int.TryParse(a, out b);

// Console.WriteLine(b);

// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

// int a = "5";
// int a = Convert.ToInt32("5");
// int a = int.Parse("5c");
// Console.WriteLine(c);

// double c = double.MaxValue;

// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

// int a = 10;
// int b = 20;

// int c = a + b;
// // c = c + 5;
// c += 5;

// Console.WriteLine(c);

// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

// DateTime dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));

// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

// string apresentacao = "Olá, Mundo!";
// apresentacao = "Olá, mundo de novo";
// int quantidade = 1;
// double altura = 1.80;
// decimal preco = 1.90M;
// bool condicao = false;


// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da variável quantidade: " + quantidade);
// Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));
// Console.WriteLine("Valor da variável preco: " + preco);
// Console.WriteLine("Valor da variável condicao: " + condicao);

// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

// Pessoa pessoa = new Pessoa();

// pessoa.Idade = 26;
// pessoa.Apresentar();

// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------