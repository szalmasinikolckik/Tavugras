using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Tavugras_FanniNikol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private List<Student> allStudents = new List<Student>();

        private void LoadData(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                allStudents.Clear();
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] parts = line.Split(';');
                    if (parts.Length >= 3)
                    {
                        string name = parts[0];
                        string city = parts[1];
                        string results = parts[2] + " " + parts[3] + " " + parts[4] + " " + parts[5] + " "  + parts[6] + " ";
                        Student student = new Student(name, city, results);
                        allStudents.Add(student);
                    }
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string name = nameBox.Text;
            string city = cityBox.Text;
            string result = resultBox.Text;
            Student student = new Student(name, city, result);
            allStudents.Add(student);      
            RefreshList(cityFilter.Text);
            nameBox.Clear();
            cityBox.Clear();
            resultBox.Clear();

        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var student = listBox.SelectedItem as Student;
            if (student != null)
            {
                nameBox.Text = student.name;
                cityBox.Text = student.city;
                resultBox.Text = student.result;
            }
        }

        private void cityFilter_TextChanged(object sender, EventArgs e)
        {
            RefreshList(cityFilter.Text);
        }

        private void RefreshList(string text)
        {
            listBox.Items.Clear();
            var filtered = allStudents.Where(s => s.city.ToLower().Contains(text.ToLower()));
            foreach (var student in filtered)
            {
                listBox.Items.Add(student);
            }

        }

        private void winnerCount_ValueChanged(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            var filtered = allStudents.Take((int)winnerCount.Value);
            foreach (var student in filtered)
            {
                listBox.Items.Add(student);
            }
            winnerCount.Maximum = allStudents.Count;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (ofd.ShowDialog() != DialogResult.OK)
            {
               return;
            }
            LoadData(ofd.FileName);
            RefreshList(cityFilter.Text);
        }

    }
}
