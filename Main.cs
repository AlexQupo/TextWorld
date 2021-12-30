using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextWorld
{
    public partial class Main : Form
    {
        GameManager _gm;
        Play.SelectionWorld _swF;
        Editor.WorldsForm _wdsF;
        public Main()
        {
            InitializeComponent();
            _gm = new GameManager();
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Play_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данная часть программы в разработке.", "Недоступно", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //_swF = new Play.SelectionWorld(this);
            //_swF.Show();
            //this.Hide();
        }

        private void Editor_Click(object sender, EventArgs e)
        {
            _wdsF = new Editor.WorldsForm(this, _gm.Maze);
            _wdsF.Show();
            this.Hide();
        }
    }
}
