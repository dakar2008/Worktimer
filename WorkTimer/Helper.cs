using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WorkTimer.Models;
using System.Threading.Tasks;
using System.Xml;

namespace WorkTimer
{
    public class Helper
    {
        public static List<WorkTime> GetWorkTimes(string completexmlpath)
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(completexmlpath);
            XmlNodeList list = xdoc.GetElementsByTagName("WorkTime");
            List<WorkTime> worktimelist = new List<WorkTime>();
            for (int i = 0; i < list.Count; i++)
            {
                WorkTime thisworktime = new WorkTime();
                XmlElement main = (XmlElement)xdoc.GetElementsByTagName("WorkTime")[i];
                XmlElement worktitle = (XmlElement)xdoc.GetElementsByTagName("Title")[i];
                XmlElement worktime = (XmlElement)xdoc.GetElementsByTagName("Time")[i];
                thisworktime.ID = main.GetAttribute("ID");
                thisworktime.Title = worktitle.InnerText;
                thisworktime.Time = worktime.InnerText;
                worktimelist.Add(thisworktime);
            }
            return worktimelist;
        }
        public static void AddToDatabase(string completexmlpath, WorkTime model)
        {
            List<WorkTime> worktimelist = GetWorkTimes(completexmlpath);
            while(worktimelist.Any(m => m.ID == model.ID))
            {
                model.ID = Guid.NewGuid().ToString("N");
            }
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(completexmlpath);
            XmlElement main = xdoc.CreateElement("WorkTime");
            main.SetAttribute("ID", model.ID);
            XmlElement Title_element = xdoc.CreateElement("Title");
            XmlElement Time_element = xdoc.CreateElement("Time");
            XmlText Title_text = xdoc.CreateTextNode(model.Title);
            XmlText Time_text = xdoc.CreateTextNode(model.Time);
            Title_element.AppendChild(Title_text);
            Time_element.AppendChild(Time_text);
            main.AppendChild(Title_element);
            main.AppendChild(Time_element);
            xdoc.DocumentElement.AppendChild(main);
            xdoc.Save(completexmlpath);
        }
        public static void RemoveFromDatabase(string completexmlpath, string ID)
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(completexmlpath);
            XmlNodeList list = xdoc.GetElementsByTagName("WorkTime");
            for (int i = 0; i < list.Count; i++)
            {
                XmlElement main = (XmlElement)xdoc.GetElementsByTagName("WorkTime")[i];
                if(main.GetAttribute("ID") == ID)
                {
                    xdoc.DocumentElement.RemoveChild(main);
                }
            }
            xdoc.Save(completexmlpath);
        }
    }
}