using System;

namespace JogoForca
{
    internal class Program
    {
        static string[] palavraCerta;
        static string[] teste;
        static string letraUsuario;


        static void Main(string[] args)
        {
            Console.WriteLine("palavra");

            string palavra = Console.ReadLine();

            palavraCerta = new string[palavra.Length];

            teste = new string[palavraCerta.Length];

            for (int i = 0; i < palavraCerta.Length; i++)
            {
                teste.SetValue(palavra.Substring(i,1),i);
                Console.WriteLine($" cada letra da palavra {teste[i]}");
            }
        }
    }
}