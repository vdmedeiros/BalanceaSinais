using Exercicio2.Soldado;
using System;
using Xunit;

namespace Exercicio.Tests
{
    public class JogoSobrevivenciaTest
    {
        [Fact]
        public void Posicao_Sobrevivencia_5Soldados_ok()
        {
            var jogo = new JogoSobrevivencia();
            int posicaoSobrevivencia = jogo.PosicaoSobrevivencia(5);
            Assert.Equal(3, posicaoSobrevivencia);
        }

        [Fact]
        public void Posicao_Sobrevivencia_10Soldados_ok()
        {
            var jogo = new JogoSobrevivencia();
            int posicaoSobrevivencia = jogo.PosicaoSobrevivencia(10);
            Assert.Equal(5, posicaoSobrevivencia);
        }
        
        [Fact]
        public void Posicao_Sobrevivencia_41Soldados_ok()
        {
            var jogo = new JogoSobrevivencia();
            int posicaoSobrevivencia = jogo.PosicaoSobrevivencia(41);
            Assert.Equal(19, posicaoSobrevivencia);
        }

        [Fact]
        public void Posicao_Sobrevivencia_5Soldados_nok()
        {
            var jogo = new JogoSobrevivencia();
            int posicaoSobrevivencia = jogo.PosicaoSobrevivencia(5);
            Assert.NotEqual(4, posicaoSobrevivencia);
        }

        [Fact]
        public void Posicao_Sobrevivencia_10Soldados_nok()
        {
            var jogo = new JogoSobrevivencia();
            int posicaoSobrevivencia = jogo.PosicaoSobrevivencia(10);
            Assert.NotEqual(7, posicaoSobrevivencia);
        }

        [Fact]
        public void Posicao_Sobrevivencia_41Soldados_nok()
        {
            var jogo = new JogoSobrevivencia();
            int posicaoSobrevivencia = jogo.PosicaoSobrevivencia(41);
            Assert.NotEqual(20, posicaoSobrevivencia);
        }
    }
}
