using System;

namespace aula05
{
    class Program
    {
        static void Main(string[] args)
        {
            AvaliaNotas avaliaNotas = new AvaliaNotas();
            avaliaNotas.LerNotas();
            avaliaNotas.CalculaMedia();
            avaliaNotas.MostrarNotas();
        }
    }
}
