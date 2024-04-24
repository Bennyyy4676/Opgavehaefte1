using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Declarations
{
    public class Opgavesæt
    {
        public void opgave1()
        {
            Console.WriteLine("Hello\nMarcus Rossen");
        }

        public void opgave2()
        {
            Console.WriteLine(50 + 50);
        }

        public void opgave3()
        {
            Console.WriteLine(50 / 50);
        }

        public void opgave4()
        {
            Console.WriteLine((-1 + 4 * 6) + "\n" + ((35 + 5) % 7) + "\n" + (14 + -4 * 6 / 11) + "\n" + (2 + 15 / 6 * 1 - 7 % 2));
        }

        public void opgave5()
        {
            Console.Write("Indtast første tal: ");
            double tal1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Indtast andet tal: ");
            double tal2 = Convert.ToDouble(Console.ReadLine());

            double midlertidig;
            midlertidig = tal1;
            tal1 = tal2;
            tal2 = midlertidig;

            Console.Write("\nFørste tal: " + tal1 + "\n" + "Andet tal: " + tal2);
        }

        public void opgave6()
        {
            Console.Write("Indtast første tal: ");
            double tal1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Indtast andet tal: ");
            double tal2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Indtast tredje tal: ");
            double tal3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Dine tal ganget sammen er: " + tal1 * tal2 * tal3);
        }

        public void opgave7()
        {
            Console.Write("Indtast første tal: ");
            double tal1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Indtast andet tal: ");
            double tal2 = Convert.ToDouble(Console.ReadLine());

            Console.Write((tal1 + tal2) + "\n" + (tal1 - tal2) + "\n" + (tal1 * tal2) + "\n" + (tal1 / tal2) + "\n" + (tal1 % tal2));
        }

        public void opgave8()
        {
            Console.Write("Indtast tabel: ");
            int tabel = Convert.ToInt16(Console.ReadLine());

            for(int i = 1; i <= 10; ++i)
            {
                Console.WriteLine(tabel * i);
            }
        }
    }
}
