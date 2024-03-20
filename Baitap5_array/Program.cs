using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap5_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // De bai
            /*Console.WriteLine("Nhap vao chieu dai chuoi");
            int a = int.Parse(Console.ReadLine());
            int[] b = new int[a];

            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("a[" + i + "]=");
                b[i] = int.Parse(Console.ReadLine());
            }*/
            // Cau 1
            /*for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine("Phan tu thu {0} trong mang la {1}", i, b[i].ToString());
            }*/
            // Cau 2
            /*for (int i = b.Length-1; i >= 0; i--)
            {
                Console.WriteLine("Phan tu thu {0} khi dao nguoc la {1}", i, b[i].ToString());
            }*/


            //Cau 3




            /*for (int i = 0; i < b.Length; i++)
            {
                int solanlap = 0;
                //bool lap = false;
                for (int j = 0;  j < b.Length;  j++)
                {
                    if (b[i] == b[j]) {

                        solanlap +=1;
                        
                    }

                 

                }
                Console.WriteLine("Phan tu {0} co so lan xuat hien la {1}", b[i], solanlap);


            }
            */
            // Cau4
            /*for (int i = 0; i < b.Length; i++)
            {
                int solanlap = 0;
                //bool lap = false;
                for (int j = 0; j < b.Length; j++)
                {
                    if (b[i] == b[j])
                    {

                        solanlap += 1;

                    }



                }

                if (solanlap==1)
                {
                    Console.WriteLine("Phan tu {0} la duy nhat trong mang", b[i]);
                }
                //Console.WriteLine("Phan tu {0} co so lan xuat hien la {1}", b[i], solanlap);


            }*/


            //Cau 5
            /*int dem = 0;
            foreach (int number in b)
            {
                if (number%2==0)
                {
                    dem++;
                }
            }
            int[] sochan = new int[dem];
            int[] sole = new int[b.Length-dem];
            int indexSochan = 0;
            int indexSole = 0;
            foreach (int number in b)
            {
                if (number % 2 == 0)
                {
                    sochan[indexSochan] = number;
                    indexSochan++;
                    Console.WriteLine("So chan" + number);
                }
                
            }
            foreach (int number in b)
            {
                if (number % 2 != 0)
                {
                    sole[indexSole] = number;
                    indexSole++;
                    Console.WriteLine("So le" + number);
                }
                
            }*/
            int[] b = { 3, 4, 5, 3, 9, 10, 2, 11, 6, 13, 5 };

            //Cau 6
            /*int tmp;
            for (int i = 0; i < b.Length; i++)
            {
                for (int j = i+1; j < b.Length; j++)
                {
                    if (b[i] < b[j])
                    {
                        tmp = b[i];
                        b[i] = b[j];
                        b[j] = tmp;
                    }
                }
                
            }
            foreach (int num in b)
            {
                Console.Write(num + " ");
            }*/

            // Cau 7
            /*int max =b[0];
            int max2 = b[0];
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] > max)
                {
                    max = b[i];
                }
            }
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] > max2 && b[i]<max)
                {
                    max2 = b[i];
                }
            }

            Console.WriteLine("Phan tu lon thu 2 la:" + max2);*/
            //Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
