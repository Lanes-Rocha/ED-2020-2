using System;


class Program
{
    static void Main(string[] args)
    {
        int[] vetor = new int[] {1,5,6,45,0,-1,12}; 
        Ordenador order = new Ordenador();        

        order.SeletionSort(vetor);// se for trocar a forma de ordenção troca apenas SeletionSort por Bubblesort 
        order.PrintVetor(vetor);
       
    }
}

