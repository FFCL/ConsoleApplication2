﻿using System;
namespace Second
{
    class Program
    {
        static void Main(string[] args)
        {
            #region//变量声明
            
            int a = 0;//int数值类型可以按F12查询最大值和最小值
            float b = a;//划词，按F1打开msdn查询含义
            int c = 12;//声明一个变量，并赋值。（在内存里分配一块空间类型为int的空间，然后把数据存储进去）
            float fe = 12.3f;//C#输入小数后默认为double类,需要单浮点时可以加f转化为float类

            //变量赋值
            int d = c;//把c的内存空间里的数据复制到d里面去。

                    /* 将小范围的变量的值复制给大范围变量，C#会自动转换
                     * 满足的条件：
                     * 1. 两种条件数据必须相互兼容
                     * 2. 目标类型的范围必须比源类型大             
                     */

            //字符串
            string s1 = "操你妈";
            string s2 = "不会MSDN啊！";
            Console.WriteLine(s1 + s2 + d + fe);//字符串只会拼接，不会进行运算
            
            #endregion

            #region//变量值交换
            
            int num1 = 5;
            int num2 = 10;
            int temp = num1;//复制一份num1
            num1 = num2;
            num2 = temp;//复制的num1转入num2
            
            #endregion

            #region//字符串的转义(\)
            
            Console.WriteLine("操你妈\n不会MSDN啊！");//换行
            Console.WriteLine("操你妈\t不会MSDN啊！");//tab
            Console.WriteLine("操你妈\b不会MSDN啊！");//删除前面一个字符
            string path1 = "D:\\FL Studio 12\\data";//表示路径的第一种方法
            string path2 = @"D:\FL Studio 12\Data\Projects\Demo songs\Legacy";//表示路径的第二种方法
            Console.WriteLine(path1);
            Console.WriteLine(path2);
            
            #endregion

            #region//占位符
            
            string fuck = "操";
            string mom = "妈";
            string horse = "*";
            Console.WriteLine("{0}你{1}不会MSDN啊！", fuck, mom, horse);
            Console.WriteLine("{2}你{2}不会MSDN啊！",fuck,mom,horse);
            
            #endregion

            #region//算数表达式
            
            int aa1 = 5 + 6;//加
            int aa2 = 5 - 6;//减
            int aa3 = 5 * 6;//乘
            double aa4 = 5.0 / 6.0;//除（必须要float除以float才能显示小数）
            int aa5 = 5 % 6;//模（求余）

            Console.WriteLine("这是四则运算和模结果\n{0}\t{1}\t{2}\t{3}\t{4}",aa1,aa2,aa3,aa4,aa5);

            float f1 = 12.2f;
            float f2 = 24.4f;
            float fSum = f1 + f2;//参与计算的数值可以用同范围接收

            double d1 = 12.2442;
            double d2 = 32.2765;
            double dSum = d1 + d2;//同上

            //特殊情况
            byte b1 = 12;
            byte b2 = 42;
            //byte bSum = b1 + b2;//*错误*
            int bSum = b1 + b2;//*特殊* byte和short 因为范围比较小，所以统一规定用int类型接收

            int ac = aa1 + b1;//参与计算数值的范围不同，其结果取其最大范围的类型接收

            char g = '4';
            int aaSum = 0 + g;//字符转换为ASCII编号的数值参与运算
            Console.WriteLine(aaSum);

            int abe = 100;
            abe += 5;//abe = abe + 5
            abe -= 5;//abe = abe - 5
            abe *= 2;//abe = abe * 2
            abe /= 2;//abe = abe / 2
            abe %= 5;//abe = abe % 5
            Console.WriteLine(abe);
            
            #endregion

            #region//输入
            
            int maxmoney = 65535;
            Console.WriteLine("Please input your name!");
            string input = Console.ReadLine();//读取用户输入的字符串，赋值与input
            Console.WriteLine("Your name is {0},so i give you {1} 人名币",input,maxmoney);
            
            #endregion

        }
    }
}