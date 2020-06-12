using System;
using System.Collections.Generic;

namespace MetodosRecursivos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=-=-=-= MÉTODOS RECURSIVOS =-=-=-=-=");
            Console.WriteLine("Lista definida [1, 2, 3, 4, 5, 6, 7, 8, 9, 10] \n");
            Console.WriteLine("- Primeiro Método [1]");
            Console.WriteLine("- Segundo Método [2]");
            Console.WriteLine();

            Console.Write("Digite sua opção: ");
            int opcao = int.Parse(Console.ReadLine());

            List<int> lista = new List<int>() {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            Console.WriteLine("\n Lista original: ");
            foreach (int elemento in lista)
            {
                Console.Write($"{elemento} ");
            }

            Console.WriteLine();

            if (opcao == 1)
            {
                float media = CalculaMedia(lista, 0);
                Console.WriteLine($"Média:  {media} ");
                int num = MaioresMedia(lista, 0, media);
                Console.WriteLine($"Número de elementos maiores do que a média: {num}");
            }
            else if (opcao == 2)
            {
                List<int> listAux = Inverter(lista, 0);
                Console.WriteLine("Lista invertida:");
                foreach (int elemento in listAux)
                {
                    Console.Write($"{elemento} ");
                }
            }
            else
            {
                Console.WriteLine("Opção inválida!");
            }

            Console.Read();
        }

        public static int MaioresMedia(List<int> lista, int index, float media)
        {
            int maior = lista[index] > media ? 1 : 0;
            if (index == (lista.Count - 1))
            {
                return maior;
            }

            return maior + MaioresMedia(lista, ++index, media);
        }

        public static float CalculaMedia(List<int> lista, int index)
        {
            float media = (float) lista[index] / lista.Count;
            if (index == (lista.Count - 1))
            {
                return media;
            }

            return media + CalculaMedia(lista, ++index);
        }

        public static List<int> Inverter(List<int> lista, int index)
        {
            if (index == lista.Count)
            {
                return lista;
            }

            lista.Insert(index++, lista[lista.Count - 1]);
            lista.RemoveAt(lista.Count - 1);
            
            return Inverter(lista, index);
        }
    }
}