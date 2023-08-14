using System.ComponentModel;
using System.Security;

namespace StarsAndStripsV2
{
    internal class StarsAndStripesV2
    {
        //initialize flag
        const int FLAG_ROWS = 26;
        const int FLAG_COLS = 38;
        const int BLUE_ROWS = 11;
        const int BLUE_COLS = 23;
        const string EMPTY = "   ";
        const string STAR = " * "; //string STAR = $" {inputSymbol} "

        static void Main(string[] args)
        {
            while (true)
            {
                //clear the console
                Console.Clear();

                //init flag variables
                int[,] strips = new int[FLAG_ROWS, FLAG_COLS];
                string[,] stars = new string[BLUE_ROWS, BLUE_COLS];
                ConsoleColor[] colours = new ConsoleColor[4] { ConsoleColor.Red, ConsoleColor.White, ConsoleColor.Blue, ConsoleColor.White };
                bool redState = true;
                bool starState;
                string color;
                ConsoleKey key;

                //Prompt for user input
                Console.WriteLine("Hvis du vil burge standard farverne tryk Enter, ellers tryk på backspace");
                key = Console.ReadKey().Key;
                if (key == ConsoleKey.Enter)
                {

                    Console.WriteLine("(BLACK, DARKBLUE, DARKGREEN, DARKCYAN, DARKRED, DARKMARGENTA, DARKYELLOW, DARKGRAY, WHITE, BLUE, GREEN, CYAN, RED, MARGENTA, YELLOW, GRAY)");
                    Console.WriteLine("Angiven farven på de ulige striber: ");

                    #region Set ConsoleColours
                    color = Console.ReadLine();
                    switch (color.ToUpper())
                    {
                        case "BLACK":
                            colours[0] = ConsoleColor.Black;
                            break;
                        case "DARKBLUE":
                            colours[0] = ConsoleColor.DarkBlue;
                            break;
                        case "DARKGREEN":
                            colours[0] = ConsoleColor.DarkGreen;
                            break;
                        case "DARKCYAN":
                            colours[0] = ConsoleColor.DarkCyan;
                            break;
                        case "DARKRED":
                            colours[0] = ConsoleColor.DarkRed;
                            break;
                        case "DARKMARGENTA":
                            colours[0] = ConsoleColor.DarkMagenta;
                            break;
                        case "DARKYELLOW":
                            colours[0] = ConsoleColor.DarkYellow;
                            break;
                        case "DARKGRAY":
                            colours[0] = ConsoleColor.DarkGray;
                            break;
                        case "WHITE":
                            colours[0] = ConsoleColor.White;
                            break;
                        case "BLUE":
                            colours[0] = ConsoleColor.Blue;
                            break;
                        case "GREEN":
                            colours[0] = ConsoleColor.Green;
                            break;
                        case "CYAN":
                            colours[0] = ConsoleColor.Cyan;
                            break;
                        case "RED":
                            colours[0] = ConsoleColor.Red;
                            break;
                        case "MARGENTA":
                            colours[0] = ConsoleColor.Magenta;
                            break;
                        case "YELLOW":
                            colours[0] = ConsoleColor.Yellow;
                            break;
                        case "GRAY":
                            colours[0] = ConsoleColor.Gray;
                            break;
                        default:
                            Console.WriteLine("Du har valgt en ugyldig farve. Vi beholder standard farven Rød.");
                            break;
                    }

                    Console.WriteLine("Angiv farven på de lige striber: ");
                    color = Console.ReadLine();
                    switch (color.ToUpper())
                    {
                        case "BLACK":
                            colours[1] = ConsoleColor.Black;
                            break;
                        case "DARKBLUE":
                            colours[1] = ConsoleColor.DarkBlue;
                            break;
                        case "DARKGREEN":
                            colours[1] = ConsoleColor.DarkGreen;
                            break;
                        case "DARKCYAN":
                            colours[1] = ConsoleColor.DarkCyan;
                            break;
                        case "DARKRED":
                            colours[1] = ConsoleColor.DarkRed;
                            break;
                        case "DARKMARGENTA":
                            colours[1] = ConsoleColor.DarkMagenta;
                            break;
                        case "DARKYELLOW":
                            colours[1] = ConsoleColor.DarkYellow;
                            break;
                        case "DARKGRAY":
                            colours[1] = ConsoleColor.DarkGray;
                            break;
                        case "WHITE":
                            colours[1] = ConsoleColor.White;
                            break;
                        case "BLUE":
                            colours[1] = ConsoleColor.Blue;
                            break;
                        case "GREEN":
                            colours[1] = ConsoleColor.Green;
                            break;
                        case "CYAN":
                            colours[1] = ConsoleColor.Cyan;
                            break;
                        case "RED":
                            colours[1] = ConsoleColor.Red;
                            break;
                        case "MARGENTA":
                            colours[1] = ConsoleColor.Magenta;
                            break;
                        case "YELLOW":
                            colours[1] = ConsoleColor.Yellow;
                            break;
                        case "GRAY":
                            colours[1] = ConsoleColor.Gray;
                            break;
                        default:
                            Console.WriteLine("Du har valgt en ugyldig farve. Vi beholder standard farven Hvid.");
                            break;
                    }

                    Console.WriteLine("Skriv farven på stjernebaggrunden: ");
                    color = Console.ReadLine();
                    switch (color.ToUpper())
                    {
                        case "BLACK":
                            colours[2] = ConsoleColor.Black;
                            break;
                        case "DARKBLUE":
                            colours[2] = ConsoleColor.DarkBlue;
                            break;
                        case "DARKGREEN":
                            colours[2] = ConsoleColor.DarkGreen;
                            break;
                        case "DARKCYAN":
                            colours[2] = ConsoleColor.DarkCyan;
                            break;
                        case "DARKRED":
                            colours[2] = ConsoleColor.DarkRed;
                            break;
                        case "DARKMARGENTA":
                            colours[2] = ConsoleColor.DarkMagenta;
                            break;
                        case "DARKYELLOW":
                            colours[2] = ConsoleColor.DarkYellow;
                            break;
                        case "DARKGRAY":
                            colours[2] = ConsoleColor.DarkGray;
                            break;
                        case "WHITE":
                            colours[2] = ConsoleColor.White;
                            break;
                        case "BLUE":
                            colours[2] = ConsoleColor.Blue;
                            break;
                        case "GREEN":
                            colours[2] = ConsoleColor.Green;
                            break;
                        case "CYAN":
                            colours[2] = ConsoleColor.Cyan;
                            break;
                        case "RED":
                            colours[2] = ConsoleColor.Red;
                            break;
                        case "MARGENTA":
                            colours[2] = ConsoleColor.Magenta;
                            break;
                        case "YELLOW":
                            colours[2] = ConsoleColor.Yellow;
                            break;
                        case "GRAY":
                            colours[2] = ConsoleColor.Gray;
                            break;
                        default:
                            Console.WriteLine("Du har valgt en ugyldig farve. Vi beholder standard farven Blå.");
                            break;
                    }

                    Console.WriteLine("Angiv farven på stjernerne: ");
                    color = Console.ReadLine();
                    switch (color.ToUpper())
                    {
                        case "BLACK":
                            colours[3] = ConsoleColor.Black;
                            break;
                        case "DARKBLUE":
                            colours[3] = ConsoleColor.DarkBlue;
                            break;
                        case "DARKGREEN":
                            colours[3] = ConsoleColor.DarkGreen;
                            break;
                        case "DARKCYAN":
                            colours[3] = ConsoleColor.DarkCyan;
                            break;
                        case "DARKRED":
                            colours[3] = ConsoleColor.DarkRed;
                            break;
                        case "DARKMARGENTA":
                            colours[3] = ConsoleColor.DarkMagenta;
                            break;
                        case "DARKYELLOW":
                            colours[3] = ConsoleColor.DarkYellow;
                            break;
                        case "DARKGRAY":
                            colours[3] = ConsoleColor.DarkGray;
                            break;
                        case "WHITE":
                            colours[3] = ConsoleColor.White;
                            break;
                        case "BLUE":
                            colours[3] = ConsoleColor.Blue;
                            break;
                        case "GREEN":
                            colours[3] = ConsoleColor.Green;
                            break;
                        case "CYAN":
                            colours[3] = ConsoleColor.Cyan;
                            break;
                        case "RED":
                            colours[3] = ConsoleColor.Red;
                            break;
                        case "MARGENTA":
                            colours[3] = ConsoleColor.Magenta;
                            break;
                        case "YELLOW":
                            colours[3] = ConsoleColor.Yellow;
                            break;
                        case "GRAY":
                            colours[3] = ConsoleColor.Gray;
                            break;
                        default:
                            Console.WriteLine("Du har valgt en ugyldig farve. Vi beholder standard farven Hvid.");
                            break;
                    }

                    #endregion

                }
                else if (key == ConsoleKey.Backspace) { }
                else
                {
                    continue;
                }
                //set the stars array with empty spaces and stars
                for (int i = 0; i < stars.GetLength(0); i++)
                {
                    for (int j = 0; j < stars.GetLength(1); j++)
                    {
                        // differentiate between even and uneven lines.
                        if (i > 0 && i % 2 == 0)
                        {
                            // never put stars in position 0
                            if ((j != 0 && j % 4 == 1) || j == 1)
                            {
                                starState = true;
                            }
                            else
                            {
                                starState = false;
                            }
                        }
                        else
                        {
                            // never put stars in position 0 and 1
                            if ((j > 2 && j % 4 == 3))
                            {
                                starState = true;
                            }
                            else
                            {
                                starState = false;
                            }
                        }

                        if (i == 0 || i == stars.GetLength(0) - 1)
                        {
                            //char tmp = j.ToString().Length > 1 ? j.ToString()[1] : j.ToString()[0];
                            stars[i, j] = EMPTY;
                        }
                        else if (j == 0 || j == stars.GetLength(1) - 1)
                        {
                            //char tmp = i.ToString().Length > 1 ? i.ToString()[1] : i.ToString()[0];
                            stars[i, j] = EMPTY;
                        }
                        else if (starState)
                        {
                            stars[i, j] = STAR;
                        }
                        else
                        {
                            stars[i, j] = EMPTY;
                        }
                    }
                }
                for (int i = 0; i < strips.GetLength(0); i++)
                {
                    //switch the state which controls the stripe colour
                    if (i == 0 || i % 2 == 0)
                    {
                        redState = !redState;
                    }

                    //iterate over each column of each row
                    for (int j = 0; j < strips.GetLength(1); j++)
                    {
                        if (redState)
                        {
                            Console.BackgroundColor = colours[1];
                        }
                        else
                        {
                            Console.BackgroundColor = colours[0];
                        }

                        if (i < stars.GetLength(0) && j < stars.GetLength(1))
                        {
                            Console.BackgroundColor = colours[2];
                            Console.ForegroundColor = colours[3];
                            Console.Write(stars[i, j]);
                        }
                        else
                        {
                            Console.Write(EMPTY);
                        }
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Tryk på en vilkårlig tast for at tegnet et nyt flag,");
                Console.WriteLine("Tryk på escape for at slykke for programmet.");
                key = Console.ReadKey().Key;
                if (key == ConsoleKey.Escape)
                {
                    return;
                }
            }
        }
    }
}