using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_CarWash
{
    class Carro
    {
        public string matricula { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public int ano;
        public DateTime lavagem { get; set; }
        public string tipoLavagem { get; set; }

        public Carro() { }
        public Carro(string matricula, string marca, string modelo, int ano, DateTime lavagem, string tipoLavagem)
        {
            this.matricula = matricula;
            this.marca = marca;
            this.modelo = modelo;
            if (!setAno(ano)) ano = DateTime.Now.Year;
            this.lavagem = lavagem;
            this.tipoLavagem = tipoLavagem;
        }
        public Carro(Carro c)
        {
            this.matricula = c.matricula;
            this.marca = c.marca;
            this.modelo = c.modelo;
            this.ano = c.ano;
            this.lavagem = c.lavagem;
            this.tipoLavagem = c.tipoLavagem;
        }

        public int getAno()
        {
            return ano;
        }

        public bool setAno(int ano)
        {
            if (ano > 1500 && ano < DateTime.Now.Year)
            {
                this.ano = ano;
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            return $"#####Carro######" +
                $"\nMatricula: {matricula}" +
                $"\nMarca: {marca}" +
                $"\nModelo: {modelo}" +
                $"\nAno: {ano}" +
                $"\nData de lavagem: {lavagem}" +
                $"\nTipo de lavagem: {tipoLavagem}" +
                $"\n################";
        }
    }
}
