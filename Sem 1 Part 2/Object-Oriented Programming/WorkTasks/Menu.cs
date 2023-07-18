using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkTasks
{
    public partial class Menu : Form
    {
        Company company = new Company("Yanakiev Enterprise");
        public Menu()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON File|*.json";
            saveFileDialog.InitialDirectory = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "WorkTasks\\data"); 
            saveFileDialog.ShowDialog();
            string fileName = saveFileDialog.FileName;
            string jsonString = JsonSerializer.Serialize(company);
            File.WriteAllText(fileName, jsonString);
        }

        private void btnBrowseTasks_Click(object sender, EventArgs e)
        {
            BrowseTasks browseTasks = new BrowseTasks(company);
            browseTasks.Show();
        }

        private void btnCreateTask_Click(object sender, EventArgs e)
        {
            CreateNewTask createNewTask = new CreateNewTask(company);
            createNewTask.Show();
        }

        private void btnRemoveTask_Click(object sender, EventArgs e)
        {
            RemoveTask removeTask = new RemoveTask(company);
            removeTask.Show();
        }

        private void btnUpdateTask_Click(object sender, EventArgs e)
        {
            UpdateTask updateTask = new UpdateTask(company);
            updateTask.Show();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON File|*.json";
            openFileDialog.InitialDirectory = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "WorkTasks\\data"); 
            openFileDialog.ShowDialog();
            string fileName = openFileDialog.FileName;
            string json = File.ReadAllText(fileName);
            company = JsonSerializer.Deserialize<Company>(json);
        }

    }
}
