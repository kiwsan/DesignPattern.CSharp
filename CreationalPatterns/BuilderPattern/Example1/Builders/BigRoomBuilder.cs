using BuilderPattern.Example1.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.Example1.Builders
{
    public class BigRoomBuilder : IRoomBuilder
    {

        private Room _bigRoom;
        public BigRoomBuilder()
        {
            _bigRoom = new Room("bigroom");
        }

        public void BuildFurnitures()
        {
            Furniture cupboard = new Furniture("cupboard");
            _bigRoom.AddFurniture(cupboard);

            Furniture bookChest = new Furniture("bookchest");
            _bigRoom.AddFurniture(bookChest);
        }

        public void BuildSubRooms()
        {
            Room toilet = new Room("toilet");
            _bigRoom.AddSubRoom(toilet);

            Room bedRoom = new Room("bedroom");
            Furniture bed = new Furniture("bed");
            bedRoom.AddFurniture(bed);

            Furniture closet = new Furniture("closet");
            bedRoom.AddFurniture(closet);

            _bigRoom.AddSubRoom(bedRoom);

            Room dinerRoom = new Room("dinerroom");
            Furniture table = new Furniture("table");
            dinerRoom.AddFurniture(table);

            _bigRoom.AddSubRoom(dinerRoom);
        }

        public Room GetBigRoom()
        {
            return _bigRoom;
        }

    }
}
