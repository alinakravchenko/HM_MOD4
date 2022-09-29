using System;
using System.Threading;
namespace TICTACTOE
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] number = new string[9] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            int flag = 0;

            for (int step = 0; step < 9; step++)
            {
                Console.Clear();

                Console.Write("PLAYER 1 --> X\n");
                Console.Write("PLAYER 2 --> O");

                Console.WriteLine("\n\n{0}\t{1}\t{2}\n{3}\t{4}\t{5}\n{6}\t{7}\t{8}", number[0], number[1], number[2], number[3], number[4], number[5], number[6], number[7], number[8]);

                do
                {
                    Console.Write("\nВведите номер ячейки: ");
                    flag = Int32.Parse(Console.ReadLine());

                } while ((flag <= 0) || (flag >= 10) || (number[flag - 1] == "X") || (number[flag - 1] == "O"));

                if ((step % 2 == 0))
                {
                    number[flag - 1] = "X";
                }
                else if ((step % 2 != 0))
                {
                    number[flag - 1] = "O";
                }

                if (((number[0] == "X") && (number[1] == "X") && (number[2] == "X")) || ((number[3] == "X") && (number[4] == "X") && (number[5] == "X")) || ((number[6] == "X") && (number[7] == "X") && (number[8] == "X")) || ((number[0] == "X") && (number[3] == "X") && (number[6] == "X")) || ((number[1] == "X") && (number[4] == "X") && (number[7] == "X")) || ((number[2] == "X") && (number[5] == "X") && (number[8] == "X")) || ((number[0] == "X") && (number[4] == "X") && (number[8] == "X")) || ((number[2] == "X") && (number[4] == "X") && (number[6] == "X")))
                {
                    Console.Clear();
                    Console.WriteLine("\n{0}\t{1}\t{2}\n{3}\t{4}\t{5}\n{6}\t{7}\t{8}", number[0], number[1], number[2], number[3], number[4], number[5], number[6], number[7], number[8]);
                    Console.WriteLine("Победа за 1ым игроком! ");
                    System.Environment.Exit(0);
                }
                else if (((number[0] == "O") && (number[1] == "O") && (number[2] == "O")) || ((number[3] == "O") && (number[4] == "O") && (number[5] == "O")) || ((number[6] == "O") && (number[7] == "O") && (number[8] == "O")) || ((number[0] == "O") && (number[3] == "O") && (number[6] == "O")) || ((number[1] == "O") && (number[4] == "O") && (number[7] == "O")) || ((number[2] == "O") && (number[5] == "O") && (number[8] == "O")) || ((number[0] == "O") && (number[4] == "O") && (number[8] == "O")) || ((number[2] == "O") && (number[4] == "O") && (number[6] == "O")))
                {
                    Console.Clear();
                    Console.WriteLine("\n{0}\t{1}\t{2}\n{3}\t{4}\t{5}\n{6}\t{7}\t{8}", number[0], number[1], number[2], number[3], number[4], number[5], number[6], number[7], number[8]);
                    Console.WriteLine("Победа за 2ым игроком! ");
                    System.Environment.Exit(0);
                }
                else if (step == 8)
                {
                    Console.Clear();
                    Console.WriteLine("\n{0}\t{1}\t{2}\n{3}\t{4}\t{5}\n{6}\t{7}\t{8}", number[0], number[1], number[2], number[3], number[4], number[5], number[6], number[7], number[8]);
                    Console.WriteLine("\nНичья!");
                    System.Environment.Exit(0);
                }

            }
        }
    }
}