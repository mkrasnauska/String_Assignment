using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Concatenating 3 strings
            string part1 = ("\"The greatest glory ");
            string part2 = ("in living lies not in never falling,  ");
            string part3 = ("but in rising every time we fall.\"");
            string part4 = ("– Nelson Mandela");
            string concat = (part1 + part2 + part3 + "\n" + part4);

            //2.Converting to uppercase
            Console.WriteLine(concat.ToUpper());

            //3.StringBuilder
            StringBuilder sb = new StringBuilder();
            sb.Append("\n\"If I am not for myself, who is for me? ");
            sb.AppendLine("And if I am only for myself, what am I?");
            sb.AppendLine("And if not now, when?\"");
            sb.AppendLine("-Rabbi Hillel");
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
