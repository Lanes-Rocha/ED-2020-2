using System;

class Program
{
    static void Main(string[] args)
    {
        LinkdList lista = new LinkdList();

        lista.Add(10);
        lista.Add(1);
        lista.Add(5);
        lista.Add(14);
        lista.Add(999999);
        
        lista.Print();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(lista.Find(3));
      
        
    }
}
