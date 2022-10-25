using System;

namespace JogoForca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> letrasPalavra = new List<string>();
            string palavraSecreta = "banana".ToUpper();
            string chuteUsuario;

            for (int i = 0; i < palavraSecreta.Length; i++)
            {
                letrasPalavra.Add("_ ");
            }

            foreach (var letras in letrasPalavra)
            {
                Console.Write(letras);
            }

            bool perdeu = false;
            bool acertou = false;
            int tentativas = 0;

            while (!acertou && !perdeu)
            {
                Console.Write("\n digite uma letra \n");
                chuteUsuario = Console.ReadLine().ToUpper();

                if (palavraSecreta.Contains(chuteUsuario))
                {
                    for (int i = 0; i < palavraSecreta.Length; i++)
                    {
                        if (palavraSecreta[i].ToString() == chuteUsuario)
                        {
                            letrasPalavra[i] = chuteUsuario;
                        }
                    }
                }
                else
                {
                    tentativas++;
                    Console.WriteLine(tentativas);
                }

                foreach (var letras in letrasPalavra)
                {
                    Console.Write(letras);

                }

                Console.WriteLine();

                if (!letrasPalavra.Contains("_ "))
                {
                    Console.WriteLine("ganhou o jogo");
                    acertou = true;

                }

                perdeu = tentativas == 6;
            }
            if (perdeu)
            {
                Console.WriteLine("vc perdeu todas as chances");
            }
        }
    }
}