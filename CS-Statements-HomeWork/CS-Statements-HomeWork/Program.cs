using System;

namespace CS_Statements_HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C# statements - for,while,do while,foreach, if else, switch case

            #region 1-ci Tapsiriq +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            //  1. Verilmiş artan sıra ilə düzülmüş ədədlər siyahısındaki n ədədinin
            //    yerləşdiyi indexi tapan alqoritm (binary search)


            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            int n = 100;
            int min = 0;
            int max = numbers.Length-1;
            int index = -1;
            while (min <= max)
            {
                int mid = (min + max) / 2;

                if (n == numbers[mid])
                {
                    index = mid;
                    break;
                }
                else if (n > numbers[mid])
                {
                    min = mid + 1;
                }
                else
                {
                    max = mid-1;
                }
            }
            Console.WriteLine("--------------1-ci tapsirigin cavabi-----------------------------------");
            Console.WriteLine(index);
            #endregion ---------------------------------------------------------------------------------------

            #region 2-ci Tapsiriq +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            //  2. Verilmiş ədədlər siyahısını artan sıra ilə düzülmüş ədədlər halına gətirən alqoritm

            int[] mixNumbers = { 0,21,1,12, 9, 44, 23, 4, 6, 32, 45, 2, 32, 1, 4, 0 };

            for (int i = 0; i < mixNumbers.Length; i++)
            {
                for (int a = 0; a < mixNumbers.Length-i-1; a++)
                {
                    if (mixNumbers[a] > mixNumbers[a+1])
                    {
                        int temp = mixNumbers[a];
                        mixNumbers[a]=mixNumbers[a+1];
                        mixNumbers[a+1]=temp;
                    }
                }
            }
            Console.WriteLine("--------------2-ci tapsirigin cavabi-----------------------------------");

            for (int i = 0; i < mixNumbers.Length; i++)
            {

                Console.WriteLine(mixNumbers[i] + "  ");
            }
            #endregion -----------------------------------------------------------------------------------

            #region 3-cu Tapsiriq ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            //  3. Verilmiş iki ədədlər siyahısından birincisinin ikincisinin içində olub olmadığını
            //  tapan alqoritm.Yəni birinci array-dəki ədədlərin hamısı 2ci array-də də
            //  varsa true çıxır output-a , hər hansısa biri yoxdursa false

            int[] numbers1 = { 2, 79, 3 };
            int[] numbers2 = { 10, 20, 1,2,7,5,3 };
            bool check=false;
            for (int i = 0; i < numbers1.Length; i++)
            {
                 check=false;
                for (int a = 0; a < numbers2.Length; a++)
                {
                    if (numbers1[i] == numbers2[a])
                    {
                        check=true;
                        break;
                    }
                }

                if (check == false)
                {
                    Console.WriteLine("--------------3-ci tapsirigin cavabi-----------------------------------");

                    Console.WriteLine("False");
                    break;
                }
            }
            if (check == true)
            {
                Console.WriteLine("--------------3-ci tapsirigin cavabi-----------------------------------");

                Console.WriteLine("True");
            }


            #endregion ------------------------------------------------------------------------------------------

            #region 4-cu Tapsiriq ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            //  4. Console-dan daxil edilmiş ad daxil edilməsini istəyən proqram.
            //  Əgər daxil edilən adda rəqəm varsa yenidən daxil edilməlidir ta ki düz yazana qədər.


            Console.WriteLine("--------------4-ci tapsirigin cavabi-----------------------------------");

            char[] charNumbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            bool check1 = false;

            do
            {
                Console.WriteLine("Xais edirik adinizi daxil edin : ");
                string name = Console.ReadLine();
                check1 = false;

                for (int i = 0; i < name.Length; i++)
                {
                    for (int a = 0; a < charNumbers.Length; a++)
                    {
                        if (name[i] == charNumbers[a])
                        {
                            check1= true;
                            break;
                        }
                    }
                    if (check1 == true)
                    {
                        break;
                    }
                }

            } while (check1==true);

            if (check1==false)
            {
                Console.WriteLine("Congrulations");

            }
            #endregion ----------------------------------------------------------------------------------------

            #region 5-ci Tapsiriq ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            //  5. Verilmiş yazılar siyahısındaki bütün sözlərin A hərfi ilə başlayıb başlamadığını tapan proqram

            Console.WriteLine("--------------5-ci tapsirigin cavabi-----------------------------------");

            string[] words = { "afet", "ramal", "alma", "armud" };
            int count = 0;
            for (int i = 0; i < words.Length; i++)
            {
                string oneWord = words[i];

                if (oneWord[0] == 'a')
                {
                    count++;
                    
                }
                else
                {
                    Console.WriteLine("False");
                    break;
                }
            }
            if (count == words.Length)
            {
                Console.WriteLine("True");
            }
            #endregion ----------------------------------------------------------------------------
        }
    }
}
