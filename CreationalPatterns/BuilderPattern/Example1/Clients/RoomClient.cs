using BuilderPattern.Example1.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.Example1.Clients
{
    public class RoomClient
    {

        public void Run() {

            // Build Small Room 
            SmallRoomBuilder smallRoomBuilder = new SmallRoomBuilder();
            RoomDirector roomDirector = new RoomDirector(smallRoomBuilder);
            roomDirector.Construct();

            Room room = smallRoomBuilder.GetSmallRoom();
            room.ShowTheRoom();

            //Build Big Room
            BigRoomBuilder bigRoomBuilder = new BigRoomBuilder();
            roomDirector = new RoomDirector(bigRoomBuilder);
            roomDirector.Construct();

            room = bigRoomBuilder.GetBigRoom();
            room.ShowTheRoom();

        }

    }
}
