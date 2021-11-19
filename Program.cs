using System;

namespace dotnetcore
{
    class Program
    {
        // Exercício 1:
        // - Fazer a média de notas dos dois alunos (Zuqui, Bronza) e imprimir no Console.WriteLine();
        // - Imprimir no console para cada aluno
        //      - Nome do aluno
        //      - Caso média maior ou igual 7:
        //          - Passou no ano letivo
        //          - Não passou no ano letivo
        // Requisítos:
        // - Criar um método "CalcularMedia", onde a entrada de parâmetros seja as notas e o retorno seja a média em float
        // - Utilizar For ou Foreach
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando Programa");

            var xNotasZuqui = new int[] { 7, 6, 5, 3 };
            var xNotasBronza = new int[] { 8, 9, 10, 8 };
        }
    }
}
