using System;


class Program
{
    static void Main(string[] args)
    {
        int[] vetor = new int[] {1,5,6,45,0,-1,12};
        Ordenador order = new Ordenador();
        order.Bubblesort(vetor);
        order.PrintVetor(vetor);
    }
}

