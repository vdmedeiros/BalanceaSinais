using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercicio2.Soldado
{
    public class JogoSobrevivencia
    {
        public int Posicao { get; set; }
        public bool Executado { get; set; }

        public int PosicaoSobrevivencia(int quantidadeSoldados)
        {
            var ll = new LinkedList<int>(Enumerable.Range(1, quantidadeSoldados).ToList());
            var assassino = ll.First;
            return ExecutarMatanca(ll, assassino);
        }

        private int ExecutarMatanca(LinkedList<int> ll, LinkedListNode<int> assassino)
        {
            int posicaoSobrevivente = 0;
            if (ll.Count > 1)
            {
                var vitima = assassino.Next ?? ll.First;
                //Console.WriteLine($"{assassino.Value} matou {vitima.Value}");
                var novoAssassino = vitima.Next ?? ll.First;
                ll.Remove(vitima);
                posicaoSobrevivente = ExecutarMatanca(ll, novoAssassino);
            }
            else
            {
                posicaoSobrevivente = ll.First.Value;
            }
            return posicaoSobrevivente;
        }
    }
}
