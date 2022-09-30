using BootcampDotNet.Models;

int quantidadeEmEstoque = 10;
int quantidadeCompra = 900;
bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra;

Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

if (possivelVenda)
{
    Console.WriteLine("Venda Realizada");
}
else
{
    Console.WriteLine("Desculpe, não temos estoque suficiente");
}







// string a = "15";
// int b = 0;
// int.TryParse(a, out b);

// Console.WriteLine(b);



// int a = "5";
// int a = Convert.ToInt32("5");
// int a = int.Parse("5c");
// Console.WriteLine(c);

// double c = double.MaxValue;



// int a = 10;
// int b = 20;

// int c = a + b;
// // c = c + 5;
// c += 5;

// Console.WriteLine(c);


// DateTime dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));


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


// Pessoa pessoa = new Pessoa();

// pessoa.Idade = 26;
// pessoa.Apresentar();
