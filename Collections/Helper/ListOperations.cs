using System.Collections.Generic;

namespace Collections.Helper
{
    public class ListOperations
    {
        public void ImprimirListaString(List<string> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                System.Console.WriteLine($"Índice {i}, Valor: {lista[i]}");
            }
        }
    }
}