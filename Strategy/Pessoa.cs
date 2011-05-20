using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    public abstract class Pessoa
    {
        public String nome { get; set; }
        public Int32 idade { get; set; }
        public Profissao profissao { get; set; }
        public abstract void usaHabilidadeEspecial();
    }
}
