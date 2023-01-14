using Curso;

var client = new Client(10, "Danilo", 30);

var client2 = new Client(10, "João", 30);

Console.WriteLine(client.Equals(client2));