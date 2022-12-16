using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section4
{
    internal class AlunoA45Ex3
    {
        public string Nome;
        public double NotaPrimeiroTrim;
        public double NotaSegundoTrim;
        public double NotaTerceiroTrim;

        public double NotaFinal()
        {
            return NotaPrimeiroTrim + NotaSegundoTrim + NotaTerceiroTrim;
        }

        public string StatusAluno()
        {
            if (NotaFinal() >= 60.0)
                return "APROVADO";
            else
                return $"REPROVADO\nFALTARAM {(60.0 - NotaFinal()).ToString("F2", CultureInfo.InvariantCulture)} PONTOS";
        }
    }
}
