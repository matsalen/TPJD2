using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHeranca
{
    class bicicleta : veiculo
    {       
        public Boolean Garupa { set; get; }
        public Boolean Sinalizador { set; get; }

        public bicicleta() { }

        public void Empinar() { }

        public override void Acelera()
        {
            // PEDALAR MAIS FORTE
        }

        public override void Freia()
        {
           // CHINELO NA RODA
        }

        public override void TrocaMarcha()
        {
            // USANDO O CAMBIO
        }
    }
}
