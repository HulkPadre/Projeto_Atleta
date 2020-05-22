using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Atleta
{
    class Atleta
    {
        private string nome;
        private double altura, peso;
        private int idade;

        public string Nome
        {
            set
            {
                if (value != string.Empty)
                {
                    this.nome = value;
                }
                else
                {
                    throw new Exception("O nome deve ser obrigatoriamente preenchido.");
                }
            }
            get { return this.nome; }
        }

        public double Altura
        {
            set
            {
                if (value >= 1)
                {
                    this.altura = value;
                }
                else
                {
                    throw new Exception("A altura dever ser de pelo menos 1 metro");
                }
            }
            get { return this.altura; }
        }

        public double Peso
        {
            set
            {
                if (value > 1)
                {
                    this.peso = value;
                }
                else
                {
                    throw new Exception("A altura dever ser de pelo menos 1 metro");
                }
            }
            get { return this.peso; }
        }

        public int Idade
        {
            set
            {
                if (value >= 1)
                {
                    this.idade = value;
                }
                else
                {
                    throw new Exception("A idade tem que pelo menos 1 ano");
                }
            }
            get { return this.idade; }
        }

        public string ImprimeDados()
        {
            return "Dados da pessoa: \n Nome: " + this.nome +
            "\nAltura" + this.altura + "m" + "\nPeso: " + this.peso.ToString("0.00") +
            "\nIdade: " + this.idade;
        }

        public double CalcularIMC()
        {

            return (this.peso / Math.Pow(this.altura, 2));

        }
    }
}
