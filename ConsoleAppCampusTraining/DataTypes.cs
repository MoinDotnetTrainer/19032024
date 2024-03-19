using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCampusTraining
{
    class DataTypes
    {
        public void test()
        {

            int fsd = 46;
          /*  sbyte b = -127;
            sbyte s1 = 21;
            Console.WriteLine(s1);

            byte b1 = 23;
            Console.WriteLine(b1);

            float f = 34.34f;
            Console.WriteLine(f);

            char c = 'A';
            Console.WriteLine(c);

            bool b2 = true;
            Console.WriteLine(b2);

            string str = "gfd74365fg43$^%$%";
            Console.WriteLine(str);

            // var dynmaic oject

            var v = 23;
            //    v = true; ;

            var v1 = 22.33;
            var v2 = 'C';
            var v3 = "str";
            var v4 = true;

            dynamic d1 = 23;

            Console.WriteLine(d1.GetType());
            d1 = true;
            Console.WriteLine(d1.GetType());
            dynamic d2 = 22.33;
            dynamic d3 = 'C';
            dynamic d4 = "str";
            dynamic d5 = true;

            dynamic ds = 23;
            dynamic ds1 = 46;
            Console.WriteLine(ds + ds1);

            object o1 = 23;
            object o2 = 45;
            object o3 = 'C';
            object o4 = "str";
            object o5 = true;


            //Console.WriteLine(o1 + o2);

            //

            int? x = null;
            Nullable<int> y = null;
            string y1 = null;

            // convertion
            // pasring techniue

            Console.WriteLine("Enter x");
          //  int x2 = Convert.ToInt32(Console.ReadLine());

         //   int x3 = int.Parse(Console.ReadLine());


         //   Console.WriteLine(x2);

            //0
            string myStr1 = null;
            int res1 = Convert.ToInt32(myStr1);
            Console.WriteLine("Converting String is a numeric representation: " + res1);

            int res2;
            string myStr2 = null;

            res2 = int.Parse(myStr2);
            Console.WriteLine("Converting String is a numeric representation: " + res2);

            */

            string str1 = null;
            int result;
            bool res11 = int.TryParse(str1, out result);  // returns Bool
            if (res11)
            {
                Console.WriteLine("Expected Result : {0} and value: {1}", +result, res11);
            }
            else
            {
                Console.WriteLine("Input String was not in correct format : {0} ",+result, str1);
            }

            // boxing unboxing

            int x3 = 243;
            string str3 = x3.ToString();
            int x4 = Convert.ToInt32(str3);

            int b12 = 34;
            byte x5 = (byte)b12;

            object[] arr = { 34, 435, true,"hi" };


        }
    }
}
