using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextWorld
{
    [Serializable]
    public class Door
    {
        Direction _position;
        Colors _color;
        int _nextRoomId;
        bool _isLocked;

        public Door(Direction pos, Colors col, int tpId)
        {
            _position = pos;
            _color = col;
            _nextRoomId = tpId;
            CheckLock();
        }
        public Direction GetPosition()
        {
            return _position;
        }
        public Colors GetColor()
        {
            return _color;
        }
        public int GetNextId()
        {
            return _nextRoomId;
        }
        public Direction GetReversePosition()
        {
            if ((int)_position % 2 == 0)
                if (_position == Direction.East) return Direction.West;
                else return Direction.East;
            else if (_position == Direction.North) return Direction.South;
            else return Direction.North;
        }
        public bool GetStatus()
        {
            return _isLocked;
        }
        void CheckLock()
        {
            if (_color == Colors.White) _isLocked = false;
            else _isLocked = true;
        }

    }
}
