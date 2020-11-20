using System;


class Program
{
    static void Main(string[] args)
    {
        int[] vetor = new int[] {1,5,6,45,0,-1,12};
        int[] vetor2 = new int[] {3,5,9,-45,2,-1,1};

        Ordenador order = new Ordenador();
        Ordenador order2 = new Ordenador();
        
        Console.WriteLine();
        Console.WriteLine("Primeira impressão utilizando Bubblesort");
        order.Bubblesort(vetor);
        order.PrintVetor(vetor);

        Console.WriteLine();

        Console.WriteLine("=======================================");
        Console.WriteLine();        

        Console.WriteLine("Segunda impressão utilizando SelectionSort");
        order2.SeletionSort(vetor2);
        order2.PrintVetor(vetor2);
    }
}

