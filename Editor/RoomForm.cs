using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextWorld.Editor
{
    public partial class RoomForm : Form
    {

        Room _room;
        List<int> _roomsIDList;
        ObjectForm _oF;
        DoorForm _dF;

        public RoomForm(ref Room room, List<int> roomsIDList)
        {
            InitializeComponent();
            _room = room;
            _roomsIDList = roomsIDList;
            if (_room.GetDoorsListLength() != 0)
            {
                for (int i = 0; i < _room.GetDoorsListLength(); i++)
                {
                    cb_DoorsList.Items.Add(_room.GetDoorPosition(i));
                }
            }
            if (_room.GetObjectsListLength() != 0)
            {
                for(int i = 0; i < _room.GetObjectsListLength(); i++)
                {
                    cb_ObjectsList.Items.Add(_room.GetObjectName(i));
                }
            }
        }

        private void btn_Add_Door_Click(object sender, EventArgs e)
        {
            _dF = new DoorForm(cb_DoorsList.Items, _roomsIDList);
            if (_dF.ShowDialog() == DialogResult.OK)
            {
                _room.AddDoor(_dF.GetPosition(), _dF.GetColor(), _dF.GetRelation());
                cb_DoorsList.Items.Add(_dF.GetPosition());
                _roomsIDList.Remove(_dF.GetRelation());
            }
        }

        private void btn_Del_Door_Click(object sender, EventArgs e)
        {
            _roomsIDList.Add(_room.GetDoorNextID((Direction)cb_DoorsList.SelectedItem));
            _roomsIDList.Sort();
            cb_DoorsList.Text = "";
            _room.RemoveDoor((Direction)cb_DoorsList.SelectedItem);
            cb_DoorsList.Items.Remove((Direction)cb_DoorsList.SelectedItem);
        }


        private void btn_Add_Object_Click(object sender, EventArgs e)
        {
            _oF = new ObjectForm(cb_ObjectsList.Items);
            if (_oF.ShowDialog() == DialogResult.OK)
            {
                if (_oF.GetKeyColor() != Colors.White) _room.AddObject(_oF.GetName(), _oF.GetColor(), _oF.GetKeyColor());
                else _room.AddObject(_oF.GetName(), _oF.GetColor());
                cb_ObjectsList.Items.Add(_oF.GetName());
            }
        }

        private void btn_Del_Object_Click(object sender, EventArgs e)
        {
            _room.RemoveObject((Names)cb_ObjectsList.SelectedItem);
            cb_ObjectsList.Items.Remove((Names)cb_ObjectsList.SelectedItem);
        }


        private void btn_Save_Click(object sender, EventArgs e)
        {
            _room.AddDescription(rtb_Description.Text);
        }

        private void cb_DoorsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.RemoveAll();
            toolTip.SetToolTip(cb_DoorsList,"Цвет: " + _room.GetDoorColor((Direction)cb_DoorsList.SelectedItem).ToString());
        }

        private void cb_ObjectsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var objName = (Names)cb_ObjectsList.SelectedItem;
            string InfoObject ="Цвет: " + _room.GetObjectColor(objName).ToString();
            if (_room.IsHaveKeyInObject(objName))
            {
                InfoObject += "\nЦвет ключа: " + _room.GetKeyColorInObject(objName);
            } 
            ToolTip toolTip = new ToolTip();
            toolTip.RemoveAll();
            toolTip.SetToolTip(cb_ObjectsList, InfoObject);
        }
    }
}
