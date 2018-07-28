using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03CS
{
    class TotalDeTributos
    {
        public double totalTributos { get; private set; }

        public void Adiciona (Tributavel conta)
        {
            totalTributos += conta.CalculaTributo();
        }
    }
}
