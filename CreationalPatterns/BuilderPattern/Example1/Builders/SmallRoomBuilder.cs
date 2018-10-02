using BuilderPattern.Example1.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.Example1.Builders
{
    public class SmallRoomBuilder : IRoomBuilder
    {

        private Room _smallRoom;
        public SmallRoomBuilder()
        {
            _smallRoom = new Room("small");

        }

        public void BuildFurnitures()
        {
            Furniture cupboard = new Furniture("cupboard");
            _smallRoom.AddFurniture(cupboard);
        }

        public void BuildSubRooms()
        {
            Room toilet = new Room("tiolet");
            _smallRoom.AddSubRoom(toilet);

            Room bedRoom = new Room("bedroom");
            Furniture bed = new Furniture("bed");

            bedRoom.AddFurniture(bed);
            _smallRoom.AddSubRoom(bedRoom);
        }

        public Room GetSmallRoom()
        {
            return _smallRoom;
        }

    }
}
