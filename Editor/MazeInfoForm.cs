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
    public partial class MazeInfoForm : Form
    {
        public string _name;
        public int _length;
        public MazeInfoForm()
        {
            InitializeComponent();
        }

        private void bt_Insert_Click(object sender, EventArgs e)
        {
            if (tb_Name.Text == string.Empty)
            {
                MessageBox.Show("Введите название", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.None;
            }
            else
            {
                _name = tb_Name.Text;
                _length = (int)nUD_Size.Value;
                this.DialogResult = DialogResult.OK;
            }
        }

        public string GetName()
        {
            return _name;
        }
        
        public int GetLength()
        {
            return _length;
        }
    }
}
