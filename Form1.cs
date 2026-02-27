using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;


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
            try
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
                            string results = "";
                            for (int i = 2; i < parts.Length; i++)
                            {
                                results += parts[i];
                                if (i < parts.Length - 1)
                                    results += " ";
                            }
                            Student student = new Student(name, city, results);
                            allStudents.Add(student);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
        }

        private void addButton_Click(object sender, EventArgs e)
        {
          
            string name = nameBox.Text;
            string city = cityBox.Text;
            string result = resultBox.Text;
            if (name == "" || city == "" || result == "")
            {
                MessageBox.Show("Írja be a hiányzó adatokat!");
                return;
            }
            Student student = new Student(name, city, result);
            allStudents.Add(student);
            RefreshList(cityFilter.Text);
            nameBox.Clear();
            cityBox.Clear();
            resultBox.Clear();

        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Student student = listBox.SelectedItem as Student;

            if (student == null)
                return;

            nameBox.Text = student.name;
            cityBox.Text = student.city;
            resultBox.Text = student.result;

            validJumpLabel.Text = "Érvényes ugrások száma: " + student.ValidJumpsCount();
            averageDistanceLabel.Text = "Átlagos távolság: " + student.AverageJump();
            largestDistanceLabel.Text = "Legnagyobb távolság: " + student.BestJump();
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

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb != null && rb.Checked)
            {
                IEnumerable<Student> sorted;

                if (largestDistanceRadio.Checked)
                    sorted = allStudents.OrderByDescending(s => s.BestJump());
                else
                    sorted = allStudents.OrderByDescending(s => s.AverageJump());

                listBox.Items.Clear();
                foreach (var student in sorted)
                {
                    listBox.Items.Add(student);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (sfd.ShowDialog() != DialogResult.OK) return;

            try
            {
                using (StreamWriter sw = new StreamWriter(sfd.FileName))
                {
                    foreach (var student in allStudents)
                    {
                        string line = student.name + ";" + student.city;

                        string[] jumps = student.result.Split(' ');

                        for (int i = 0; i < jumps.Length; i++)
                        {
                            line += ";" + jumps[i];
                        }

                        sw.WriteLine(line);
                    }
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
           

        }
    }
}