using ConsoleApp1;
using System.Drawing;
using System.Runtime.CompilerServices;

/*
https://stackoverflow.com/questions/1944481/console-app-mouse-click-x-y-coordinate-detection-comparison
*/

ConsoleListener.MouseEvent += ConsoleListener_MouseEvent;
ConsoleListener.KeyEvent += ConsoleListener_KeyEvent;
ConsoleListener.WindowBufferSizeEvent += ConsoleListener_WindowBufferSizeEvent;
ConsoleListener.Start();

Draw.WayToLearnX.Main();

while (ConsoleListener.IsRunning())
{ }

void ConsoleListener_WindowBufferSizeEvent(NativeMethods.WINDOW_BUFFER_SIZE_RECORD r)
{
    //    Console.WriteLine("Wnd buffer size  ");
    //    Console.WriteLine(string.Format("    dwSize.X  .......:  {0}  ", r.dwSize.X));
    //    Console.WriteLine(string.Format("    dwSize.Y  .......:  {0}  ", r.dwSize.Y));
}
void ConsoleListener_KeyEvent(NativeMethods.KEY_EVENT_RECORD r)
{

    if (r.wVirtualKeyCode == (int)ConsoleKey.Escape) { ConsoleListener.Stop(); return; }
    if (r.wVirtualKeyCode == (int)ConsoleKey.C)
    {
        Console.Clear();
        Draw.WayToLearnX.Main();
        return;
    }
}
void ConsoleListener_MouseEvent(NativeMethods.MOUSE_EVENT_RECORD r)
{
    //Console.WriteLine("Mouse event");
    //Console.WriteLine(string.Format("    X ...............:   {0,4:0}  ", r.dwMousePosition.X));
    //Console.WriteLine(string.Format("    Y ...............:   {0,4:0}  ", r.dwMousePosition.Y));
    //Console.WriteLine(string.Format("    dwButtonState ...: 0x{0:X4}  ", r.dwButtonState));
    //Console.WriteLine(string.Format("    dwControlKeyState: 0x{0:X4}  ", r.dwControlKeyState));
    //Console.WriteLine(string.Format("    dwEventFlags ....: 0x{0:X4}  ", r.dwEventFlags));
    Calcul(r);
}

