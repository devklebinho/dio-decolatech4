using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemplo_fundamentos.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public string Apresentar()
        {
            return $"Dale, eu sou o {Nome} e tenho {Idade} anos";
        }
    }
}