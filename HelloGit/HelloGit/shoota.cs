using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloGit
{
    class shoota
    {
        static void Main(string[] args)
        {
            double d = 0;
            for (int i = 0; i < 10000; i++)
            {
                d = d + 1;

                if (i == 5001)
                    d = d / 0;
            }
        }
        //}
        //            Decimal sum = 0;
        //            for (int i = 0; i < 100; i++) {
        //                //decimal - 16비트 소수 계산 가능. 숫자 끝에 m붙임.
        //                sum += 0.1m;
        //            }
        //            Console.WriteLine(sum);

    }
}
