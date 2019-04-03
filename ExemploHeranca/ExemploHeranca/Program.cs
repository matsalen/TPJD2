using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            carro gol = new carro();
            gol.Marca = "Volkswagen";
            gol.Acelera();

            bicicleta bike = new bicicleta();
            bike.Acelera();

        }
    }
}
