using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Vetores_Parte2 {
    class Produto {        
        public string Nome { get; set; }
        private double Preco { get; set; }

        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }

        public double GetSoma() {
            double soma = 0.0;
            soma += Preco;
            return soma;
        }

    }
}
