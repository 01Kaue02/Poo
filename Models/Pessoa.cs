using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poo.Models
{
    public class Pessoa
    {
        private string _nome; // Atributo
        


        public string Nome
        {
            get {
                return _nome.ToUpper();
            }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException ("O nome não pode ser vazio");
                }
                else
                {
                    _nome = value;
                }
            }
        }
        public int Idade { get; set; }
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
        }
    }
   
}