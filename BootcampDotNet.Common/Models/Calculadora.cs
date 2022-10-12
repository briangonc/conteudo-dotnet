using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootcampDotNet.Common.Models
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

        public void Potencia(int a, int b)
        {
            double potencia = Math.Pow(a, b);
            Console.WriteLine($"{a}^{b} = {potencia}");
        }

        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo}º = {Math.Round(seno, 4)}");
        }

        public void Coseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"Coseno de {angulo}º = {Math.Round(coseno, 4)}");
        }

        public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"Tangente de {angulo}º = {Math.Round(tangente, 4)}");
        }

        public void RaizQuadrada(double x)
        {
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"Raiz quadrada de  {x} = {Math.Round(raiz, 2)}");
        }
    }

}
