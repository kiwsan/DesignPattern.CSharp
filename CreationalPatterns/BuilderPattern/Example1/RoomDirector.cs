using BuilderPattern.Example1.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.Example1
{
   public class RoomDirector
    {

        private IRoomBuilder _roomBuilder;
        public RoomDirector(IRoomBuilder _roomBuilder)
        {
            this._roomBuilder = _roomBuilder;
        }

        public void Construct() {
            _roomBuilder.BuildFurnitures();
            _roomBuilder.BuildSubRooms();
        }

    }
}
