using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System;

namespace DnD.Classes.Player
{
    /// <summary>
    /// We have the ability to now Serialize and Deserialize (save/load) and with the use of Json properties
    /// we can customize what gets saved to the file and is readable! wow!
    /// </summary>
    public static class SaveLoadInfo
    {
        private static string _fileName;

        /// <summary>
        /// A static function which will allow for saving the Hero entity to a file. The formatting will be JSON. with Indented tabletures.
        /// </summary>
        /// <param name="theDude">A reference to the Hero object being saved to file.</param>
        public static void Serialize(Hero theDude)
        {
            FolderBrowserDialog dialogue = new FolderBrowserDialog();
            dialogue.ShowDialog();
            _fileName = dialogue.SelectedPath + "\\" + theDude.Name + ".txt";

            // this settings object allows us to serialize case sensitive properties correctly so that deserialization can recognize the properties.
            var settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };
            string json = JsonConvert.SerializeObject(theDude, Formatting.Indented, settings);
            using (StreamWriter steamy = File.CreateText(_fileName))
            {
                steamy.WriteLine(json);
            }
        }

        /// <summary>
        /// A static function which will allow for loading the Hero entity from a file into memory. A special note, after calling for a hero deserialization
        /// it is important to call the <see cref="Hero.GetDeserializedHero(...)"/> function in order to properly populate special information containers.
        /// </summary>
        /// <param name="fileName">Which file stores the hero information we need.</param>
        /// <returns>A reference to an in memory <see cref="Hero"/> object.</returns>
        public static Hero Deserialize(string fileName)
        {
            Hero heroCereal = Hero.GetInitialHero();

            if (File.Exists(fileName))
            {
                try
                {
                    JObject o1 = JObject.Parse(File.ReadAllText(fileName));
                    heroCereal = o1.ToObject<Hero>();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            return heroCereal;
        }
    }
}
