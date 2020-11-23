using System;
using System.Diagnostics;


class Program
{
    static void Main(string[] args)
    {
        Stopwatch sw = new Stopwatch();
        Random random = new Random(); // Criando objeto random

        //int[] vetor = new int[] {1,5,6,45,0,-1,12}; 
        int[] vetor = new int[1000];
        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = random.Next(); // vetor com preencimento randômico.
        }

        Ordenador order = new Ordenador();        

        sw.Start();
        order.InsertonSort(vetor);// trocar a forma de ordenção é só trocar apenas SeletionSort por Bubblesort ou InsertonSort
        sw.Stop();

        //order.PrintVetor(vetor);
        Console.WriteLine($"Runtime = {sw.Elapsed.ToString()}");
       
    }

}

