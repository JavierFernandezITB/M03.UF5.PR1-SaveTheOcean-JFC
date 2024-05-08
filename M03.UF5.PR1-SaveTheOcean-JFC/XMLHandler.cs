using M03.UF5.PR1_SaveTheOcean_JFC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace M03.UF5.PR1_SaveTheOcean_JFC
{
    public class XMLHandler
    {
        public static void CreateXML(string path)
        {
            if (!File.Exists(path))
            {
                XmlDocument xmlDoc = new XmlDocument();
                XmlElement root = xmlDoc.CreateElement("PlayerData");
                xmlDoc.AppendChild(root);
                xmlDoc.Save(path);
            }
        }

        public static Player CreateUser(string path, Player plr)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(path);
            XmlNode playerDataNode = xmlDoc.DocumentElement;

            XmlNode existingPlayerNode = playerDataNode.SelectSingleNode(plr.Name);
            if (existingPlayerNode == null)
            {
                XmlElement newPlayerNode = xmlDoc.CreateElement(plr.Name);
                XmlElement xmlJobElement = xmlDoc.CreateElement("Job");
                xmlJobElement.InnerText = plr.Job;
                newPlayerNode.AppendChild(xmlJobElement);

                XmlElement xmlXpElement = xmlDoc.CreateElement("XP");
                xmlXpElement.InnerText = plr.Xp.ToString();
                newPlayerNode.AppendChild(xmlXpElement);

                playerDataNode.AppendChild(newPlayerNode);

                xmlDoc.Save(path);
            } else
            {
                plr.Xp = int.Parse(existingPlayerNode.SelectSingleNode("XP").InnerText);
            }

            return plr;
        }
        public static void ChangeXP(string path, string playerName, int newXP)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(path);
            XmlNode playerDataNode = xmlDoc.DocumentElement;
            XmlNode playerNode = playerDataNode.SelectSingleNode(playerName);
            XmlNode xpNode = playerNode.SelectSingleNode("XP");
            xpNode.InnerText = newXP.ToString();
            xmlDoc.Save(path);
        }
    }
}
