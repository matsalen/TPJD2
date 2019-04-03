using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroInimigo
{
    class Inimigo : Personagem
    {
        public Boolean Transformacao { set; get; }

        public Inimigo() { }

        public override void Atacar()
        {
            Console.WriteLine("Espetada de lança");
        }

        public override void Correr()
        {
            Console.WriteLine("Inimigo correndo");
        }

        public void Transformar()
        {
            Console.WriteLine("Inimigo se transformou");
        }
    }
}
