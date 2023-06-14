using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hook.Smth
{
    class Program
    {
        class BlockWindows
        {
            [DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError = true)]
            static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
            [DllImport("user32.dll", EntryPoint = "SendMessage", SetLastError = true)]
            static extern IntPtr SendMessage(IntPtr hWnd, Int32 Msg, IntPtr wParam, IntPtr lParam);

            const int WM_COMMAND = 0x111;
            const int MIN_ALL = 419;
            const int MIN_ALL_UNDO = 416;

            private const int WH_KEYBOARD_LL = 13;
            private const int WH_MOUSE_LL = 14;

            private const int WM_MOUSEMOVE = 0x0200;
            private const int WM_KEYDOWN = 0x0100;

            private static IntPtr keyHook = IntPtr.Zero;
            private static IntPtr mouseHook = IntPtr.Zero;

            private static Keyboard keyboard = new Keyboard();

            public static void Start()
            {
                keyHook = SetHook(KeyboardHookCallback, WH_KEYBOARD_LL);

                Application.Run();

                UnhookWindowsHookEx(keyHook);
            }

            private static IntPtr SetHook(HookProc proc, int hookId)
            {
                using (Process curProcess = Process.GetCurrentProcess())
                using (ProcessModule curModule = curProcess.MainModule)
                {
                    return SetWindowsHookEx(hookId, proc, GetModuleHandle(curModule.ModuleName), 0);
                }
            }
            private static IntPtr KeyboardHookCallback(int nCode, IntPtr wParam, IntPtr lParam)
            {
                if (nCode < 0)
                {
                    return CallNextHookEx(keyHook, nCode, wParam, lParam);
                }

                if (wParam == (IntPtr)WM_KEYDOWN)
                {
                    // int vkCode = Marshal.ReadInt32(lParam);

                    System.Media.SoundPlayer player = new System.Media.SoundPlayer("Win_error.wav");
                    player.Play();

                    Parallel.For(1, 5, (x) => MessageBox.Show("Ups..."));
                    IntPtr lHwnd = FindWindow("Shell_TrayWnd", null);
                    // свернуть
                    SendMessage(lHwnd, WM_COMMAND, (IntPtr)MIN_ALL, IntPtr.Zero);

                    return CallNextHookEx(keyHook, nCode, wParam, lParam);
                }

                return default(IntPtr);
            }
            private static IntPtr MouseHookCallback(int nCode, IntPtr wParam, IntPtr lParam)
            {
                if (nCode < 0)
                    return CallNextHookEx(keyHook, nCode, wParam, lParam);

                if (wParam == (IntPtr)WM_MOUSEMOVE)
                {
                    
                    //int X = Marshal.ReadInt32(lParam);
                    //if (X < 400) return (IntPtr)1;
                }
                return CallNextHookEx(mouseHook, nCode, wParam, lParam);
            }

            private delegate IntPtr HookProc(int nCode, IntPtr wParam, IntPtr lParam);

            [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            private static extern IntPtr SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr hMod, uint dwThreadId);

            [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            private static extern bool UnhookWindowsHookEx(IntPtr hhk);

            [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

            [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            private static extern IntPtr GetModuleHandle(string lpModuleName);
        }

        static void Main(string[] args)
        {
            BlockWindows.Start();
            Console.ReadKey();
        }
    }
}
