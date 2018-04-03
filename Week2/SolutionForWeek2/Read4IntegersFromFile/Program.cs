using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Read4IntegersFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integers to be writed in file");
            int[] integersToWrite = { int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()) };

            FileStream streamToWriteText;
            streamToWriteText = new FileStream("FourIntegers.txt", FileMode.Create);
            byte[] info = new byte[4];
            for (int firstIndex = 0; firstIndex < 4; firstIndex++)
            {
                info[firstIndex] = (byte)integersToWrite[firstIndex];
            }

            streamToWriteText.Write(info, 0, 4);

            streamToWriteText.Seek(2, SeekOrigin.Begin);
            Console.WriteLine("The third integer is: {0}", streamToWriteText.ReadByte());
            streamToWriteText.Seek(3, SeekOrigin.Begin);
            Console.WriteLine("The fourth integer is: {0}", streamToWriteText.ReadByte());
            streamToWriteText.Close();

            Console.ReadKey();
        }
    }
}
