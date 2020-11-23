using System;


class Program
{
    static void Main(string[] args)
    {
        int[] vetor = new int[] {1,5,6,45,0,-1,12}; 
        Ordenador order = new Ordenador();        

        order.Bubblesortv2(vetor);// trocar a forma de ordenção é só trocar apenas SeletionSort por Bubblesort 
        order.PrintVetor(vetor);
       
    }
}

