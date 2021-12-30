using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextWorld.Editor
{
    public partial class WorldsForm : Form
    {
        Main _main;
        Maze _maze;
        MazeForm _mF;
        UniversalSaveClass _usc;
        bool toMain = true;

        public WorldsForm(Main mainF, Maze maze)
        {
            InitializeComponent();
            _usc = new UniversalSaveClass();
            _main = mainF;
            _maze = maze;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            toMain = true;
            this.Close();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            MazeInfoForm mif = new MazeInfoForm();
            if (mif.ShowDialog() == DialogResult.OK)
            {
                _maze = new Maze();
                _maze.Create(mif.GetName(), mif.GetLength());
                _mF = new MazeForm(this, ref _maze);
                if (_mF.ShowDialog() == DialogResult.OK)
                {
                    _usc.SaveMaze(_maze.GetName(), ref _maze);
                }
            }
            toMain = false;
        }

        private void Edit_Click(object sender, EventArgs e)
        {

            if (listOfWorlds.SelectedIndex == -1) MessageBox.Show("Вы не выбрали мир", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                _usc.LoadMaze(listOfWorlds.SelectedItem.ToString(), ref _maze);
                _mF = new MazeForm(this, ref _maze);
                if (_mF.ShowDialog() == DialogResult.OK)
                {
                    _usc.SaveMaze(_maze.GetName(), ref _maze);
                }
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            _usc.DeleteMaze(listOfWorlds.SelectedItem.ToString());
            _maze = new Maze();
            LoadNamesFromMemory();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            LoadNamesFromMemory();
        }

        private void WorldsForm_FormClosed(object sender, FormClosedEventArgs e)
        {

            _main.Show();
        }

        private void WorldsForm_Load(object sender, EventArgs e)
        {
            LoadNamesFromMemory();
        }

        void LoadNamesFromMemory()
        {
            listOfWorlds.Items.Clear();
            List<string> names = new List<string>();
            names = _usc.GetNames();
            foreach (var name in names)
                listOfWorlds.Items.Add(name);
        }
    }
}
