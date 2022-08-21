using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {

            //這是一道關於if 的題目, 有興趣的初學者可以寫看看
            //判斷是否為閨年, 規則是: 可以被 4 整除, 如果可以被 100 整除時,必需剛好也可以可以被400整除才算閨年
            //測試資訊:
            //不是閨年:
            //1999(不能被4整除)
            //2100(可以被100整除但無法被 400整除)
            //是閨年
            //2004(可以被4但無法被100整除)
            //2000(可以被100整除且可以被 400整除)
            //Cal(2100);
            //Cal(2100)
            Cal(1900);
            Cal(1999);
            Cal(2000);
            Cal(2004);
            Cal(2096);
            Cal(2097);
            Cal(2100);
           
        }
        static void Cal(int year)
        {
            if(year %4 ==0 && year%100 != 0)
            {
                Console.WriteLine("閏年");
            }
            else if(year %100 ==0 && year % 400 != 0)
            {
                Console.WriteLine("平年");
            }
            else if (year%100==0 && year%400==0)
            {
                Console.WriteLine("閏年");
            }
            else
            {
                Console.WriteLine("平年");
            }
        }
    }
}
