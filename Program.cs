using System;
using System.Collections;

namespace XORarray
{
  
    class Program
    {
        static void Main(string[] args)
        {
            DynamicArray ar = new DynamicArray(10);
            XORdecorate xr = new XORdecorate(ar); // Передаю в XOR декоратор

            xr.AddValue(20);
            xr.AddValue(25);
            xr.AddValue(45);
            xr.AddValue(90);

            
            for (int i = 0; i < xr.GetLength; i++)
            {
                Console.WriteLine("После XOR: " + xr.GetValue(i));
            }

            for (int i = 0; i < xr.GetLength; i++)
            {
                Console.WriteLine("После расшифровки: " + xr.GetValueWithReXOR(i));
            }
            
        }
    }
}
