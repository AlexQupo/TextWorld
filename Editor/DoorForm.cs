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
    public partial class DoorForm : Form
    {
        List<int> _idRoomList;
        Colors _color;
        int _relation;
        Direction _position;
        bool _iserror = false;
        public DoorForm(ComboBox.ObjectCollection availableDiretions, List<int> idRoomList)
        {
            InitializeComponent();
            _idRoomList = idRoomList;
            try
            {
                var ColorsList = Enum.GetValues(typeof(Colors)).Cast<Colors>();
                foreach (var color in ColorsList)
                {
                        cb_Color.Items.Add(color);
                }
                cb_Color.SelectedIndex = 0;
                var DoorsList = Enum.GetValues(typeof(Direction)).Cast<Direction>();
                foreach (var door in DoorsList)
                {
                    if (!availableDiretions.Contains(door))
                        cb_Position.Items.Add(door);
                }
                cb_Position.SelectedIndex = 0;
                foreach (var id in idRoomList)
                {
                    cb_Relation.Items.Add(id);
                }
                cb_Relation.SelectedIndex = 0;
            }
            catch (ArgumentOutOfRangeException)
            {
                string text = "Вы больше не можете создавать двери. Удалите любую дверь и повторите попытку.";
                string title = "Привышен лимит дверей";
                MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _iserror = true;
            }
        }
        public Colors GetColor()
        {
            return _color;
        }
        public int GetRelation()
        {
            return _relation;
        }
        public Direction GetPosition()
        {
            return _position;
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            _color = (Colors)cb_Color.SelectedItem;
            _relation = (int)cb_Relation.SelectedItem;
            _position = (Direction)cb_Position.SelectedItem;
        }

        private void DoorForm_Load(object sender, EventArgs e)
        {
            if (_iserror)
                this.DialogResult = DialogResult.Cancel;
        }
    }
}
