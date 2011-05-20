using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    public class Personagem
    {
        public String nome { get; set; }
        public Int32 idade { get; set; }
        public Cavaleiro cavaleiro { get; set; }
    }
}
