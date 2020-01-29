using System;

namespace Exercicio1.Sinais
{
    public class BalanceaSinal
    {
        public bool SinaisBalanceados(string sinais)
        {
            bool resultado = false;
            if (sinais.Length > 1)
                resultado = (sinais.IndexOf("()") >= 0 || sinais.IndexOf("[]") >= 0 || sinais.IndexOf("{}") >= 0) &&
                             SinaisBalanceados(sinais.Replace("()", "").Replace("[]", "").Replace("{}", ""));
            else if (sinais.Length == 1)
                resultado = false;
            else
                resultado = true;
            return resultado;
        }
    }
}
