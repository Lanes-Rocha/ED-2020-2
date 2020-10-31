using System;
public class AvaliaNotas
{
    private float[] notas;// vetor notas
    private float media;

    /// <sumary>///Métodos construtor para instanciar o vetor. /// </summary>

    public AvaliaNotas()
    {
        notas = new float[5];
        media = 0;
    }
    public void LerNotas()
    {
        for (int i = 0; i < notas.Length; i++)
        {
           Console.WriteLine($"Digite a {i+1} nota: ");
           notas[i] = Convert.ToSingle(Console.ReadLine());
        }
    }
    public void CalculaMedia()
    {
        float soma = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            soma += notas[i];
        }
        media = soma / notas.Length;
    }
    public void MostrarNotas()
    {
        for (int i = 0; i < notas.Length; i++)
        {
            var notaAtual = notas[i];
            if (notaAtual < notas[i])
            {
                Console.WriteLine($"Nota = {notas[i]}, e está abaixo da média.");
            }else if (notaAtual > media)
            {
                Console.WriteLine($"Nota = {notas[i]}, e esta acima da média.");
            }
            else
            {
                Console.WriteLine($"Nota = {notas[i]}, e está na média");
            }
        }
    }


}