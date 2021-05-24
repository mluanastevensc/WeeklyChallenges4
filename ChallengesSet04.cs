using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            return numbers.Where(x => x % 2 == 0).Sum() - numbers.Where(x => x % 2 != 0).Sum();

            //int sum = 0;
            //for (int i=0; i < numbers.Length; i++)
            //{
                
               // if( numbers[i] % 2 == 0)
                //{
                    //sum += numbers[i];
                //}
                //else if(numbers[i]%2==1)
                //{
                   // sum -= numbers[i];
              //  }
           // }
            //return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var list = new List<int>() { str1.Length, str2.Length, str3.Length, str4.Length };


            return list.Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var list = new List<int>() { number1, number2, number3, number4 };
            return list.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 <=0 || sideLength2 <=0 || sideLength3 <=0)
            {
                return false;

            }
            else if((sideLength1 + sideLength2) <= sideLength3 ||
                (sideLength1 + sideLength3) <= sideLength2 ||
                (sideLength2+sideLength3) <= sideLength1)
                return false;


            {
                return true;
            }

        }
        public bool IsStringANumber(string input)
        {
            return double.TryParse(input, out _);
        }
       

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var count = objs.Count(x => x == null);
            return count > objs.Length / 2;
            
        }

        public double AverageEvens(int[] numbers)
        {
         
            return numbers == null || numbers.Length ==0 || numbers.Where(x=>x%2==0).Count() ==0 ? 0:  numbers.Where(x=>x%2 ==0).Average();
            
        }

        public int Factorial(int number)
        {
            int i;
           for (i =number-1; i > 0; i--)
            {
                number *= i;
            }
            return number;
           

        }
    }
}
