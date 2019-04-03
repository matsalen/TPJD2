using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroInimigo
{
    abstract class Personagem
    {
        public String Nome { set; get; }
        public Byte HP { set; get; }
        public Byte Moedas { set; get; }
        public Byte Ataque { set; get; }

        public Personagem() { }

        abstract public void Correr();
        abstract public void Atacar();

    }
}
