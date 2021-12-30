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
    public partial class ObjectForm : Form
    {
        Names _name;
        Colors _color;
        Colors _kColor;
        bool _iserror = false;
        public ObjectForm(ComboBox.ObjectCollection availableNames)
        {
            InitializeComponent();
            lb_KColor.Visible = false;
            cb_KColor.Visible = false;
            try
            {
                var NamesList = Enum.GetValues(typeof(Names)).Cast<Names>();
                foreach (var name in NamesList)
                {
                    if (!availableNames.Contains(name))
                        cb_Object.Items.Add(name);
                }
                cb_Object.SelectedIndex = 0;
                var ColorsList = Enum.GetValues(typeof(Colors)).Cast<Colors>();
                foreach (var color in ColorsList)
                {
                    cb_Color.Items.Add(color);
                    if (color != Colors.White)
                    {
                        cb_KColor.Items.Add(color);
                    }
                }
                cb_Color.SelectedIndex = 0;
                cb_KColor.SelectedIndex = 0;
            }
            catch (ArgumentOutOfRangeException)
            {
                string text = "Вы больше не можете создавать объекты. Удалите любой объект и повторите попытку.";
                string title = "Привышен лимит объектов";
                MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _iserror = true;
            }
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
            return _kColor;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            
            if (chb_IsHaveKey.Checked)
            {
                _name = (Names)cb_Object.SelectedItem;
                _color = (Colors)cb_Color.SelectedItem;
                _kColor = (Colors)cb_KColor.SelectedItem;
            }
            else
            {
                _name = (Names)cb_Object.SelectedItem;
                _color = (Colors)cb_Color.SelectedItem;
                _kColor = Colors.White;
            }
        }

        private void chb_IsHaveKey_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_IsHaveKey.Checked)
            {
                lb_KColor.Visible = true;
                cb_KColor.Visible = true;
            }
            else
            {
                lb_KColor.Visible = false;
                cb_KColor.Visible = false;
            }
        }

        private void ObjectForm_Load(object sender, EventArgs e)
        {
            if (_iserror)
                this.DialogResult = DialogResult.Cancel;
        }
    }
}
