using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fangame_Stats
{
    class Kaenbyou1 : Fangame
    {
        public static new string Title = "I wanna be the Kaenbyou";

        public Kaenbyou1() : base(Title)
        {

        }

        public string GetStats()
        {
            GetFrames();
            GetRoom();
            GetPos();
            GetDeaths();
            return "Title: " + Title + Environment.NewLine +
                "Frames: " + Frames + Environment.NewLine +
                "Room: " + Room + Environment.NewLine +
                "Rooms Visited: " + RoomsVisited.Count + Environment.NewLine +
                "Total Room Changes: " + RoomChanges + Environment.NewLine +
                "X: " + Math.Round(Pos.X, 2) + Environment.NewLine +
                "Y: " + Math.Round(Pos.Y, 2) + Environment.NewLine +
                "Distance Travelled: " + Math.Round((DistanceTravelled.X + DistanceTravelled.Y) / 32, 2) + " Blocks" + Environment.NewLine +
                "Deaths: " + Deaths + Environment.NewLine;
        }

        public void GetRoom()
        {
            int temp = Room;
            Room = VAM.ReadInt32(Base + 0x2C73C8);
            if (temp != Room)
            {
                RoomChanges++;
                RoomChanged = true;
            }
            else
            {
                RoomChanged = false;
            }
            if (!RoomsVisited.Contains(Room))
            {
                RoomsVisited.Add(Room);
            }
        }

        public void GetFrames()
        {
            Frames = VAM.ReadInt32(Base + 0x18D4B8);
        }

        public void GetPos()
        {
            (double X, double Y) temp = Pos;
            Pos.X = VAM.ReadDouble(
                (IntPtr)VAM.ReadInt32(
                    (IntPtr)VAM.ReadInt32(
                        (IntPtr)VAM.ReadInt32(
                            (IntPtr)VAM.ReadInt32(
                                Base + 0x2C73C4
                            ) + 0x7C
                        ) + 0x330
                    ) + 0x0
                ) + 0x50
            );
            Pos.Y = VAM.ReadDouble(
                (IntPtr)VAM.ReadInt32(
                    (IntPtr)VAM.ReadInt32(
                        (IntPtr)VAM.ReadInt32(
                            (IntPtr)VAM.ReadInt32(
                                Base + 0x2C73C4
                            ) + 0x7C
                        ) + 0x330
                    ) + 0x0
                ) + 0x58
            );
            if (!RoomChanged)
            {
                if (Pos.X != temp.X)
                {
                    double diff = Math.Abs(temp.X - Pos.X);
                    if (diff < 100)
                    {
                        DistanceTravelled.X += diff;
                    }
                }
                if (Pos.Y != temp.Y)
                {
                    double diff = Math.Abs(temp.Y - Pos.Y);
                    if (diff < 100)
                    {
                        DistanceTravelled.Y += diff;
                    }
                }
            }
        }

        public void GetDeaths()
        {
            Deaths = VAM.ReadDouble(
                (IntPtr)VAM.ReadInt32(
                    (IntPtr)VAM.ReadInt32(
                        (IntPtr)VAM.ReadInt32(
                            (IntPtr)VAM.ReadInt32(
                                (IntPtr)VAM.ReadInt32(
                                    Base + 0x18D5D4
                                ) + 0x14
                            ) + 0xB4
                        ) + 0x4
                    ) + 0xC
                ) + 0x2E0
            );
        }
    }
}
