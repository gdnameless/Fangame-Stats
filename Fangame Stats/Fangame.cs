using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Fangame_Stats
{
    class Fangame
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        [DllImport("user32.dll", EntryPoint = "GetWindowText", CharSet = CharSet.Auto)]
        static extern IntPtr GetWindowCaption(IntPtr hwnd, StringBuilder lpString, int maxCount);

        string GetWindowCaption()
        {
            StringBuilder sb = new StringBuilder(256);
            GetWindowCaption(hwnd, sb, 256);
            return sb.ToString();
        }

        public string Title, CurrentStatus, ClassName;
        public (double X, double Y) Pos, DistanceTravelled;
        public int Time, Deaths, Room, RoomChanges, UniqueRoomChanges, nMaxCount = 100;
        public VAMemory VAM;
        public IntPtr Base, hwnd;
        public bool BaseGrabbed = false;
        public Process CurrentProcess;
        public StringBuilder stringBuilder = new StringBuilder();


        protected Fangame(string title)
        {
            Title = title;
        }

        public bool EnsureGame()
        {
            Process[] x = Process.GetProcessesByName(Title);
            if (VAM == null || !BaseGrabbed)
            {
                if (x.Length != 0)
                {
                    VAM = new VAMemory(Title);
                    if (!BaseGrabbed || Base == (IntPtr)0 || Base == null)
                    {
                        try
                        {
                            foreach (ProcessModule p in x[0].Modules)
                            {
                                if (p.ModuleName == Title + ".exe")
                                {
                                    Base = p.BaseAddress;
                                }
                            }
                            BaseGrabbed = !(Base == (IntPtr)0 || Base == null);
                            CurrentProcess = x[0];
                            hwnd = x[0].MainWindowHandle;
                            return BaseGrabbed;
                        }
                        catch
                        {
                            CurrentStatus = "Encountered Error In Reading Modules";
                        }
                    }
                }
                else
                {
                    CurrentStatus = "Waiting For Game...";
                    return false;
                }
            }
            else if (x.Length == 0)
            {
                VAM = null;
                CurrentStatus = "Waiting For Game...";
                return false;
            }
            CurrentStatus = "Game Found! Base: " + Base;
            return true;
        }

        public string GetTitle()
        {
            //return GetWindowCaption();
            //return CurrentProcess.MainWindowTitle;
            try
            {
                GetWindowText(hwnd, stringBuilder, nMaxCount);
            }
            catch (AccessViolationException)
            {
                return "AccessViolationException";
            }
            return stringBuilder.ToString();
            //needs fix i guess?
            //i cant find a function that does what i want it to ;-;
            //im just gonna get the deaths and time by game data i guess
        }

        public string GetInformationFromTitle()
        {
            string s = GetTitle();
            return s;
        }
    }
}
