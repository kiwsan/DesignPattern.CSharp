using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace BuilderPattern.Example1
{
    public class Room
    {

        private string roomType;
        private IList<Furniture> furnitures;
        private IList<Room> subRooms;
        public Room(string roomType)
        {
            this.roomType = roomType;
            furnitures = new List<Furniture>();
            subRooms = new List<Room>();
        }

        public void ShowRoomDetail()
        {

        }

        public void AddFurniture(Furniture furniture)
        {
            furnitures.Add(furniture);
        }

        public void AddSubRoom(Room room)
        {
            subRooms.Add(room);
        }

        private void ShowSubRoom()
        {
            Console.WriteLine("-- Sub Room Details --");

            int subRoomCount = 0;
            int furnitureCount = 0;
            Room subRoom = null;
            for (subRoomCount = 0; subRoomCount < subRooms.Count; subRoomCount++)
            {
                subRoom = subRooms[subRoomCount];

                Console.WriteLine($"This is Sub Room: {subRoom.roomType}");

                Furniture furniture = null;
                for (furnitureCount = 0; furnitureCount < furnitures.Count; furnitureCount++)
                {
                    furniture = furnitures[furnitureCount];

                    Console.WriteLine($"Furniture in ({subRoom.roomType}): {furniture.GetFurnitureType()}");
                }
            }

        }

        public void ShowTheRoom()
        {
            Console.WriteLine($"This is Room: {roomType}");

            int furnitureCount = 0;

            Furniture furniture = null;
            for (furnitureCount = 0; furnitureCount < furnitures.Count; furnitureCount++)
            {
                furniture = furnitures[furnitureCount];

                Console.WriteLine($"Furniture in Room: {furniture.GetFurnitureType()}");
            }

            ShowSubRoom();
        }

    }
}
