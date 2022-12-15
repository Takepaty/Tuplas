(int Id, string Nome, string Sobrenome, decimal Altura) tupla = (1, "Patricia", "Takehara", 1.53M);

//ValueTuple<int, string, string, decimal> outroExemploTupla = (1, "Patricia", "Takehara", 1.53M);
//var outroExemploTuplaCreate = Tuple.Create(1, "Patricia", "Takehara", 1.53M);

Console.WriteLine($"Id: {tupla.Id}");
Console.WriteLine($"Nome: {tupla.Nome}");
Console.WriteLine($"Sobrenome: {tupla.Sobrenome}");
Console.WriteLine($"Altura: {tupla.Altura}");