using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextWorld
{
    [Serializable]
    public struct Key
    {
        Colors _color;
        public Key(Colors color)
        {
            _color = color;
        }
        public Colors GetColor()
        {
            return _color;
        }
    }
}
