using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;
using IniFile;

namespace AssettoCorsaTuningUtility
{
    public partial class Form1 : Form
    {
        private string _currentCar;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists("./config.conf")) return;
            var reader = new StreamReader("./config.conf");
            AssettoCorsaFolderPath = reader.ReadLine();
            label_path.Text = AssettoCorsaFolderPath;
            reader.Close();
            UpdateComboBox(this, carBox);
        }

        private void Set_Assetto_Corsa_Path(object sender, EventArgs e)
        {
            using var fbd = new FolderBrowserDialog();
            var result = fbd.ShowDialog();

            if (result != DialogResult.OK || string.IsNullOrWhiteSpace(fbd.SelectedPath)) return;
            label_path.Text = fbd.SelectedPath;
            AssettoCorsaFolderPath = fbd.SelectedPath;
            var writer = new StreamWriter("./config.conf");
            writer.WriteLine(fbd.SelectedPath);
            writer.Close();
            UpdateComboBox(this, carBox);
        }

        private void carBox_SelectedValueChanged(object sender, EventArgs e)
        {
            var rnd = new Random();
            _currentCar = $"{AssettoCorsaFolderPath}\\content\\cars\\{carBox.SelectedItem}";
            var folders =
                Directory.GetDirectories($"{_currentCar}\\skins\\");
            picbox_car.ImageLocation = $@"{folders[rnd.Next(folders.Length)]}\\preview.jpg";
        }

        private static void UpdateComboBox(Form1 f, ComboBox cb)
        {
            if (f.AssettoCorsaFolderPath == "") return;
            var folders = Directory.GetDirectories($"{f.AssettoCorsaFolderPath}\\content\\cars\\");
            foreach (var directory in folders)
            {
                var dir = new DirectoryInfo(directory);
                var dirName = dir.Name;
                cb.Items.Add(dirName);
            }
        }

        private void TuneThisBtn_Click(object sender, EventArgs e)
        {
            EnginePage.Enabled = true;
            EngineSwapPage.Enabled = true;
            DriveTrainPage.Enabled = true;
            Utils.UnpackCar(_currentCar);
            UpdateComboBox(this, CarBox2);
            using (var file = new StreamReader($"{_currentCar}/data/engine.ini"))
            {
                engineTextBox.ReadOnly = true;
                engineTextBox.Text = file.ReadToEnd();
            }
            using (var file = new StreamReader($"{_currentCar}/data/drivetrain.ini"))
            {
                drivetrainTextBox.ReadOnly = true;
                drivetrainTextBox.Text = file.ReadToEnd();
            }
        }


        private void CreateChildBtn_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void OnCarValueChange(object sender, EventArgs e)
        {
            label1.Text = e.ToString();
        }
    }
}