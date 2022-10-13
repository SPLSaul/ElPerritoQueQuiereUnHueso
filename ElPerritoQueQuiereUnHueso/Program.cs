using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElPerritoQueQuiereUnHueso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] hueso1 = new int[2];
            int[] hueso2 = new int[2];
            int bone1 = 0,bone2 = 0;
            hueso1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            hueso2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for(int i=0; i < hueso1.Length; i++)
            {
                if (hueso1[i] > hueso2[i]){ bone1++; }
                else if (hueso1[i] < hueso2[i]) { bone2++; }
                

            }
            if (bone1 == 2) { Console.WriteLine("Hueso 1"); }
            else if (bone2 == 2) { Console.WriteLine("Hueso 2"); }
            else { Console.WriteLine("Perrito confundido"); }
            Console.ReadKey();
        }
    }
}
