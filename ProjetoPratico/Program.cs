using System;
using ProjetoPratico.ContentContext;
using static System.Console;
using ProjetoPratico.ContentContext.Enums;

namespace ProjetoPratico 
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            WriteLine("Olá Mundo!");

            Course course = new();
            course.Level = ContentContext.Enums.ContentLevel.Avancado;
        }
    }
}