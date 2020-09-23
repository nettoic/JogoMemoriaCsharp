using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoMemoria
{
    public class Jogador
    {
        public string Nome { get; set; }
        public int Tempo { get; set; } = 0;
        public string Nivel { get; set; } = "";
        public bool Fim { get; set; } = false;
    }
}
