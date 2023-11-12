using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Models
{
    public class CalculadoraModel
    {
        private List<string> listaHistorico;

        public CalculadoraModel()
        {
            listaHistorico = new List<string>();
        }
        public int Somar(int n1, int n2)
        {
            int res = n1 + n2;
            InserirResultadoNaLista(res);
            return res;
        }

        public int Subtrair(int n1, int n2)
        {
            int res = n1 - n2;
            InserirResultadoNaLista(res);
            return res;
        }

        public int Multiplicar(int n1, int n2)
        {
            int res = n1 * n2;
            InserirResultadoNaLista(res);
            return res;
        }

        public int Dividir(int n1, int n2)
        {
            if (n2 == 0)
            {
                throw new DivideByZeroException("Divisão por zero não permitida");
            }

            int res = n1 / n2;
            InserirResultadoNaLista(res);
            return res;
        }

        private void InserirResultadoNaLista(int res)
        {
            listaHistorico.Insert(0, "Resultado: " + res);
        }

        public List<string> historico()
        {
            listaHistorico.RemoveRange(3, listaHistorico.Count - 3);
            return listaHistorico;
        }
    }
}