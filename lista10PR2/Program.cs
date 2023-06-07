using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista10PR2
{
    internal class Program
    {
        public static void Exercicio1()
        {
            Console.Write("Digite o tamanho do vetor: ");
            int n = int.Parse(Console.ReadLine());

            float[] vetor = new float[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite o número {0}: ", i + 1);
                vetor[i] = float.Parse(Console.ReadLine());
            }

            float menor = vetor[0];
            float maior = vetor[0];
            float soma = vetor[0];

            for (int i = 1; i < n; i++)
            {
                if (vetor[i] < menor)
                    menor = vetor[i];
                if (vetor[i] > maior)
                    maior = vetor[i];

                soma += vetor[i];
            }

            float media = soma / n;

            Console.WriteLine("Menor número: " + menor);
            Console.WriteLine("Maior número: " + maior);
            Console.WriteLine("Média aritmética: " + media);
        }
        public static void Exercicio2()
        {
            Console.Write("Digite o tamanho do vetor: ");
            int n = int.Parse(Console.ReadLine());

            while (n <= 0)
            {
                Console.WriteLine("O tamanho do vetor precisa ser maior que zero. Tente novamente.");
                Console.Write("Digite o tamanho do vetor: ");
                n = int.Parse(Console.ReadLine());
            }

            float[] vetor = new float[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite o número {0}: ", i + 1);
                vetor[i] = float.Parse(Console.ReadLine());
            }

            float soma = 0;

            for (int i = 0; i < n; i++)
            {
                soma += vetor[i];
            }

            float media = soma / n;

            Console.WriteLine("\nNúmeros maiores ou iguais à média:");

            for (int i = 0; i < n; i++)
            {
                if (vetor[i] >= media)
                {
                    Console.WriteLine(vetor[i]);
                }
            }
        }
        public static void Exercicio3()
        {
            Console.Write("Digite o tamanho do vetor: ");
            int n = int.Parse(Console.ReadLine());
            Random rand = new Random();

            while (n <= 0)
            {
                Console.WriteLine("O tamanho do vetor precisa ser maior que zero. Tente novamente.");
                Console.Write("Digite o tamanho do vetor: ");
                n = int.Parse(Console.ReadLine());
            }

            float[] vetor = new float[n];

            for (int i = 0; i < n; i++)
            {
                
                vetor[i] = rand.Next(10, 50);

            }

            float soma = 0;

            for (int i = 0; i < n; i++)
            {
                soma += vetor[i];
            }

            float media = soma / n;

            Console.WriteLine("\nNúmeros maiores ou iguais à média:");

            for (int i = 0; i < n; i++)
            {
                if (vetor[i] >= media)
                {
                    Console.WriteLine(vetor[i]);
                }
            }
        } 
        public static void Exercicio4()
        {
            Console.Write("Digite o número de assinaturas: ");
            int n = int.Parse(Console.ReadLine());

            string[] lista = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite o nome da assinatura {0}: ", i + 1);
                lista[i]= Console.ReadLine();
                
            }
            for (int i = n - 1; i >= 0; i--)
            {

                Console.WriteLine("posição [{0}] = {1}", i, lista[i]);


            }
        }
        public static void Exercicio5()
        {
            Console.Write("Digite o tamanho do vetor: ");
            int n = int.Parse(Console.ReadLine());
            Random rand = new Random();

            while (n <= 0)
            {
                Console.WriteLine("O tamanho do vetor precisa ser maior que zero. Tente novamente.");
                Console.Write("Digite o tamanho do vetor: ");
                n = int.Parse(Console.ReadLine());
            }

            float[] vetor = new float[n];

            for (int i = 0; i < n; i++)
            {

                vetor[i] = rand.Next(10, 50);

            }
   
            int In = 0, P = 0;

            for (int i = 0; i < n; i++)
            {
                
                if (vetor[i] % 2 == 0)
                {
                   PARES = PARES + 1;
                }
                else
                {
                    In = In + 1;
                }
                Console.WriteLine("a soma dos pares é" + P);
                Console.WriteLine("a soma dos impares é" + In);
                Console.ReadKey();
            }
        }
            static void Main(string[] args)
        {
            int opcao;

            do
            {
               
                Console.WriteLine("==================menu=================");
                Console.WriteLine("para sair digite 0");
                Console.WriteLine("para executar o exercicio 1 - digite 1");
                Console.WriteLine("para executar o exercicio 2 - digite 2");
                Console.WriteLine("para executar o exercicio 3 - digite 3");
                Console.WriteLine("para executar o exercicio 4 - digite 4");
                Console.WriteLine("para executar o exercicio 5 - digite 5");
                Console.WriteLine("======================================");
                opcao = int.Parse(Console.ReadLine());
                

                switch (opcao)
                {
                    case 1:
                        Exercicio1();
                        break; 
                    case 2:
                        Exercicio2();
                        break;
                    case 3:
                        Exercicio3();
                        break; 
                    case 4:
                        Exercicio4();
                        break;
                    case 5:
                        Exercicio5();
                        break;
                    default:
                        Console.WriteLine("o numero não é um exercicio valido");
                        break;
                }

            } while (opcao != 0);
        }
    }
}
