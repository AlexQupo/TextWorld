using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextWorld
{
    public enum Names
    {
        Chest,
        Cupboard
    }
    [Serializable]
    public class Object
    {
        Names _name;
        Colors _color;
        Key _key = new Key(Colors.White);//Белые ключи - пустышки
        bool _isLocked;

        public Object(Names name, Colors color)
        {
            _name = name;
            _color = color;
            IsLock();
        }
        public Object(Names name, Colors color, Colors kColor)
        {
            _name = name;
            _color = color;
            _key = new Key(kColor);
            IsLock();
        }
        public Names GetName()
        {
            return _name;
        }
        public Colors GetColor()
        {
            return _color;
        }
        public Colors GetKeyColor()
        {
            return _key.GetColor();
        }
        public bool GetStatus()
        {
            return _isLocked;
        }
        public bool IsHaveKey()
        {
            if (_key.GetColor() == Colors.White)
            {
                return false;
            }
            else
                return true;
        }
        public Key TakeKey()
        {
            Key tempKey = _key;
            RemoveKey();
            return tempKey;
        }
        void IsLock()
        {
            if (_color == Colors.White) _isLocked = false;
            else _isLocked = true;
        }
        void RemoveKey()
        {
            _key = new Key(Colors.White);
        }

    }
}
