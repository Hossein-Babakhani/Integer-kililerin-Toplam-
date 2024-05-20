using System;

namespace Integer_İkililerin_Toplamı
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Tam sayı çiftlerinin sayısını girin: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("İlk tam sayıyı girin: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("İkinci tam sayıyı girin: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                if (num1 != num2)
                {
                    int sum = num1 + num2;
                    Console.WriteLine("Tam sayıların toplamı: " + sum);
                }
                else
                {
                    int kare = (num1 + num2) * (num1 + num2);
                    Console.WriteLine("Toplamın karesi: " + kare);
                }
            }

            Console.ReadLine();
        }
    }
}
