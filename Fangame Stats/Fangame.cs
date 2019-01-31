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
        public string Title, CurrentStatus;
        public (double X, double Y) Pos, DistanceTravelled;
        public int Frames, Room, RoomChanges;
        public double Deaths;
        public VAMemory VAM;
        public IntPtr Base = (IntPtr)0x400000; //base static? 0x400000
        public List<int> RoomsVisited = new List<int>();
        public bool RoomChanged;

        protected Fangame(string title)
        {
            Title = title;
        }

        public bool EnsureGame()
        {
            if (VAM == null)
            {
                Process[] x = Process.GetProcessesByName(Title);
                if (x.Length != 0)
                {
                    VAM = new VAMemory(Title);
                }
                else
                {
                    CurrentStatus = "Waiting For Game...";
                    return false;
                }
            }
            else if (Process.GetProcessesByName(Title).Length == 0)
            {
                VAM = null;
                CurrentStatus = "Waiting For Game...";
                return false;
            }
            CurrentStatus = "Game Found!";
            return true;
        }
    }
}
