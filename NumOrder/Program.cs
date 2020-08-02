using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace NumOrder
{
    class Program
    {
        private static int max = 0;
        static void Main(string[] args)
        {
           
                List<int> x = new List<int>();
                foreach (var item in Console.ReadLine())
                {
                    int addNum = Convert.ToInt32(item.ToString());
                    x.Add(addNum);
                }
                foreach (var item in Order(x))
                {
                    Console.WriteLine(item);
                }


                Console.ReadKey();
            
       

         //   Main(new string[] { "0" });
        }

        public static List<int> Order(List<int> numbers)
        {
            List<int> res = new List<int>();
          
            foreach (var item in numbers)
            {
                if (item > max)
                {
                    max = item;
                    res.Add(item);
                }
                else if(item < max)
                {
                   res = PutSmallerItemInList(res, item);
                }
            }



            return res;
        }

        private static List<int> PutSmallerItemInList(List<int> num,int addNum)
        {
            int i = 0;
            int[] result = num.ToArray();
            foreach (var item in result)
            {
                
                if(item > addNum)
                {
                  result =  BalanceArray(result, addNum, i);

                }
                i++;
            }

            return result.ToList();
        }

        private static int[] BalanceArray(int[] numbers,int addnumber,int whereToAdd)
        {
            int[] result = new int[numbers.Count() + 1];
           // int prevVal;

            for (int i = 0; i < whereToAdd; i++)
            {
                result[i] = numbers[i];
            }
           // prevVal = result[whereToAdd];

            result[whereToAdd] = addnumber;

           // result[whereToAdd + 1] = prevVal;
            for (int i = whereToAdd ; i < numbers.Length; i++)
            {
                result[i + 1] = numbers[i];
            }

            return result;
        }

        
    }
}
