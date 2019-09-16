using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    class PassGen
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    for (int k = 'a'; k < 'a' + l; k++)
                    {
                        for (int m = 'a'; m < 'a' + l; m++)
                        {
                            for (int v = 1; v <= n; v++)
                            {
                                if (v > i && v > j)
                                {
                                    Console.Write($"{i}{j}{(char)k}{(char)m}{v} ");
                                }
                            }
                        }
                    }
                }
            }

        }
    }
}
