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
    public partial class MazeForm : Form
    {
        WorldsForm _wF;
        Maze _maze;
        Room _room;
        RoomForm _rF;
        List<int> _roomsIDList;
        public MazeForm(WorldsForm worldsF, ref Maze maze)
        {
            InitializeComponent();
            _wF = worldsF;
            _maze = maze;
        }
        
        private void btn_Enter_Click(object sender, EventArgs e)
        {
            int id = cb_roomsList.SelectedIndex;
            _room = _maze.Rooms[id];
            _roomsIDList.Remove(id);
            _rF = new RoomForm(ref _room, _roomsIDList);
            if (_rF.ShowDialog() == DialogResult.OK)
            {
                _maze.Rooms[id] = _room;
                Direction pos;
                Colors color;
                int tpId;
                for (int i = 0; i < _maze.Rooms[id].GetDoorsListLength(); i++)
                {
                    pos = _room.GetDoorPosition(i);
                    color = _room.GetDoorColor(pos);
                    tpId = _room.GetDoorNextID(pos);
                    if (_maze.IsNullSelectedDoorPositionForRoom(tpId, _room.GetReversePositionDoor(pos)))
                        _maze.AddDoorForNextRoom(id, pos, color, tpId);
                }
                cb_roomsList.SelectedIndex = 0;
                UpdateInfo();
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
            _wF.Show();
        }

        private void MazeForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < _maze.GetLength(); i++)
            {
                cb_roomsList.Items.Add(i);
            }
            cb_roomsList.SelectedIndex = 0;
        }

        private void cb_roomsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateInfo();
        }

        void UpdateInfo()
        {
            int id = cb_roomsList.SelectedIndex;
            lb_typeRoom.Text = "Тип комнаты: " + _maze.Rooms[id].GetType();
            rtb_description.Text = _maze.Rooms[id].GetDescription();
            lb_Relation.Text = "Связь с: ";
            _roomsIDList = _maze.GetRoomsId();
            for (int i = 0; i < _maze.Rooms[id].GetDoorsListLength(); i++)//Есть проблема с появлением нескольких дверей на одной стене
            {
                Direction pos = _maze.Rooms[id].GetDoorPosition(i);
                lb_Relation.Text += _maze.Rooms[id].GetDoorNextID(pos) + "  ";
                _roomsIDList.Remove(_maze.Rooms[id].GetDoorNextID(pos));
            }
            lb_Objects.Text = "Объекты: ";
            for (int j = 0; j < _maze.Rooms[id].GetObjectsListLength(); j++)
            {
                lb_Objects.Text += _maze.Rooms[id].GetObjectName(j) + "  ";
            }
        }
    }
}
