using System;
using System.Runtime.InteropServices;

namespace VividScript
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Marshal.SizeOf(typeof(PEHeader)).ToString());
            halt: goto halt;
        }
    }
}
