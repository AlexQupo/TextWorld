using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextWorld
{
    [Serializable]
    public class Room
    {
        List<Object> _objects = new List<Object>(2);
        List<Door> _doors = new List<Door>(4);
        string _description;
        int _id;
        string _type = "Обычная";

        public Room(int id)
        {
            _id = id;
            if (_id == 0) _type = "Стартовая";
        }
        public void AddDescription(string descr)
        {
            _description = descr;
        }
        public string GetDescription()
        {
            return _description;
        }
        public void SetExitType()
        {
            _type = "Конечная";
        }
        public new string GetType()
        {
            return _type;
        }

        void CheckDoorsListIsFull()
        {
            if (_doors.Capacity == _doors.Count) throw new Exception("Достигнуто максимальное количество дверей");

        }
        void CheckObjectsListIsFull()
        {
            if (_objects.Capacity == _objects.Count) throw new Exception("Достигнуто максимальное количество объектов");
        }
        void CheckDoorsListIsEmpty()
        {
            if (_doors.Count == 0) throw new Exception("Нет дверей");
        }
        void CheckObjectsListIsEmpty()
        {
            if (_objects.Count == 0) throw new Exception("Объектов нет");
        }

        public void AddDoor(Direction position, Colors color, int tpid)
        {
            CheckDoorsListIsFull();
            _doors.Add(new Door(position, color, tpid));
        }
        public void RemoveDoor(Direction pos)
        {
            CheckDoorsListIsEmpty();
            _doors.RemoveAll(door => door.GetPosition() == pos);
        }
        
        public void AddObject(Names name, Colors color)
        {
            CheckObjectsListIsFull();
            _objects.Add(new Object(name, color));
        }
        public void AddObject(Names name, Colors color, Colors kColor)
        {
            CheckObjectsListIsFull();
            _objects.Add(new Object(name, color, kColor));
        }
        public void RemoveObject(Names name)
        {
            CheckObjectsListIsEmpty();
            _objects.RemoveAll(obj => obj.GetName() == name);
        }

        public int GetDoorsListCapacity()
        {
            return _doors.Capacity;
        }
        public int GetObjectsListCapacity()
        {
            return _objects.Capacity;
        }
        public int GetDoorsListLength()
        {
            return _doors.Count;
        }
        public int GetObjectsListLength()
        {
            return _objects.Count;
        }

        public Colors GetDoorColor(Direction dir)
        {
            return _doors.Find(door => door.GetPosition() == dir).GetColor();
        }
        public int GetDoorNextID(Direction dir)
        {
            return _doors.Find(door => door.GetPosition() == dir).GetNextId();
        }
        public Direction GetReversePositionDoor(Direction dir)
        {
            return _doors.Find(door => door.GetPosition() == dir).GetReversePosition();
        }
        public bool GetDoorStatus(Direction dir)
        {
            return _doors.Find(door => door.GetPosition() == dir).GetStatus();
        }
        public bool IsNullSelectedDoorPosition(Direction dir)
        {
            if (_doors.Find(door => door.GetPosition() == dir) == null) return true;
            else return false;
        }
        public Direction GetDoorPosition(int index)
        {
            return _doors[index].GetPosition();
        }
        
        public Names GetObjectName(int index)
        {
            return _objects[index].GetName();
        }
        public Colors GetObjectColor(Names name)
        {
            return _objects.Find(obj => obj.GetName() == name).GetColor();
        }
        public bool GetObjectStatus(Names name)
        {
            return _objects.Find(obj => obj.GetName() == name).GetStatus();
        }
        public Key TakeKeyInObject(Names name)
        {
            return _objects.Find(obj => obj.GetName() == name).TakeKey();
        }
        public bool IsHaveKeyInObject(Names name)
        {
            return _objects.Find(obj => obj.GetName() == name).IsHaveKey();
        }
        public Colors GetKeyColorInObject(Names name)
        {
            return _objects.Find(obj => obj.GetName() == name).GetKeyColor();
        }
    }

}
