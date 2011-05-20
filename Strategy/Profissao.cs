using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    public interface Profissao
    {
         String nome { get; set; }
         Int32 forca { get; set; }
         Int32 velocidade { get; set; }
         Int32 magia { get; set; }

         void usaHabilidadeEspecial();
    }

    public class Mago : Profissao
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

        public int forca
        {
            get
            {
                return this.forca;
            }
            set
            {
                this.forca = value;
            }
        }

        public int velocidade
        {
            get
            {
                return this.velocidade;
            }
            set
            {
                this.velocidade = value;
            }
        }

        public int magia
        {
            get
            {
                return this.magia;
            }
            set
            {
                this.magia = value;
            }
        }

        public void usaHabilidadeEspecial()
        {
            throw new NotImplementedException();
        }
    }

    public class Cavaleiro : Profissao
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

        public int forca
        {
            get
            {
                return this.forca;
            }
            set
            {
                this.forca = value;
            }
        }

        public int velocidade
        {
            get
            {
                return this.velocidade;
            }
            set
            {
                this.velocidade = value;
            }
        }

        public int magia
        {
            get
            {
                return this.magia;
            }
            set
            {
                this.magia = value;
            }
        }

        public void usaHabilidadeEspecial()
        {
            throw new NotImplementedException();
        }
    }

}
