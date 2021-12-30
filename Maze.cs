using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextWorld
{
    [Serializable]
    public class Maze
    {
        string _name;
        int _length;
        public List<Room> Rooms { get; private set; }

        public void Create(string name, int length)
        {
            _name = name;
            _length = length;
            CreateRooms();
        }
        void CreateRooms()
        {
            Rooms = new List<Room>();
            for (int i = 0; i < _length; i++) Rooms.Add(new Room(i));
            Rooms[_length - 1].SetExitType();
        }

        public int GetLength()
        {
            return _length;
        }
        public string GetName()
        {
            return _name; 
        }
        public List<int> GetRoomsId()
        {
            List<int> temp = new List<int>();
            for(int i = 0; i < _length; i++)
            { 
                temp.Add(i);
            }
            return temp;
        }

        public void AddDoorForNextRoom(int id, Direction pos, Colors color, int tpid)
        {
            Rooms[tpid].AddDoor(GetReversePositionDoorForRoom(id, pos), color, id);
        }
        public void RemoveDoorForNextRoom(int id, Direction pos, int tpid)
        {
            Rooms[tpid].RemoveDoor(GetReversePositionDoorForRoom(tpid, pos));
        }
        public bool IsNullSelectedDoorPositionForRoom(int id, Direction dir)
        {
            return Rooms[id].IsNullSelectedDoorPosition(dir);
        }

        Direction GetReversePositionDoorForRoom(int id, Direction pos)
        {
            return Rooms[id].GetReversePositionDoor(pos);
        }
    }
}
