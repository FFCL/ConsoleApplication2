using System;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region//变量声明
            /*
            int a = 0;//int数值类型可以按F12查询最大值和最小值
            float b = a;//划词，按F1打开msdn查询含义
            int c = 12;//声明一个变量，并赋值。（在内存里分配一块空间类型为int的空间，然后把数据存储进去）
            float fe = 12.3f;
            //变量赋值
            int d = c;//把c的内存空间里的数据复制到d里面去
            //字符串
            string s1 = "操你妈";
            string s2 = "不会MSDN啊！";
            Console.WriteLine(s1 + s2 + d);//字符串只会拼接，不会进行运算
            */
            #endregion

            #region//变量值交换
            /*
            int num1 = 5;
            int num2 = 10;
            int temp = num1;//复制一份num1
            num1 = num2;
            num2 = temp;//复制的num1转入num2
            */
            #endregion

            #region//字符串的转义(\)
            /*
            Console.WriteLine("操你妈\n不会MSDN啊！");//换行
            Console.WriteLine("操你妈\t不会MSDN啊！");//tab
            Console.WriteLine("操你妈\b不会MSDN啊！");//删除前面一个字符
            string path1 = "D:\\FL Studio 12\\data";//表示路径的第一种方法
            string path2 = @"D:\FL Studio 12\Data\Projects\Demo songs\Legacy";//表示路径的第二种方法
            Console.WriteLine(path1);
            Console.WriteLine(path2);
            */
            #endregion

            #region//占位符
            string fuck = "操";
            string mom = "妈";
            string horse = "*";
            Console.WriteLine("{0}你{1}不会MSDN啊！", fuck, mom, horse);
            Console.WriteLine("{2}你{2}不会MSDN啊！",fuck,mom,horse);
            #endregion

        }
    }
}
