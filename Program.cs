using System;
namespace Construtor; 

class Program
{
    static void Main(string[] args)
    {
        Cadeira cadeira = new Cadeira("preta", 15, 150.0 );

        Console.WriteLine("CADEIRA 1");
        Console.WriteLine($"COR : {cadeira.cor}");
        Console.WriteLine($"PESO : {cadeira.peso} kg");
        Console.WriteLine($"ALTURA : {cadeira.altura} Cm");
        Console.WriteLine();
       
        Cadeira cadeira2 = new Cadeira();

        cadeira2.cor = "Branca";
        cadeira2.peso = 13;
        cadeira2.altura = 140.0; 

        Console.WriteLine();
        Console.WriteLine("CADEIRA 2");
        Console.WriteLine($"COR : {cadeira2.cor}");
        Console.WriteLine($"PESO : {cadeira2.peso} kg");
        Console.WriteLine($"ALTURA : {cadeira.altura} Cm");
    }


   
}