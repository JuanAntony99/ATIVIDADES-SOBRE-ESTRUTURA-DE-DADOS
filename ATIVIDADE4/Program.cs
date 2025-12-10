using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIVIDADE4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> historicoAcoes = new Stack<string>(); // Pilha para Desfazer.
            Queue<string> filaImpressao = new Queue<string>(); // Fila para impressora.

            while (true)
            {
                Console.WriteLine("\n1. Escrever Texto (Add Ação)");
                Console.WriteLine("2. Desfazer (Undo)");
                Console.WriteLine("3. Enviar para Impressão");
                Console.WriteLine("4. Imprimir Próximo (Impressora)");
                Console.Write("Escolha: ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Write("Digite a ação feita: ");
                        string acao = Console.ReadLine();
                        historicoAcoes.Push(acao);
                        Console.WriteLine("Ação registrada.");
                        break;

                    case "2":
                        if (historicoAcoes.Count > 0)
                        {
                            string desfeita = historicoAcoes.Pop();
                            Console.WriteLine($"Desfeito: {desfeita}");
                        }
                        else
                        {
                            Console.WriteLine("Nada para desfazer.");
                        }
                        break;

                    case "3":
                        Console.WriteLine("Nome do documento: ");
                        string doc = Console.ReadLine();
                        filaImpressao.Enqueue(doc);
                        Console.WriteLine("Documento na fila.");
                        break;

                    case "4":
                        {
                            if (filaImpressao.Count > 0)
                            {
                                string imp = filaImpressao.Dequeue();
                                Console.WriteLine($"\nImprimindo: {imp}\n");

                                if (filaImpressao.Count > 0)
                                {
                                    Console.WriteLine($"Próximo item: {filaImpressao.Peek()}");
                                    Console.WriteLine($"Itens restantes: {filaImpressao.Count}");
                                }
                                else
                                {
                                    Console.WriteLine("Nenhum documento restante na fila.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Fila vazia.");
                            }
                            break;
                        }
                }
            }
        }
    }
}