void Calcul(NativeMethods.MOUSE_EVENT_RECORD r)
{
    //string num1 ;
    //string num2 ;
    //int calc1 = 0;
    //int calc2 = 0;
    //int colonne_G = 2;
    //int colonne_M_G =8;
    //int colonne_M_D = 14;
    //int colonne_D = 20;
    //int ligne_H = 0;
    //int ligne_M_H = 1;
    //int ligne_M_B = 2;
    //int ligne_B = 3;
    //int BTN_Press = 0x0001;
    //string ope = "";
    //int resultat = 0;
    //string resultat_litt;
    //bool ope_check = false;
    if (r.dwButtonState == Local.Record.BTN_PRESS)
    {
        switch (r.dwMousePosition.X)
        {
            case Local.Record.COLONNE_G:
                break;

            case Local.Record.COLONNE_M_G:
                break;

            case Local.Record.COLONNE_M_D:
                break;

            case Local.Record.COLONNE_D:
                break;
        }



        if (r.dwMousePosition.X == Local.Record.COLONNE_G)
        {
            if (r.dwMousePosition.Y == Local.Record.LIGNE_H)
            {
                if (Local.Record.ope_check == false)
                {
                    Console.Clear();
                    Draw.WayToLearnX.Main();
                    Local.Record.num1 += "7";
                    Console.Write(Local.Record.num1);
                }
                else
                {
                    Console.Clear();
                    Draw.WayToLearnX.Main();
                    Local.Record.num2 += "7";
                    Console.Write(Local.Record.num2);
                }
            }
            if (r.dwMousePosition.Y == Local.Record.LIGNE_M_H)
            {
                if (Local.Record.ope_check == false)
                {
                    Console.Clear();
                    Draw.WayToLearnX.Main();
                    Local.Record.num1 += "4";
                    Console.Write(Local.Record.num1);
                }
                else
                {
                    Console.Clear();
                    Draw.WayToLearnX.Main();
                    Local.Record.num2 += "4";
                    Console.Write(Local.Record.num2);
                }
            }
            if (r.dwMousePosition.Y == Local.Record.LIGNE_M_B)
            {
                if (Local.Record.ope_check == false)
                {
                    Console.Clear();
                    Draw.WayToLearnX.Main();
                    Local.Record.num1 += "1";
                    Console.Write(Local.Record.num1);
                }
                else
                {
                    Console.Clear();
                    Draw.WayToLearnX.Main();
                    Local.Record.num2 += "1";
                    Console.Write(Local.Record.num2);
                }
            }
            if (r.dwMousePosition.Y == Local.Record.LIGNE_B)
            {
                if (Local.Record.ope_check == false)
                {
                    Local.Record.num1 = "0";
                    Local.Record.num2 = "0";
                    Console.Clear();
                    Draw.WayToLearnX.Main();
                }
                else
                {
                    Local.Record.num1 = "0";
                    Local.Record.num2 = "0";
                    Console.Clear();
                    Draw.WayToLearnX.Main();
                }
            }
        }
        if (r.dwMousePosition.X == Local.Record.COLONNE_M_G)
        {
            if (r.dwMousePosition.Y == Local.Record.LIGNE_H)
            {
                if (Local.Record.ope_check == false)
                {
                    Console.Clear();
                    Draw.WayToLearnX.Main();
                    Local.Record.num1 += "8";
                    Console.Write(Local.Record.num1);
                }
                else
                {
                    Console.Clear();
                    Draw.WayToLearnX.Main();
                    Local.Record.num2 += "8";
                    Console.Write(Local.Record.num2);
                }
            }
            if (r.dwMousePosition.Y == Local.Record.LIGNE_M_H)
            {
                if (Local.Record.ope_check == false)
                {
                    Console.Clear();
                    Draw.WayToLearnX.Main();
                    Local.Record.num1 += "5";
                    Console.Write(Local.Record.num1);
                }
                else
                {
                    Console.Clear();
                    Draw.WayToLearnX.Main();
                    Local.Record.num2 += "5";
                    Console.Write(Local.Record.num2);
                }
            }
            if (r.dwMousePosition.Y == Local.Record.LIGNE_M_B)
            {
                if (Local.Record.ope_check == false)
                {
                    Console.Clear();
                    Draw.WayToLearnX.Main();
                    Local.Record.num1 += "2";
                    Console.Write(Local.Record.num1);
                }
                else
                {
                    Console.Clear();
                    Draw.WayToLearnX.Main();
                    Local.Record.num2 += "2";
                    Console.Write(Local.Record.num2);
                }
            }
            if (r.dwMousePosition.Y == Local.Record.LIGNE_B)
            {
                if (Local.Record.ope_check == false)
                {
                    Console.Clear();
                    Draw.WayToLearnX.Main();
                    Local.Record.num1 += "0";
                    Console.Write(Local.Record.num1);
                }
                else
                {
                    Console.Clear();
                    Draw.WayToLearnX.Main();
                    Local.Record.num2 += "0";
                    Console.Write(Local.Record.num2);
                }
            }
        }
        if (r.dwMousePosition.X == Local.Record.COLONNE_M_D)
        {
            if (r.dwMousePosition.Y == Local.Record.LIGNE_H)
            {
                if (Local.Record.ope_check == false)
                {
                    Console.Clear();
                    Draw.WayToLearnX.Main();
                    Local.Record.num1 += "9";
                    Console.Write(Local.Record.num1);
                }
                else
                {
                    Console.Clear();
                    Draw.WayToLearnX.Main();
                    Local.Record.num2 += "9";
                    Console.Write(Local.Record.num2);
                }
            }
            if (r.dwMousePosition.Y == Local.Record.LIGNE_M_H)
            {
                if (Local.Record.ope_check == false)
                {
                    Console.Clear();
                    Draw.WayToLearnX.Main();
                    Local.Record.num1 += "6";
                    Console.Write(Local.Record.num1);
                }
                else
                {
                    Console.Clear();
                    Draw.WayToLearnX.Main();
                    Local.Record.num2 += "6";
                    Console.Write(Local.Record.num2);
                }
            }
            if (r.dwMousePosition.Y == Local.Record.LIGNE_M_B)
            {
                if (Local.Record.ope_check == false)
                {
                    Console.Clear();
                    Draw.WayToLearnX.Main();
                    Local.Record.num1 += "3";
                    Console.Write(Local.Record.num1);
                }
                else
                {
                    Console.Clear();
                    Draw.WayToLearnX.Main();
                    Local.Record.num2 += "3";
                    Console.Write(Local.Record.num2);
                }
            }
            if (r.dwMousePosition.Y == Local.Record.LIGNE_B)
            {
                Local.Record.ope_check = true;
                string num1 = Local.Record.num1 == null ? "" : Local.Record.num1;
                double.TryParse(num1, out Local.Record.calc1);

                string num2 = Local.Record.num2 == null ? "" : Local.Record.num2;
                double.TryParse(num2, out Local.Record.calc2);

                //Local.Record.resultat_litt = Console.ReadLine();
                //Local.Record.resultat = Convert.ToInt32(Local.Record.resultat_litt);
                Calc();
            }
        }
        if (r.dwMousePosition.X == Local.Record.COLONNE_D)
        {
            if (r.dwMousePosition.Y == Local.Record.LIGNE_H)
            {
                if (Local.Record.ope_check == false)
                {
                    Console.Clear();
                    Draw.WayToLearnX.Main();
                    Local.Record.ope = "*";
                    Console.Write(Local.Record.ope);
                    Local.Record.ope_check = true;
                }
                else
                {
                    Console.Clear();
                    Draw.WayToLearnX.Main();
                    Console.Write(Local.Record.ope);
                }
            }
            if (r.dwMousePosition.Y == Local.Record.LIGNE_M_H)
            {
                if (Local.Record.ope_check == false)
                {
                    Console.Clear();
                    Draw.WayToLearnX.Main();
                    Local.Record.ope = "/";
                    Console.Write(Local.Record.ope);
                    Local.Record.ope_check = true;
                }
                else
                {
                    Console.Clear();
                    Draw.WayToLearnX.Main();
                    Console.Write(Local.Record.ope);
                }
            }
            if (r.dwMousePosition.Y == Local.Record.LIGNE_M_B)
            {
                if (Local.Record.ope_check == false)
                {
                    Console.Clear();
                    Draw.WayToLearnX.Main();
                    Local.Record.ope = "-";
                    Console.Write(Local.Record.ope);
                    Local.Record.ope_check = true;
                }
                else
                {
                    Console.Clear();
                    Draw.WayToLearnX.Main();
                    Console.Write(Local.Record.ope);
                }
            }
            if (r.dwMousePosition.Y == Local.Record.LIGNE_B)
            {
                if (Local.Record.ope_check == false)
                {
                    Console.Clear();
                    Draw.WayToLearnX.Main();
                    Local.Record.ope = "+";
                    Console.Write(Local.Record.ope);
                    Local.Record.ope_check = true;
                }
                else
                {
                    Console.Clear();
                    Draw.WayToLearnX.Main();
                    Console.Write(Local.Record.ope);
                }
            }
        }
        if (r.dwMousePosition.X == Local.Record.COLONNE_Q) {
            if (r.dwMousePosition.Y == Local.Record.LIGNE_H) {
                ConsoleListener.Stop(); return; 
            }
        }

    }
    
    void Calc()
    {
       if (Local.Record.ope == "*")
        {
            Local.Record.resultat = Local.Record.calc1 * Local.Record.calc2;
            Console.WriteLine(" Resultat : " + Local.Record.resultat);
            Local.Record.ope_check = false;
            Local.Record.num1 = "0";
            Local.Record.num2 = "0";
            Local.Record.calc1 = 0;
            Local.Record.calc2 = 0;
            Console.Clear();
            Draw.WayToLearnX.Main();
        }
        if (Local.Record.ope == "/")
        {
            if(Local.Record.calc2 == 0)
            {

                Console.WriteLine(" ! Impossible !");
                Local.Record.ope_check = false;
                Console.Clear();
                Draw.WayToLearnX.Main();
            }
            else {
                Local.Record.resultat = Local.Record.calc1 / Local.Record.calc2;
            Console.WriteLine(" Resultat : " + Local.Record.resultat);
            Local.Record.ope_check = false;
                Local.Record.num1 = "0";
                Local.Record.num2 = "0";
                Local.Record.calc1 = 0;
                Local.Record.calc2 = 0;
                Console.Clear();
                Draw.WayToLearnX.Main();
            }
        }
        if (Local.Record.ope == "-")
        {
            Local.Record.resultat = Local.Record.calc1 - Local.Record.calc2;
            Console.WriteLine(" Resultat : " + Local.Record.resultat);
            Local.Record.ope_check = false; 
            Local.Record.num1 = "0";
            Local.Record.num2 = "0";
            Local.Record.calc1 = 0;
            Local.Record.calc2 = 0;
            Console.Clear();
            Draw.WayToLearnX.Main();
        }
        if (Local.Record.ope == "+")
        {
            Local.Record.resultat = Local.Record.calc1 + Local.Record.calc2;
            Console.WriteLine(" Resultat : " + Local.Record.resultat);
            Local.Record.ope_check = false;
            Local.Record.num1 = "0";
            Local.Record.num2 = "0";
            Local.Record.calc1 = 0;
            Local.Record.calc2 = 0;
            Console.Clear();
            Draw.WayToLearnX.Main();
        }
    }
}