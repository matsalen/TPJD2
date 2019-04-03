using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroInimigo
{
    class Heroi : Personagem
    {
        public Byte Level { set; get; }

        public Heroi() { }

        public override void Atacar()
        {
            Console.WriteLine("Balanço da espada");
        }

        public override void Correr()
        {
            Console.WriteLine("Heroi correndo");
        }
    }
}
