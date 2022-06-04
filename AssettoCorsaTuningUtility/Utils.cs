using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace AssettoCorsaTuningUtility
{
    public static class Utils
    {
        public static void UnpackCar(string carPath)
        {
            if (Directory.Exists($"{carPath}/data") || !File.Exists($"{carPath}/data.acd")) return;
            // Creating data directory for unpacked files.
            Directory.CreateDirectory($"{carPath}/data");

            var psi = new ProcessStartInfo
            {
                FileName = $"\"{Directory.GetCurrentDirectory()}\\utils\\quickbms\\quickbms.exe\"",
                Arguments = string.Join(" ", ".\\utils\\quickbms\\ACExtract.bms", " ", $"{carPath}\\data.acd",
                    " ", $"{carPath}\\data\\"),
                UseShellExecute = false,
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden
            };

            var proc = new Process();
            proc.StartInfo = psi;
            proc.Start();
            proc.WaitForExit();
            // Backup of the original "data.acd".
            File.Move($"{carPath}\\data.acd", $"{carPath}\\data_back_up.acd");
        }

        public static void CreateNewCar(string parentCar, string childCar)
        {
            Directory.CreateDirectory(childCar);
            //Now Create all of the directories
            foreach (var dirPath in Directory.GetDirectories(parentCar, "*", SearchOption.AllDirectories))
            {
                Directory.CreateDirectory(dirPath.Replace(parentCar, childCar));
            }

            //Copy all the files & Replaces any files with the same name
            foreach (var newPath in Directory.GetFiles(parentCar, "*.*", SearchOption.AllDirectories))
            {
                File.Copy(newPath, newPath.Replace(parentCar, childCar), true);
            }
        }

        public static void UpdateCarData()
        {
        }
    }
}