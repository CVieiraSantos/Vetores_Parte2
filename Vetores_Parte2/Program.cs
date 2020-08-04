using System;
using System.Globalization;

namespace Vetores_Parte2 {
    class Program {
        public static double preco { get; private set; }

        static void Main(string[] args) {
            int n;                       
            n = int.Parse(Console.ReadLine());
            Produto[] vet = new Produto[n];
            
            for (int i = 0; i<n; i++) {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vet[i] = new Produto(nome, preco);
            }

            double soma = 0.0;
            for (int i = 0; i < n; i++) {
                soma += vet[i].GetSoma();                
                Console.WriteLine("Soma = " + soma.ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}
