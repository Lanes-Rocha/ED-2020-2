using System;
using System.Diagnostics;


class Program
{
    static void Main(string[] args)
    {
        Stopwatch sw = new Stopwatch();
        Random random = new Random(); // Criando objeto random

        //int[] vetor = new int[] {1,5,6,45,0,-1,12}; 
        int[] vetor1 = new int[1000];
        for (int i = 0; i < vetor1.Length; i++)
        {
            vetor1[i] = random.Next(); // vetor com preencimento randômico.
        }
        int[] vetor2 = new int[1000];
        vetor1.CopyTo(vetor2, 0);
        int[] vetor3 = new int[1000];
        vetor1.CopyTo(vetor3, 0);
        int[] vetor4 = new int[1000];
        vetor1.CopyTo(vetor4, 0);

        Ordenador order = new Ordenador();        

        sw.Start();
        order.SeletionSort(vetor1);// trocar a forma de ordenção é só trocar apenas SeletionSort por Bubblesort ou InsertonSort
        sw.Stop();
        Console.WriteLine($"Selection Sort = {sw.Elapsed.ToString()}");

        sw.Start();
        order.Bubblesort(vetor2);// trocar a forma de ordenção é só trocar apenas SeletionSort por Bubblesort ou InsertonSort
        sw.Stop();
        Console.WriteLine($"Bubble Sort    = {sw.Elapsed.ToString()}");

        sw.Start();
        order.Bubblesortv2(vetor3);// trocar a forma de ordenção é só trocar apenas SeletionSort por Bubblesort ou InsertonSort
        sw.Stop();
        Console.WriteLine($"Bubble Sort v2 = {sw.Elapsed.ToString()}");

        sw.Start();
        order.InsertonSort(vetor4);// trocar a forma de ordenção é só trocar apenas SeletionSort por Bubblesort ou InsertonSort
        sw.Stop();
        Console.WriteLine($"InsertonSort   = {sw.Elapsed.ToString()}");
        

        //order.PrintVetor(vetor);
       
       
    }

}

