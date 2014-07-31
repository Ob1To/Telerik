// I used some help from the forum for this task. I could not understand it fully .

namespace Task_5_BitArray64
{
    using System;
    public class BitArray64Testing
    {
        public static void Main()
        {
            BitArray64 bArr = new BitArray64(25684556);

            //Console.WriteLine(10010101101010100010);
            Console.WriteLine(bArr);
            bArr[8] = 1;
            Console.WriteLine(bArr);

            Console.WriteLine("Zero bit of number is {0}", bArr[0]);
            Console.WriteLine("Second bit of number is {0}", bArr[2]);
            int index = 0;
            foreach (int bit in bArr)
            {
                Console.WriteLine("Bit {0,2}: {1}", index, bit);
                index++;
            }
        }
    }
}
