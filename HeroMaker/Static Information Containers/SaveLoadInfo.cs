using System.IO;
using System.Windows.Forms;
using DnD.Classes.Player;
using Newtonsoft.Json;

namespace HeroMaker.Static_Information_Containers
{
    /// <summary>
    /// We have the ability to now Serialize and Deserialize (save/load) and with the use of Json properties
    /// we can customize what gets saved to the file and is readable! wow!
    /// </summary>
    public static class SaveLoadInfo
    {
        private static string _fileName;

        public static void Serialize(Hero theDude)
        {
            FolderBrowserDialog dialogue = new FolderBrowserDialog();
            dialogue.ShowDialog();
            _fileName = dialogue.SelectedPath + "\\" + theDude.Name + ".txt";

            
            string json = JsonConvert.SerializeObject(theDude, Formatting.Indented);
            using (StreamWriter steamy = File.AppendText(_fileName))
            {
                steamy.WriteLine(json);
            }
        }
    }
}
