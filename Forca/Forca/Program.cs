using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forca
{
    class Program
    {
        static void Main(string[] args)
        {
            Random sorteio = new Random();
            String[] linhas = File.ReadAllLines("palavras.txt");
            Char[] palavraOculta = linhas.ElementAt(sorteio.Next(0, linhas.Length)).ToCharArray();

            Char[] palavra = new char[palavraOculta.Length];

            for (byte abacaxi = 0; abacaxi < palavra.Length; abacaxi++)
            {
                palavra[abacaxi] = '_';
            }

            Char letra;
            Byte letrasDaPalavra = 0;
            Boolean notificaMudanca = false;
            Byte erros = 0;

            do
            {
                ImprimeJogo(palavra, erros);
                Console.Write("Digite uma letra: ");
                letra = (Console.ReadLine())[0];

                for (Byte i = 0; i < palavraOculta.Length; i++)
                {
                    if (palavraOculta[i] == letra)
                    {
                        palavra[i] = letra;
                        letrasDaPalavra++;
                        notificaMudanca = true;
                    }
                }

                if (!notificaMudanca)
                {
                    erros++;
                }
                else
                {
                    notificaMudanca = false;
                }
            } while (letrasDaPalavra < palavraOculta.Length && erros < 6);

            ImprimeJogo(palavra, erros);

            if (letrasDaPalavra < palavraOculta.Length)
            {
                //GAME OVER
                Console.WriteLine();
                Console.WriteLine("Você perdeu.");
                Console.WriteLine();
                Console.Write("A palavra era: ");
                Console.WriteLine(palavraOculta);
            }
            else
            {
                // VITORIA
                Console.WriteLine();
                Console.WriteLine("Vitoria");
            }
            Console.ReadKey();
        }

        static void ImprimeJogo(Char[] palavra, Byte erros)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("### FORCA ###");
            Console.WriteLine();
            Console.WriteLine(" _______ ");
            Console.WriteLine(" |     | ");

            // IMPRIME CABEÇA
            if (erros > 0)
            {
                Console.WriteLine(" |     O ");
            }
            else
            {
                Console.WriteLine(" |       ");
            }

            // IMPRIME CORPO E BRAÇOS
            if (erros > 1)
            {
                if (erros > 2)
                {
                    if (erros > 3)
                    {
                        Console.WriteLine(@" |    /|\");                        
                    }
                    else
                    {
                        Console.WriteLine(" |    /| ");                        
                    }
                }
                else
                {
                    Console.WriteLine(" |     | ");                    
                }
                Console.WriteLine(" |     | ");
            }
            else
            {
                Console.WriteLine(" |       ");
                Console.WriteLine(" |       ");
            }

            // IMPRIME AS PERNAS
            if (erros > 4)
            {
                if (erros > 5)
                {
                    Console.WriteLine(@" |    / \");
                }
                else
                {
                    Console.WriteLine(" |    /  ");
                }
            }
            else
            {
                Console.WriteLine(" |       ");
                Console.WriteLine(" |       ");
            }
            Console.WriteLine(" |       ");

            Console.WriteLine();
            Console.WriteLine(palavra);
            Console.WriteLine();
        }
    }
}
