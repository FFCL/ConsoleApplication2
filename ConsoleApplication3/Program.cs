using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Training
{
    class Program
    {
        static void Main(string[] args)
        {
            #region //两个数值互换
            /*
            int a = 10;
            int b = 5;
            int c = a;
            a = b;
            b = c;
            Console.WriteLine("Changed is a={0},b={1}",a,b);
            */
            #endregion

            #region //两个数求和
            /*
            Console.WriteLine("Please input the First Number!");
            string input_a = Console.ReadLine();
            Console.WriteLine("Please input the Second Number!");
            string input_b = Console.ReadLine();

            double c = Convert.ToDouble(input_a) + Convert.ToDouble(input_b);
            Console.WriteLine("The result is "+c);
            */
            #endregion

            #region//比大小
            /*
            int a = 10;
            int b = 20;
            int c = 15;
            int d = a > b ? a : b;
            int e = d > c ? d : c;
            Console.WriteLine(e);
            */
            #endregion

            string[] arrS = { "12m", "12321", "jio12", "23def" };
            for (int i = 0; i < (arrS.Length); i++)
            {
                Console.WriteLine(arrS[i]);
            }
        }
    }
}