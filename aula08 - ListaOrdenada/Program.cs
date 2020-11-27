using System;

class Program
{
    static void Main(string[] args)
    {
        LinkdList lista = new LinkdList();

        lista.AddOrdered(10);
        lista.AddOrdered(1);
        lista.AddOrdered(5);
        lista.AddOrdered(14);
        lista.AddOrdered(3);
        lista.AddOrdered(999999);
        
        lista.Print();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine($"Resultado -> [ {lista.Find(5)} ]");
      
        
    }
}
