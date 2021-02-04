using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Xml;
using System.IO;
using System.Data;
using System.Collections;
using System.Resources;
using System.Windows.Media;

namespace RandomizerTracker
{
    public static class XmlData
    {
        public static List<string> Items;
        public static Dictionary<string, string> itemToArea;
        public static Dictionary<string, string> itemToRoom;
        public static Dictionary<string, string> itemToPool;
        public static Dictionary<string, bool> checkIfShopItem;

        public static List<string> areaTransitions;
        public static Dictionary<string, string> transitionToArea;
        public static HashSet<string> areas;

        public static List<string> roomTransitions;
        public static Dictionary<string, string> transitionToRoom;
        public static Dictionary<string, string> roomToArea;
        public static Dictionary<string, bool> isOneWay;
        public static HashSet<string> rooms;

        public static Dictionary<string, Color> AreaToColor;
        public static Dictionary<string, string> AltRoomNames;

        public static void ProcessXmls()
        {
            XmlDocument itemXml = LoadEmbeddedXml("RandomizerTracker.Resources.items.xml");
            Items = new List<string>();
            itemToArea = new Dictionary<string, string>();
            itemToRoom = new Dictionary<string, string>();
            itemToPool = new Dictionary<string, string>();
            checkIfShopItem = new Dictionary<string, bool>();
            foreach (XmlNode node in itemXml.SelectNodes("randomizer/item"))
            {
                Items.Add(node.Attributes?["name"].InnerText);
                itemToArea.Add(node.Attributes?["name"].InnerText, node["areaName"].InnerText);
                itemToRoom.Add(node.Attributes?["name"].InnerText, Translator.TranslateSceneName(node["sceneName"].InnerText));
                itemToPool.Add(node.Attributes?["name"].InnerText, node["pool"].InnerText);
                checkIfShopItem.Add(node.Attributes?["name"].InnerText, node["type"].InnerText == "Shop");
            }

            XmlDocument rocksXML = LoadEmbeddedXml("RandomizerTracker.Resources.rocks.xml");
            foreach (XmlNode node in rocksXML.SelectNodes("randomizer/item"))
            {
                Items.Add(node.Attributes?["name"].InnerText);
                itemToArea.Add(node.Attributes?["name"].InnerText, node["areaName"].InnerText);
                itemToRoom.Add(node.Attributes?["name"].InnerText, Translator.TranslateSceneName(node["sceneName"].InnerText));
                itemToPool.Add(node.Attributes?["name"].InnerText, node["pool"].InnerText);
                checkIfShopItem.Add(node.Attributes?["name"].InnerText, node["type"].InnerText == "Shop");
            }

            XmlDocument soulLoreXML = LoadEmbeddedXml("RandomizerTracker.Resources.soul_lore.xml");
            foreach (XmlNode node in soulLoreXML.SelectNodes("randomizer/item"))
            {
                Items.Add(node.Attributes?["name"].InnerText);
                itemToArea.Add(node.Attributes?["name"].InnerText, node["areaName"].InnerText);
                itemToRoom.Add(node.Attributes?["name"].InnerText, Translator.TranslateSceneName(node["sceneName"].InnerText));
                itemToPool.Add(node.Attributes?["name"].InnerText, node["pool"].InnerText);
                checkIfShopItem.Add(node.Attributes?["name"].InnerText, node["type"].InnerText == "Shop");
            }

            XmlDocument areaXml = LoadEmbeddedXml("RandomizerTracker.Resources.areas.xml");
            areaTransitions = new List<string>();
            transitionToArea = new Dictionary<string, string>();
            areas = new HashSet<string>();
            foreach (XmlNode node in areaXml.SelectNodes("randomizer/transition"))
            {
                areaTransitions.Add(node.Attributes?["name"].InnerText);
                transitionToArea.Add(node.Attributes?["name"].InnerText, node["areaName"].InnerText);
                areas.Add(node["areaName"].InnerText);
            }

            XmlDocument roomXml = LoadEmbeddedXml("RandomizerTracker.Resources.rooms.xml");
            roomTransitions = new List<string>();
            transitionToRoom = new Dictionary<string, string>();
            roomToArea = new Dictionary<string, string>();
            isOneWay = new Dictionary<string, bool>();
            rooms = new HashSet<string>();
            foreach (XmlNode node in roomXml.SelectNodes("randomizer/transition"))
            {
                roomTransitions.Add(Translator.TranslateTransitionName(node.Attributes?["name"].InnerText));
                transitionToRoom.Add(Translator.TranslateTransitionName(node.Attributes?["name"].InnerText), Translator.TranslateSceneName(node.Attributes?["name"].InnerText.Split('[')[0]));
                roomToArea[Translator.TranslateSceneName(node.Attributes?["name"].InnerText.Split('[')[0])] = node["areaName"].InnerText;
                isOneWay.Add(Translator.TranslateTransitionName(node.Attributes?["name"].InnerText), node?["oneWay"]?.InnerText?.Any(c => c == '1' || c == '2') == true);
                rooms.Add(Translator.TranslateSceneName(node.Attributes?["name"].InnerText.Split('[')[0]));
            }

            XmlDocument colorsXml = LoadFolderXml("colors.xml");
            AreaToColor = new Dictionary<string, Color>();
            foreach (XmlNode node in colorsXml.SelectNodes("randomizer/area"))
            {
                byte r = byte.Parse(node["r"].InnerText, System.Globalization.NumberStyles.HexNumber);
                byte g = byte.Parse(node["g"].InnerText, System.Globalization.NumberStyles.HexNumber);
                byte b = byte.Parse(node["b"].InnerText, System.Globalization.NumberStyles.HexNumber);
                AreaToColor.Add(node.Attributes["name"].InnerText, Color.FromRgb(r, g, b));
            }

            XmlDocument altroomsXml = LoadFolderXml("altroomnames.xml");
            AltRoomNames = new Dictionary<string, string>();
            foreach (XmlNode node in altroomsXml.SelectNodes("randomizer/room"))
            {
                AltRoomNames[node.Attributes["name"].InnerText] = node["altName"].InnerText;
            }
        }

        private static XmlDocument LoadEmbeddedXml(string filepath)
        {
            Stream stream = RandomizerTracker.instance.GetType().Assembly.GetManifestResourceStream(filepath);
            XmlDocument doc = new XmlDocument();
            doc.Load(stream);
            stream.Dispose();
            return doc;
        }

        private static XmlDocument LoadFolderXml(string name)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load($"Resources/{name}");
            return doc;
        }
    }
}
