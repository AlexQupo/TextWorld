using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextWorld.Play
{
    public partial class SelectionWorld : Form
    {
        Main main;
        bool toMain = true;
        public SelectionWorld(Main main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void SelectionWorld_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(toMain)
                main.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Game gm = new Game();
            gm.Show();
            toMain = false;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
