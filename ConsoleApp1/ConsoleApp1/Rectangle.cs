using ConsoleApp1;
using System.Drawing;

public static class Draw
{

    /// <summary>
    /// Draws a rectangle in the console using several WriteLine() calls.
    /// </summary>
    /// <param name="width">The width of the rectangle.</param>
    /// <param name="height">The right of the rectangle.</param>
    /// <param name="xLocation">The left side position.</param>
    /// <param name="yLocation">The top position.</param>
    /// <param name="keepOriginalCursorLocation">If true, 
    /// the cursor will return back to the starting location.</param>
    /// <param name="color">The color to use. null=uses current color Default: null</param>
    /// <param name="useDoubleLines">Enables double line boarders. Default: false</param>
    public static void RectangleFromCursor(int width,
        int height,
        int xLocation = 0,
        int yLocation = 0,
        bool keepOriginalCursorLocation = false,
        ConsoleColor? color = null,
        bool useDoubleLines = false)
    {
        {
            // Save original cursor location
            int savedCursorTop = Console.CursorTop;
            int savedCursorLeft = Console.CursorLeft;

            // if the size is smaller then 1 then don't do anything
            if (width < 1 || height < 1)
            {
                return;
            }

            // Save and then set cursor color
            ConsoleColor savedColor = Console.ForegroundColor;
            if (color.HasValue)
            {
                Console.ForegroundColor = color.Value;
            }

            char tl, tt, tr, mm, bl, br;

            if (useDoubleLines)
            {
                tl = '+'; tt = '-'; tr = '+'; mm = '¦'; bl = '+'; br = '+';
            }
            else
            {
                tl = '+'; tt = '-'; tr = '+'; mm = '¦'; bl = '+'; br = '+';
            }

            for (int i = 0; i < yLocation; i++)
            {
                Console.WriteLine();
            }

            Console.WriteLine(
                string.Empty.PadLeft(xLocation, ' ')
                + tl
                + string.Empty.PadLeft(width - 1, tt)
                + tr);

            for (int i = 0; i < height; i++)
            {
                Console.WriteLine(
                    string.Empty.PadLeft(xLocation, ' ')
                    + mm
                    + string.Empty.PadLeft(width - 1, ' ')
                    + mm);
            }

            Console.WriteLine(
                string.Empty.PadLeft(xLocation, ' ')
                + bl
                + string.Empty.PadLeft(width - 1, tt)
                + br);


            if (color.HasValue)
            {
                Console.ForegroundColor = savedColor;
            }

            if (keepOriginalCursorLocation)
            {
                Console.SetCursorPosition(savedCursorLeft, savedCursorTop);
            }
        }
    }

    /// <summary>
    /// Draws a rectangle in a console window using the top line of the buffer as the offset.
    /// </summary>
    /// <param name="xLocation">The left side position.</param>
    /// <param name="yLocation">The top position.</param>
    /// <param name="width">The width of the rectangle.</param>
    /// <param name="height">The right of the rectangle.</param>
    /// <param name="color">The color to use. null=uses current color Default: null</param>

    /// <summary>
    /// Specifies if the draw location should be based on the current cursor location or the
    /// top of the window.
    /// </summary>
    public enum DrawKind
    {
        BelowCursor,
        BelowCursorButKeepCursorLocation,
        FromTop,
    }

    /// <summary>
    /// Draws a rectangle in the console window.
    /// </summary>
    /// <param name="width">The width of the rectangle.</param>
    /// <param name="height">The right of the rectangle.</param>
    /// <param name="xLocation">The left side position.</param>
    /// <param name="yLocation">The top position.</param>
    /// <param name="drawKind">Where to draw the rectangle and 
    /// where to leave the cursor when finished.</param>
    /// <param name="color">The color to use. null=uses current color Default: null</param>
    /// <param name="useDoubleLines">Enables double line boarders. Default: false</param>

        public class WayToLearnX
    {
        // Méthode principale

        public static void Main()
        {
            ///* Tableau avec 3 lignes et 2 colonnes */
            //int[,] tab2D = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            //int i, j;

            ///* Affiche la valeur de chaque élément */
            //string[,] tabString = new string[3, 2] { {"un", "deux"},
            //                                         {"trois", "quatre"},
            //                                         {"cinq", "six"} };

            //// Autre écriture ne sera pas afficher, présenter pour syntaxe :
            //string[,] array2Db = new string[,] { { "one", "two" }, { "three", "four" },
            //                                        { "five", "six" } };

            //Console.WriteLine("///////////////////////////////////////////////////////////");
            //Console.WriteLine("Affichage des éléments des tableaux de string et de int :");
            //Console.WriteLine("///////////////////////////////////////////////////////////");
            //Console.WriteLine();
            //Console.WriteLine(".............. AFFICHAGE n° 1 de TabString SANS BOUCLE..............");
            //Console.WriteLine();
            //Console.WriteLine("première ligne, tab[0 ,0] et tab[0, 1] => " + tabString[0, 0] + " et " + tabString[0, 1]); //un et deux
            //Console.WriteLine();
            //Console.WriteLine("deuxième ligne, tab[1, 0]  et  tab[1, 1] => " + tabString[1, 0] + " et " + tabString[1, 1]); //trois et quatre
            //Console.WriteLine();
            //Console.WriteLine("troisième ligne,  tab[2, 0] et tab[2, 1] => " + tabString[2, 0] + " et " + tabString[2, 1]); //cinq et six
            //Console.WriteLine();
            Console.WriteLine("███████████████████████");
            Console.WriteLine("█" + " 7 " + " ▓ " + " 8 " + " ▓ " + " 9 " + " ▓ " + " * " + "█ " + " [X] ");
            Console.WriteLine("█" + " 4 " + " ▓ " + " 5 " + " ▓ " + " 6 " + " ▓ " + " / " + "█ ");
            Console.WriteLine("█" + " 1 " + " ▓ " + " 2 " + " ▓ " + " 3 " + " ▓ " + " - " + "█ ");
            Console.WriteLine("█" + " C " + " ▓ " + " 0 " + " ▓ " + " R " + " ▓ " + " + " + "█ ");
            Console.WriteLine("███████████████████████");
                    if(Local.Record.resultat > 9 || Local.Record.resultat < 0) { 
            Console.WriteLine("█" + " Resultat : " + Local.Record.resultat );
                Console.WriteLine("███████████████████████");
                    }
                    else
                    {
            Console.WriteLine("█" + " Resultat : " + Local.Record.resultat );
                        Console.WriteLine("███████████████████████");
                    }
                }
        }
}