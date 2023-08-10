namespace StarsAndStripes
{
    internal class Program
    {
        private const ConsoleColor Red = ConsoleColor.Red;
        private const ConsoleColor Blue = ConsoleColor.Blue;
        private const ConsoleColor White = ConsoleColor.White;
        private const ConsoleColor Black = ConsoleColor.Black;
        private static int[] Reds = new int[] { 0, 1, 4, 5, 8, 9, 12, 13, 16, 17, 20, 21, 24, 25 };

        static void Main(string[] args)
        {
            //Create the first 11 rows.
            for (int i = 0; i < 11; i++)
            {
                BlueStripe(23, i);
                if (Reds.Contains(i))
                {
                    RedStripe(15);
                }
                else
                {
                    WhiteStripe(15);
                }
                Console.WriteLine();
            }
            //create the rest of the flag.
            for (int i = 11; i < 26; i++)
            {
                if (Reds.Contains(i))
                {
                    RedStripe(38);
                }
                else
                {
                    WhiteStripe(38);
                }
                Console.WriteLine();
            }
            Console.BackgroundColor = Black;
        }
        
        /// <summary>
        /// Create white stripes with a lenght of fields.
        /// </summary>
        /// <param name="fields"></param>
        static void WhiteStripe(int fields)
        {
            Console.BackgroundColor = White;
            WriteEmpty(fields);

        }
        
        /// <summary>
        /// Create Red Stripes with a length of fields.
        /// </summary>
        /// <param name="fields"></param>
        static void RedStripe(int fields)
        {
            Console.BackgroundColor = Red;
            WriteEmpty(fields);
        }

        /// <summary>
        /// Create Blue stripes with a lenght of fields. <br/>
        /// stars are created on spesific rows.
        /// </summary>
        /// <param name="fields"></param>
        /// <param name="row"></param>
        static void BlueStripe(int fields, int row)
        {
            Console.BackgroundColor = Blue;
            if (row == 0 || row == 10) { WriteEmpty(fields); }
            else if (row % 2 == 0)
            {
                UnEvenStar(fields);
            }
            else
            {
                EvenStar(fields);
            }
        }

        /// <summary>
        /// Create even rows.
        /// </summary>
        /// <param name="fields"></param>
        static void EvenStar(int fields)
        {
            int[] stars = new int[] { 1, 5, 9, 13, 17, 21 };
            Console.BackgroundColor = Blue;
            for (int i = 0; i < fields; i++)
            {
                if (i == 0)
                {
                    Console.Write("   ");
                }
                else if (stars.Contains(i))
                {
                    Console.Write(" * ");
                }
                else
                {
                    Console.Write("   ");
                }
            }
        }

        /// <summary>
        /// Create uneven rows.
        /// </summary>
        /// <param name="fields"></param>
        static void UnEvenStar(int fields)
        {
            int[] stars = new int[] { 3, 7, 11, 15, 19, 23 };
            Console.BackgroundColor = Blue;
            for (int i = 0; i < fields; i++)
            {
                if (i == 0)
                {
                    Console.Write("   ");
                }
                else if (stars.Contains(i))
                {
                    Console.Write(" * ");
                }
                else
                {
                    Console.Write("   ");
                }
            }
        }

        /// <summary>
        /// Write empty rows.
        /// </summary>
        /// <param name="fields"></param>
        private static void WriteEmpty(int fields)
        {
            for (int i = 0; i < fields; i++)
            {
                Console.Write("   ");
            }
        }
    }
}