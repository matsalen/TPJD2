using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaracterAndando
{
    class Program
    {
        static void Main(string[] args)
        {
            // CRIA INSTANCIA DA CLASSE CARACTER (CLASSE CRIADA)
            Caracter Player = new Caracter("q", "p");
            Cenario cenario = new Cenario("_", 60);
            ConsoleKey tecla;

            cenario.Imprime(Player);

            do
            {
                tecla = Console.ReadKey().Key;
                switch (tecla)
                {
                    case ConsoleKey.LeftArrow:
                        // ESQUERDA
                        Player.anda(false, cenario.Tamanho);
                        cenario.Imprime(Player);
                        break;
                    case ConsoleKey.RightArrow:
                        // DIREITA
                        Player.anda(true, cenario.Tamanho);
                        cenario.Imprime(Player);
                        break;
                    case ConsoleKey.UpArrow:
                        // PULA
                        Player.Pulando = true;
                        cenario.Imprime(Player);
                        Player.pula();
                        Player.Pulando = false;
                        cenario.Imprime(Player);
                        break;
                    default:
                        cenario.Imprime(Player);
                        break;
                }
            } while (tecla != ConsoleKey.Escape);

            Console.ReadKey();
        }
    }
}
