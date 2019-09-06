using System;
using System.IO;

namespace ProjectUno
{
    class p1
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(args[0]);
            HighArray arr = new HighArray(lines.Length);

            for (int i = 0; i < arr.GetSize(); i++)
            {
                arr.Insert(Int32.Parse(lines[i]));
            }

            arr.Display();

            Console.WriteLine("");
            Console.WriteLine(arr.GetMin());
            Console.WriteLine(arr.GetMax());
            Console.WriteLine("");
            arr.Delete(0);
            arr.Display();
            Console.WriteLine("");
            arr.Find(109);
        }
    }
}
