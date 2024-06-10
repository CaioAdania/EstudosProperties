using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosProperties.Entities
{
    internal class Teste
    {

        private string _nome;
        private double _preco;
        private int _quantidade;


        public Teste(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;

        }

        public string Nome //propriedade
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value; //O value equivale ao parâmetro que seria o modificador
                }
            }
        }


        public double Preco //por não existir o set, não é possivel alterar
        {
            get { return _preco; }
        }

        public int Quantidade //por não existir o set, não é possivel alterar
        {
            get { return _quantidade; }
        }
    }
}
