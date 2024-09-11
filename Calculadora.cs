using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace NewTalents
{
    public class Calculadora
    {
        private List<string> listaHistorico { get; set; }
        private string data;

        public Calculadora(string data)
        {
            listaHistorico = new List<string>();
            this.data = data;
        }

        public int somar(int val1, int val2)
        {
            int result = val1 + val2;

            listaHistorico.Insert(0, $"Resultado: {result} - data: {data}");

            return result;
        }

        public int subtrair(int val1, int val2)
        {
            int result = val1 - val2;

            listaHistorico.Insert(0, $"Resultado: {result} - data: {data}");

            return result;
        }

        public int multiplicar(int val1, int val2)
        {
            int result = val1 * val2;

            listaHistorico.Insert(0, $"Resultado: {result} - data: {data}");

            return result;
        }

        public int dividir(int val1, int val2)
        {
            int result  = val1 / val2;

            listaHistorico.Insert(0, $"Resultado: {result} - data: {data}");

            return result;
        }

        public List<string> historico()
        {
            listaHistorico.RemoveRange(3, listaHistorico.Count - 3);

            return listaHistorico;
        }
    }
}
