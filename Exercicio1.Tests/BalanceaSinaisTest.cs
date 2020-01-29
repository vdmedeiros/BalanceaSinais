using Exercicio1.Sinais;
using System;
using Xunit;

namespace Exercicio1.Tests
{
    public class BalanceaSinaisTest
    {
        [Fact]
        public void Sinais_balanceados_ok()
        {
            var sinais = new BalanceaSinal();
            Assert.True(sinais.SinaisBalanceados("{{[[(())]]}}"));
        }

        [Fact]
        public void Sinais_balanceados_ok2()
        {
            var sinais = new BalanceaSinal();
            Assert.True(sinais.SinaisBalanceados("{{([(())])}}"));
        }

        [Fact]
        public void Sinais_balanceados_ok3()
        {
            var sinais = new BalanceaSinal();
            Assert.True(sinais.SinaisBalanceados("[{({{([({})])}})}]"));
        }

        [Fact]
        public void Sinais_balanceados_ok4()
        {
            var sinais = new BalanceaSinal();
            Assert.True(sinais.SinaisBalanceados("{{([({{([({[()]})])}})])}}"));
        }

        [Fact]
        public void Sinais_balanceados_nok()
        {
            var sinais = new BalanceaSinal();
            Assert.False(sinais.SinaisBalanceados("{[[[(())]]}}"));
        }

        [Fact]
        public void Sinais_balanceados_nok2()
        {
            var sinais = new BalanceaSinal();
            Assert.False(sinais.SinaisBalanceados("{([(((()))))]}"));
        }

        [Fact]
        public void Sinais_balanceados_nok3()
        {
            var sinais = new BalanceaSinal();
            Assert.False(sinais.SinaisBalanceados("{{([({{([{{[()]})])}})])}}"));
        }

        [Fact]
        public void Sinais_balanceados_nok4()
        {
            var sinais = new BalanceaSinal();
            Assert.False(sinais.SinaisBalanceados("{[(])}"));
        }
    }
}
