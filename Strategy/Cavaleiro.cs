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
        public string nome
        {
            get
            {
                return this.nome;
            }
            set
            {
                this.nome = value;
            }
        }
        Int32 comos;

        public void usaHabilidadeEspecial()
        {
            Console.WriteLine("Poder especial que não mata inguém!");
        }
        public void aumentaCosmo()
        {
        }
    }

    public class Prata : Cavaleiro
    {
        Int32 cosmo;

        public string nome
        {
            get
            {
                return this.nome;
            }
            set
            {
                this.nome = value;
            }
        }

        public void usaHabilidadeEspecial()
        {
            throw new NotImplementedException();
        }

        public void aumentaCosmo()
        {
        }
    }

    public class Ouro : Cavaleiro
    {
        Int32 cosmo;

        public string nome
        {
            get
            {
                return this.nome;
            }
            set
            {
                this.nome = value;
            }
        }

        public void usaHabilidadeEspecial()
        {
            throw new NotImplementedException();
        }

        public void aumentaCosmo()
        {
        }
    }
}
