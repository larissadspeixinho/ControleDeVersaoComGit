using System;
using System.Collections.Generic;

namespace ControleDeVersaoComGit.Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(DateTime.Now.ToLongDateString().ToUpper());
            var central = new CentralDeExercicios(new Dictionary<string, Action>()
            {
                {"Calculadora", Calculadora.Executar},
            });
            central.SelecionarEExecutar();
        }
    }
}