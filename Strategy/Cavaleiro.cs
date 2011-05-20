using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    public interface Cavaleiro
    {
         String nome { get; set; }

         void aumentaCosmo();
         void usaHabilidadeEspecial();

    }

    public class Bronze : Cavaleiro
    {
        public string nome { get; set; }
        Int32 comos { get; set; }

        public void usaHabilidadeEspecial()
        {
            Console.WriteLine("Poder especial na velocidade do som!");
        }
        public void aumentaCosmo()
        {

        }
    }

    public class Prata : Cavaleiro
    {
        public string nome { get; set; }
        Int32 comos { get; set; }

        public void usaHabilidadeEspecial()
        {
            Console.WriteLine("Poder especial que matador!!");
        }
        public void aumentaCosmo()
        {

        }
    }

    public class Ouro : Cavaleiro
    {
        public string nome { get; set; }
        Int32 comos { get; set; }

        public void usaHabilidadeEspecial()
        {
            Console.WriteLine("Poder especial na velocidade da luz!!!");
        }
        public void aumentaCosmo()
        {

        }
    }
}
