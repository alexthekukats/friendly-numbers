using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Meddig?");

            //int a = Convert.ToInt32(Console.ReadLine());
            int sz2 = 0;

            //int xi = 10000;
            int sz1 = 0;
            for (int szam1 = 220;szam1 < 11000 ; szam1++)
            {
                int _szam1 = Convert.ToInt32(Math.Sqrt(szam1));
                for (int i = 1; i <= _szam1; i++)
                {
                    if (szam1 % i == 0)
                    {
                        if (i == 1)
                        {
                            sz1 += i;
                        }
                        else
                        {
                            sz1 += i;
                            sz1 += szam1 / i;
                        }
                    }
                }

                for (int szam2 = 284; szam2 < 11000; szam2++)
                {
                    int _szam2 = Convert.ToInt32(Math.Sqrt(szam2));
                    for (int k = 1; k <= _szam2; k++)
                    {
                        if (szam2 % k == 0)
                        {
                            if (k == 1)
                            {
                                sz2 += k;
                            }
                            else
                            {
                                sz2 += k;
                                sz2 += szam2 / k;
                            }
                        }
                    }

                    if (sz1 == szam2 && sz2 == szam1 && szam1 != szam2)
                    {
                        Console.WriteLine("Barátságos szám: {0}, {1}", szam1, szam2);
                    }
                    sz2 = 0;
                }
                sz1 = 0;
            }
            Console.ReadKey();
        }
    }
}
