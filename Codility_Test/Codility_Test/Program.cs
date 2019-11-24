using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();

            int times = p.solution("011111");
            Console.WriteLine("Number of time to iterate = {0},{1}", times,int.MaxValue);
            Console.ReadLine();
        }

        public int solution(string S)
        {
           int count = 0;
            try
            {
                int number = Convert.ToInt32(S, 2);
                while (number != 0)
                {
                    count++;
                    if (number % 2 != 0)
                    {
                        number = number - 1;
                    }
                    else
                    {
                        number = number / 2;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("There is some issue please check..{0}", ex.StackTrace);
            }
            return count;
        }
    }
}
