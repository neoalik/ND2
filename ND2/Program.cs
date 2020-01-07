using System;
using System.Collections.Generic;

namespace ND2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            /*intToArray(123456);


            int[] array = { 9, 8, 1,7, 6, 5 };

            int[] array2 = { 5,6,7,8,9,1 };

            bool geras = checkTwoArray(array, array2);*/


            for (int i = 100000; i <= 999999;i++)
            {
                int[] sk = intToArray(i);

                for (int j = 2; j <= 6; j++)
                {
                    if (noDublicate(sk))//neturintis dublikato galima su tuo skaicium kazka daryt, pvz dauginti is 2, 3, 4, 5, 6
                    {
                        int daugyba = i * j;

                        if (daugyba.ToString().Length == 6)
                        {
                            if (!checkTwoArray(sk, intToArray(daugyba)))
                            {
                                break;
                            }

                            if (j == 6)
                            {
                                Console.WriteLine($"Skaicius {i} yra tas magiskas");
                            }
                        }
                    }
                }
            }
        }

        static int[] intToArray(int number)
        {
            string numstr = number.ToString();

            int[] digits = new int[numstr.Length];

            for(int i = 0; i < digits.Length; i++)
            {
                digits[i] = Convert.ToInt32(numstr[i].ToString());
            }

            return digits;
        }

        static bool noDublicate(int[] numberList)
        {
            List<int> numbList = new List<int>();

            foreach(int n in numberList)
            {
                if (numbList.Contains(n))
                {
                    return false;
                }

                numbList.Add(n);
            }

            return true;
        }

        static bool checkTwoArray(int[] sk1, int[] sk2)
        {

            if (sk1.Length != sk2.Length) return false;

            for (int i = 0; i < sk1.Length; i++)
            {
                int index = Array.IndexOf(sk2, sk1[i]);

                if (index <= -1 || index == i) return false;
            }

            return true;
        }
    }
}
