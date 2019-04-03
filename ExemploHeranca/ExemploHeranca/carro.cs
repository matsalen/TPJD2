using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHeranca
{
    class carro : veiculo
    {      
        public String Combustivel { set; get; }      
        public Byte Portas { set; get; }     

        public carro() { }

        public void DarSeta() { }

        public override void Acelera()
        {
            // PISANDO NO ACELERADOR
        }

        public override void Freia()
        {
            // PISANDO NO FREIO
        }

        public override void TrocaMarcha()
        {
           // PISANDO NA EMBREAGEM E MOVENDO O CAMBIO
        }
    }
}
