using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

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
            UpdateComboBox(this);
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
            UpdateComboBox(this);
        }

        private void carBox_SelectedValueChanged(object sender, EventArgs e)
        {
            var rnd = new Random();
            _currentCar = $"{AssettoCorsaFolderPath}\\content\\cars\\{carBox.SelectedItem}";
            var folders =
                Directory.GetDirectories($"{_currentCar}\\skins\\");
            picbox_car.ImageLocation = $@"{folders[rnd.Next(folders.Length)]}\\preview.jpg";
        }

        private static void UpdateComboBox(Form1 f)
        {
            if (f.AssettoCorsaFolderPath == "") return;
            var folders = Directory.GetDirectories($"{f.AssettoCorsaFolderPath}\\content\\cars\\");
            foreach (var directory in folders)
            {
                var dir = new DirectoryInfo(directory);
                var dirName = dir.Name;
                f.carBox.Items.Add(dirName);
            }
        }

        private void TuneThisBtn_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists($"{_currentCar}/data") && File.Exists($"{_currentCar}/data.acd"))
            {
                Directory.CreateDirectory($"{_currentCar}/data");

                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = $"\"{Directory.GetCurrentDirectory()}\\utils\\quickbms\\quickbms.exe\"";

                psi.Arguments = string.Join(" ", ".\\utils\\quickbms\\ACExtract.bms", " ", $"{_currentCar}\\data.acd",
                    " ", $"{_currentCar}\\data\\");
                psi.UseShellExecute = false;
                psi.CreateNoWindow = true;
                psi.WindowStyle = ProcessWindowStyle.Hidden;

                var proc = new Process();
                proc.StartInfo = psi;
                proc.Start();
                proc.WaitForExit();
                File.Move($"{_currentCar}\\data.acd", $"{_currentCar}\\data_back_up.acd");
            }
        }

        private void CreateChildBtn_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}