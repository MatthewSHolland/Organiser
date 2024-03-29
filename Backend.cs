﻿
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace Organiser
{
    public class Backend
    {
        public static List<Categories> lsCategories = new List<Categories>();
        public static List<JobType> lsJobTypes = new List<JobType>();
        public static List<Job> lsJobs = new List<Job>();
        public static List<Project> lsPros = new List<Project>();

        public static String sFilePath = "%userprofile%\\Documents";
        public static String sSystemPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        public static String sSystemFolder = Path.Combine(sSystemPath, "OrganiserSystem");
        public static String sFileName = "Project";
        public static Boolean bFileLoaded = false;

        public static int ID;
        public static int NextCateID()
        {
            int high = 1;
            if (lsCategories.Any())
            {
                foreach(Categories c in lsCategories)
                {
                    if(c.getCategoryID() > high) { high = c.getCategoryID(); }
                }
                return high + 1;
            }
            return high;
        }

        public static int getTypeID()
        {
            if (lsJobTypes.Count > 0)
            {
                ID = lsJobTypes[lsJobTypes.Count - 1].getJobTypeID() + 1;
            }
            return ID;
        }
        public static int getJobID()
        {
            if (lsJobs.Count > 0)
            {
                ID = lsJobs[lsJobs.Count - 1].getJobID() + 1;
            }
            return ID;
        }
        public static void ClearLists()
        {
            lsCategories.Clear();
            lsJobTypes.Clear();
            lsJobs.Clear();
        }
        public static Categories findCate(int ID)
        {
            foreach(Categories c in lsCategories)
            {
                if(ID == c.getCategoryID())
                {
                    return c;
                }
            }
            return null;
        }
        public static JobType findJobType(int ID)
        {
            foreach (JobType j in lsJobTypes)
            {
                if (ID == j.getJobTypeID())
                {
                    return j;
                }
            }
            return null;
        }
        public static int NextJobTypeID()
        {
            int high = 1;
            if(lsJobTypes.Any())
            {
                foreach(JobType j in lsJobTypes)
                {
                    if (j.getJobTypeID() > high) { high = j.getJobTypeID(); };
                }
                return high + 1;
            }
            return high;
        }
        public static Project findProject(String Name)
        {
            foreach(Project p in lsPros)
            {
                if (p.getProName() == Name)
                {
                    return p;
                }
            }
            return null;
        }
        public static Job findJob(int ID)
        {
            foreach(Job j in lsJobs)
            {
                if(j.getJobID() == ID)
                {
                    return j;
                }
            }
            return null;
        }
        public static Project findPro(String ProName)
        {
            foreach(Project p in lsPros)
            {
                if(Path.Combine(p.getProDir(), p.getProName()) == ProName)
                {
                    return p;
                }
            }
            return null;
        }
        public static void Delete(Boolean fromDisk)
        {
            String fp = sFilePath + "\\" + sFileName;
            if(File.Exists(fp + ".xml") && fromDisk)
            {
                File.Delete(fp + ".xml");
            }

            lsPros.Remove(findPro(fp));
        }
        public static void Save()
        {
            if(sFileName != "" && sFilePath != "")
            {
               
                XmlWriter xmlWriter = XmlWriter.Create(sFilePath + "\\" + sFileName + ".xml");

                xmlWriter.WriteStartDocument();
                xmlWriter.WriteStartElement("Root");
                xmlWriter.WriteStartElement("Categories");
                foreach(Categories c in lsCategories)
                {
                    Console.WriteLine("Looking at: " + c.getCategoryName());
                    xmlWriter.WriteStartElement("Category");
                    xmlWriter.WriteAttributeString("ID", c.getCategoryID().ToString());
                    xmlWriter.WriteAttributeString("Name", c.getCategoryName());
                    xmlWriter.WriteAttributeString("Color", c.getColor().ToArgb().ToString());
                    xmlWriter.WriteEndElement();
                }
                xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("JobTypes");
                foreach (JobType j in lsJobTypes)
                {
                    xmlWriter.WriteStartElement("JobType");
                    xmlWriter.WriteAttributeString("ID", j.getJobTypeID().ToString());
                    xmlWriter.WriteAttributeString("Name", j.getJobTypeName().ToString());
                    xmlWriter.WriteAttributeString("Cate", j.getJobTypeCate().getCategoryID().ToString());
                    xmlWriter.WriteEndElement();
                }
                xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("Jobs");
                foreach (Job j in lsJobs)
                {
                    xmlWriter.WriteStartElement("Jobs");
                    xmlWriter.WriteAttributeString("ID", j.getJobID().ToString());
                    xmlWriter.WriteAttributeString("Name", j.getJobName());
                    xmlWriter.WriteAttributeString("Desc", j.getJobDesc());
                    xmlWriter.WriteAttributeString("JobType", j.GetJobType().getJobTypeID().ToString());
                    xmlWriter.WriteAttributeString("Attachment", j.getAttachment());
                    xmlWriter.WriteEndElement();
                }
                xmlWriter.WriteEndElement();

                xmlWriter.WriteEndDocument();
                xmlWriter.Close();
            }
            
        }
        public static void Load()
        {
            String fp = sFilePath + "\\" + sFileName + ".xml";
            Console.WriteLine("trying to load: " + fp);
            ClearLists();
            if (File.Exists(fp))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(fp);
                foreach (XmlNode node in doc.DocumentElement.ChildNodes)
                {
                    foreach (XmlElement ele in node)
                    {
                        if (ele.Name == "Category")
                        {
                            Categories Reb = new Categories(Int16.Parse(ele.Attributes["ID"].InnerText), 
                                                                        ele.Attributes["Name"].InnerText,
                                                                        Color.FromArgb(Int32.Parse(ele.Attributes["Color"].InnerText)));
                            lsCategories.Add(Reb);
                        }

                        if (ele.Name == "JobType")
                        {
                            JobType rebjt = new JobType(Int16.Parse(ele.Attributes["ID"].InnerText),
                                                                  ele.Attributes["Name"].InnerText,
                                                                  findCate(Int16.Parse(ele.Attributes["Cate"].InnerText)));
                            lsJobTypes.Add(rebjt);
                        }

                        if (ele.Name == "Jobs")
                        {
                            Job rebjb = new Job(Int32.Parse(ele.Attributes["ID"].InnerText),
                                                            ele.Attributes["Name"].InnerText,
                                                            ele.Attributes["Desc"].InnerText,
                                                            findJobType(Int16.Parse(ele.Attributes["JobType"].InnerText)),
                                                            ele.Attributes["Attachment"].InnerText);
                            lsJobs.Add(rebjb);
                        }
                    }
                }
                
                bFileLoaded = true;
            }  
        }
        public static void SaveSystemFiles()
        {
            if(!Directory.Exists(sSystemFolder)) {
                Directory.CreateDirectory(sSystemFolder);
            }
            XmlWriter xmlWriter = XmlWriter.Create(sSystemFolder + "\\Organiser.xml");
            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("Projects");
            foreach(Project p in lsPros)
            {
                xmlWriter.WriteStartElement("Project");
                xmlWriter.WriteAttributeString("Name", p.getProName());
                xmlWriter.WriteAttributeString("Dir", p.getProDir());
                xmlWriter.WriteEndElement();
            }
            xmlWriter.WriteEndDocument();
            xmlWriter.Close();
        }
        public static void ReadSystemFiles()
        {
            String fp = sSystemFolder + "\\Organiser.xml";
            if (File.Exists(fp))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(fp);

                foreach (XmlNode node in doc.DocumentElement.ChildNodes)
                {
                    Project p = new Project(node.Attributes["Name"].InnerText, node.Attributes["Dir"].InnerText);
                    lsPros.Add(p);
                }
            }
        }

        public static void CreateBackup()
        {

        }

        public static DataGridView SetDGV(DataGridView Cate, String Name, Color Background, Point loc, Size size)
        {
            Cate.Location = loc;
            Cate.Size = size;
            Cate.BackgroundColor = Background;
            Cate.Name = Name;
            Cate.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Cate.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            Cate.ReadOnly = true;
            Cate.Anchor = (AnchorStyles.Left | AnchorStyles.Right);
            return Cate;
        }

        public static DialogResult createDialog(String Message, String Type, MessageBoxButtons buts, MessageBoxIcon icon)
        {
            DialogResult res = MessageBox.Show(Message, Type, buts, icon);
            return res;
        }

    }
}
