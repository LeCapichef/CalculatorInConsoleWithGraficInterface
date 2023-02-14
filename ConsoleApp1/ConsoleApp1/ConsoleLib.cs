using ConsoleApp1;
using System;
using System.Runtime.InteropServices;
using System.Threading;
using static ConsoleApp1.NativeMethods;

namespace ConsoleLib
{
    public static class ConsoleListener
    {
        public static event ConsoleMouseEvent MouseEvent;

        public static event ConsoleKeyEvent KeyEvent;

        public static event ConsoleWindowBufferSizeEvent WindowBufferSizeEvent;

        private static bool Run = false;


        public static void Start()
        {
            if (!Run)
            {
                Run = true;
                IntPtr handleIn = NativeMethods.GetStdHandle(STD_INPUT_HANDLE);
                new Thread(() =>
                {
                    while (true)
                    {
                        uint numRead = 0;
                        NativeMethods.INPUT_RECORD[] record = NewMethod();
                        record[0] = new NativeMethods.INPUT_RECORD();
                        ReadConsoleInput(handleIn, record, 1, ref numRead);
                        if (Run)
                            switch (record[0].EventType)
                            {
                                case NativeMethods.INPUT_RECORD.MOUSE_EVENT:
                                    MouseEvent?.Invoke(record[0].MouseEvent);
                                    break;
                                case NativeMethods.INPUT_RECORD.KEY_EVENT:
                                    KeyEvent?.Invoke(record[0].KeyEvent);
                                    break;
                                case NativeMethods.INPUT_RECORD.WINDOW_BUFFER_SIZE_EVENT:
                                    WindowBufferSizeEvent?.Invoke(record[0].WindowBufferSizeEvent);
                                    break;
                            }
                        else
                        {
                            uint numWritten = 0;
                            WriteConsoleInput(handleIn, record, 1, ref numWritten);
                            return;
                        }
                    }
                }).Start();
            }
        }

        private static NativeMethods.INPUT_RECORD[] NewMethod()
        {
            return new NativeMethods.INPUT_RECORD[1];
        }

        public static void Stop() => Run = false;


        public delegate void ConsoleMouseEvent(NativeMethods.MOUSE_EVENT_RECORD r);

        public delegate void ConsoleKeyEvent(NativeMethods.KEY_EVENT_RECORD r);

        public delegate void ConsoleWindowBufferSizeEvent(NativeMethods.WINDOW_BUFFER_SIZE_RECORD r);

    }
}

