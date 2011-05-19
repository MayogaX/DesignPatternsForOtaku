using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    public interface Profissao
    {
        public String nome { get; set; }
        public Int32 forca { get; set; }
        public Int32 velocidade { get; set; }
        public Int32 magia { get; set; }

        public void usaHabilidadeEspecial();
    }

    public class Mago
    {

    }
}
