using System;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //变量声明
            int a = 0;//int数值类型可以按F12查询最大值和最小值
            float b = a;//划词，按F1打开msdn查询含义
            int c = 12;//声明一个变量，并赋值。（在内存里分配一块空间类型为int的空间，然后把数据存储进去）
            //变量赋值
            int d = c;//把c的内存空间里的数据复制到d里面去
            //字符串
            string s1 = "caonima";
            string s2 = "buhuibaidua";
            Console.WriteLine(s1 + s2 + d);//字符串只会拼接，不会进行运算
        }
    }
}
