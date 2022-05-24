using System;

namespace CS_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sum(98);  // 1-ci tapsiriq metodu

            int[] ints = { 1, 2, 3,4,5,6,7,8,3,423,52,342,33,4,222 };

            IndexCheck(ints, 2);  // 2-ci tapsiriq metodu

            Biggest(20, 200, 5);  // 3-cu tapsiriq metodu

            int[] ints2 = { 10, 2, 31, 4 };
            CountOdd(ints2);   // 4-cu tapsiriq metodu


            // Eger daxil edilen eded tek deyilse yeniden daxil edilmesini istesin
            int digit;
            do
            {
                Console.WriteLine("Tek eded daxil edin !!");

                digit = Convert.ToInt32(Console.ReadLine());


            } while (!Odd(digit));



        }

        #region Tapsiriq 1 *********************************************************************************************************************
        //Verilmiş ədədin rəqəmləri cəmini tapıb qaytaran  metod

        static int Sum(int number)
        {
            int sum = 0;
            if (number < 0)
            {
                number *= -1;
            }
            while (number > 0)
            {
                int lastDigit = number % 10;
                sum += lastDigit;
                number = (number - lastDigit) / 10;
            }
            Console.WriteLine(sum);
            return sum;
        }
        #endregion

        #region Tapsiriq 2 *********************************************************************************************************************
        //Verilmiş interger arrayində verilmiş integer ədədinin yerləşdiyi ilk indexi tapıb qaytaran metod.
        //Əgər tapmasa -1 qaytarsın.(Metodu işlətdikdə içinə arqument olaraq bir integer array və bir ədəd göndərilir)

        static int IndexCheck(int[] numbers,int num)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == num)
                {
                    Console.WriteLine(i);
                    return i;
                }
            }
            Console.WriteLine("-1");
            return -1;
        }
        #endregion

        #region Tapsiriq 3 *********************************************************************************************************************
        //Verilmiş 3 ədədən ən böyüyünü qaytaran metod

        static int Biggest(int num1,int num2,int num3)
        {
            if (num1 >= num2 && num1 >= num3)
            {
                Console.WriteLine(num1);
                return num1;
            }
            else if(num2 >= num1 && num2 >= num3)
            {
                Console.WriteLine(num2);
                return num2;
            }
            else
            {
                Console.WriteLine(num3);
                return num3;
            }
        }
        #endregion

        #region Tapsiriq 4 ** Verilmis array-in icindeki tek ededlerin sayini tapan metod **********************************************


        static int CountOdd(int[] numbers)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (Odd(numbers[i]))
                {
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Array-da tek eded yoxdur");
                return count;
            }
            else
            {
                Console.WriteLine($"Array-da {count} tek eded var.");
                return count;
            }
        }




        static bool Odd(int num)
        {
            bool check = num % 2 == 1;
            return check;
        }
        #endregion

        
    }
}
