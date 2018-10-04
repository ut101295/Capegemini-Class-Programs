﻿using System/;
using System. Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleCastDelegateDemo
{
    delegate double MyDelegate(double val);
    delegate void MyDelegate2(int a,int b);

    class Program
    {
        public void Add(int num1,int num2)
        {
            Console.WriteLine("{0} + {1} => {2}", num1,num2,(num1+num2));
        }

        static void Main(string[] args)
        {
            MyDelegate del = new MyDelegate(Math.Sin);

            //double result = del.Invoke(1.0);

            double result = del(1.0);

            Console.WriteLine("Result :" + result);

            Program p = new Program();

            MyDelegate2 d = new MyDelegate2(p.Add);

            d(1,0);
            

            Console.ReadKey();

        }
    }
}
