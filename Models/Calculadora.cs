using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootcampDotNet.Models
{
    public class Calculadora // Minha classe calculadora
    {
        public void Somar(int a, int b) // Aqui é um metodo, um trecho de código que vai fazer alguma coisa
        {
            Console.WriteLine($"{a} + {b} = {a + b}"); // "{a} + {b}" até aqui é um texto -- "= {a + b}" daqui pra frente é a operação em si.
        }

        public void Subtrair(int a, int b) // Aqui é um metodo, um trecho de código que vai fazer alguma coisa
        {
            Console.WriteLine($"{a} - {b} = {a - b}"); //"{a} - {b}" até aqui é um texto -- "= {a - b}" daqui pra frente é a operação em si.
        }

        public void Multiplicar(int a, int b) // Aqui é um metodo, um trecho de código que vai fazer alguma coisa
        {
            Console.WriteLine($"{a} * {b} = {a * b}"); // "{a} * {b}" até aqui é um texto -- "= {a * b}" daqui pra frente é a operação em si.
        }

        public void Dividir(int a, int b) // Aqui é um metodo, um trecho de código que vai fazer alguma coisa
        {
            Console.WriteLine($"{a} / {b} = {a / b}"); // "{a} / {b}" até aqui é um texto -- "= {a / b}" daqui pra frente é a operação em si.
        }
    }
}
