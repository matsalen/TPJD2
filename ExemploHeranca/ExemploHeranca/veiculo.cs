using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHeranca
{
    abstract class veiculo
    {
        public String Marca { set; get; }
        public String Modelo { set; get; }
        public Int32 Ano { set; get; }
        public Byte Marcha { set; get; }

        public veiculo() { }

        abstract public void Acelera();
        abstract public void Freia();
        abstract public void TrocaMarcha();
    }
}
