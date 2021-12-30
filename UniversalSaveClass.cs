using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace TextWorld
{
    public class UniversalSaveClass
    {
        BinaryFormatter _formatter = new BinaryFormatter();
        string _path = string.Format("{0}{1}", AppDomain.CurrentDomain.BaseDirectory, @"Saves\Worlds\");

        public UniversalSaveClass()
        {
            Directory.CreateDirectory(_path);
        }

        public void SaveMaze(string fileName, ref Maze maze)
        {
            string worldName = maze.GetName();
            using (FileStream fs = new FileStream(_path + worldName + ".dat", FileMode.OpenOrCreate))
            {
                _formatter.Serialize(fs, maze);
            }
        }

        public void LoadMaze(string fileName, ref Maze maze)
        {
            using (FileStream fs = new FileStream(_path + fileName + ".dat", FileMode.OpenOrCreate)) 
            {
                Maze MazeFromMemory = (Maze)_formatter.Deserialize(fs);
                maze = MazeFromMemory;
            }
        }

        public List<string> GetNames()
        {
            var dir = new DirectoryInfo(_path);
            var files = new List<string>();
            foreach (FileInfo file in dir.GetFiles("*.dat"))
            {
                files.Add(Path.GetFileNameWithoutExtension(file.FullName)); 
            }
            return files;
        }

        public void DeleteMaze(string fileName)
        {
            File.Delete(_path + fileName + ".dat");
        }

    }
}
