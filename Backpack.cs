using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextWorld
{
    public class Backpack//В разработке
    {
        List<Key> _keys = new List<Key>();

        public void AddKey(Key key)
        {
            _keys.Add(key);
            _keys.Distinct();//нужно проверить
            RemoveTransparentKey();
        }
        public void ShowKeys()
        {
            _keys.ForEach(key => key.GetColor());
        }
        void KeyCheck()
        {

        }
        void RemoveTransparentKey()
        {
            _keys.ForEach(key =>
            {
                if (key.GetColor() == Colors.White) _keys.Remove(key); 
            });
        }
        //Реализовать инвентарь ключей, отработать ShowKeys
    }
}
