using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poo.Models
{
    public class Pessoa
    {
        public Pessoa()
        {

        }
        public Pessoa(string nome, string sobrenome)
        { 
            Nome = nome;
            Sobrenome = sobrenome;
        }
        public void Deconstruct(out string nome, out string sobrenome)
        {
            nome = Nome;
            sobrenome = Sobrenome;
        }

        private string _nome; // Atributo
        private int _idade; // Atributo
        


        public string Nome
        {
            get
            {
                return _nome.ToUpper();
            }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                else
                {
                    _nome = value;
                }
            }
        }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
        public string Sobrenome { get; set; }
        public int Idade
        {
            get => _idade;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser negativa");
                }
                else
                {
                    _idade = value;
                }
            }
        }
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {NomeCompleto} e tenho {Idade} anos.");
        }
    }
   
}