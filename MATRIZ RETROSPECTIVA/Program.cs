using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATRIZ_RETROSPECTIVA {
    internal class Program {
        static void Main(string[] args) {
            double[,] Matriz = new double[2, 3];
            Console.WriteLine(Matriz.Length+ " Quantidade de elementos (0,0) (0,1) (0,2) (1,0) (1,1) (1,2)");
            Console.WriteLine(Matriz.Rank + " Primeira dimensão de linhas e apresentada com Rank");

            Console.WriteLine(Matriz.GetLength(1) + " ira imprimir a dimensão da matriz ");

        }
    }
}
