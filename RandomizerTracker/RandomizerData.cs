using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static RandomizerTracker.XmlData;

namespace RandomizerTracker
{
    public static class RandomizerData
    {
        public static bool areaRandomizer;
        public static bool roomRandomizer;

        public static Dictionary<string, string> FoundItemsToLocations;
        public static Dictionary<string, string> FoundTransitions;
        public static List<string> randomizedItems;
        public static Dictionary<string, bool> randomizedPools;

        public static void GetRandomizerData()
        {
            FoundItemsToLocations = new Dictionary<string, string>();
            FoundTransitions = new Dictionary<string, string>();

            if (!File.Exists(Properties.Settings.Default.filepath))
            {
                System.Windows.Forms.MessageBox.Show("Error: No tracker log found at the specified filepath.");
                return;
            }

            string[] data = File.ReadAllLines(Properties.Settings.Default.filepath);
            if (data.FirstOrDefault(line => line.StartsWith("Mode")) is string mode)
            {
                areaRandomizer = mode.Contains("Area Randomizer");
                roomRandomizer = mode.Contains("Room Randomizer");
            }
            (string, string)[] pools =
            {
                ("Dreamer", "Dreamers: "),
                ("Skill", "Skills: "),
                ("Charm", "Charms: "),
                ("Key", "Keys: "),
                ("Mask", "Mask shards: "),
                ("Vessel", "Vessel fragments: "),
                ("Ore", "Pale ore: "),
                ("Notch", "Charm notches: "),
                ("Geo", "Geo chests: "),
                ("Egg", "Rancid eggs: "),
                ("Relic", "Relics: "),
                ("Map", "Maps: "),
                ("Stag", "Stags: "),
                ("Grub", "Grubs: "),
                ("Root", "Whispering roots: ")
            };
            randomizedPools = new Dictionary<string, bool>();
            foreach (var pair in pools)
            {
                if (data.FirstOrDefault(line => line.StartsWith(pair.Item2)) is string poolBool)
                {
                    randomizedPools[pair.Item1] = poolBool.Contains(true.ToString());
                }
                else randomizedPools[pair.Item1] = false;
            }
            randomizedItems = Items.Where(item => randomizedPools.ContainsKey(itemToPool[item]) && randomizedPools[itemToPool[item]]).ToList();

            foreach (string line in data)
            {
                if (line.StartsWith("ITEM"))
                {
                    string[] words = line.Split('{', '}');
                    FoundItemsToLocations[words[1]] = words[3];
                    //listBox1.Items.Add($"{words[1]}, {words[3]}");
                }
                if (line.StartsWith("TRANSITION"))
                {
                    string[] words = line.Split('{', '}');
                    FoundTransitions[words[1]] = words[3];
                    if (isOneWay.TryGetValue(words[1], out bool oneWay) && !oneWay)
                    {
                        FoundTransitions[words[3]] = words[1];
                    }
                }
            }
        }

        public static bool CheckLocationFound(string location)
        {
            return FoundItemsToLocations.ContainsValue(location);
        }
    }
}
