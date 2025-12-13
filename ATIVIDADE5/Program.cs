using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIVIDADE5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o caminho de uma pasta (Ex: C:\\Windows\\Web ou . para atual:");
            string caminhoInicial = Console.ReadLine();

            if (caminhoInicial == ".")
            {
                caminhoInicial = Directory.GetCurrentDirectory();
            }

            try
            {
                Console.WriteLine($"\nExplorando: {caminhoInicial}\n");
                ExplorarDiretorios(caminhoInicial, 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao acessar a pasta: {ex}");
            }
        }
            static void ExplorarDiretorios(string caminho, int nivel)
            {
                try
                {
                    string indentacao = new string('-', nivel * 2);

                    string[] arquivos = Directory.GetFiles(caminho);
                    foreach(string arquivo in arquivos)
                    {
                        Console.WriteLine($"{indentacao} 📄 {Path.GetFileName(arquivo)}");
                    }

                    string[] subDiretorios = Directory.GetDirectories(caminho);
                    foreach(string dir in subDiretorios)
                    {
                        Console.WriteLine($"{indentacao} 📁 {Path.GetFileName(dir)}");
                        ExplorarDiretorios(dir, nivel + 1);
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    
                }
            }
        }
    }

