using Curso;
using static System.Console;

(int, string) numbers;

numbers = (10, "primeiro");

WriteLine(numbers.Item1);
WriteLine(numbers.Item2);

var teste = (coordenadas: 1012, longitude: 10);

Console.WriteLine(teste.coordenadas);