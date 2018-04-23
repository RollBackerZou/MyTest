using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using word = Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop;
using System.Runtime.InteropServices;
using System.Xml;


namespace Mail
{
    public partial class ExportWord : Form
    {
        public ExportWord()
        {
            InitializeComponent();
        }
        List<User> users = new List<User>();
       
        private void ExportWord_Load(object sender, EventArgs e)
        {
            //ExportToWord();
            List<User> users = new List<User>();
            XmlDocument doc = new XmlDocument();
            doc.Load("User.xml");
            XmlElement root = doc.DocumentElement;
           
            XmlNodeList childs = root.ChildNodes;
            foreach(XmlNode node in childs)
            {
                var x = node.ChildNodes;
                users.Add(new User() { 
                     Id = Convert.ToInt32(x[0].InnerText),
                     Number = x[1].InnerText,
                     Name = x[2].InnerText,
                });
            }

            this.dataGridView1.DataSource = users;
        }
        private void SaveXML()
        {
            users.Add(new User() { Id = 1, Number = "A1", Name = "AAAA" }
           );
            users.Add(new User() { Id = 2, Number = "B1", Name = "BBBB" });
            users.Add(new User() { Id = 3, Number = "C1", Name = "CCCC" });

            XmlDocument doc = new XmlDocument();
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);

            XmlElement ele = doc.CreateElement("Users");
            doc.AppendChild(ele);
            foreach (var user in users)
            {
                XmlElement usele = doc.CreateElement("User");
                ele.AppendChild(usele);

                XmlElement id = doc.CreateElement("Id");
                id.InnerXml = user.Id.ToString();
                XmlElement number = doc.CreateElement("Number");
                number.InnerXml = user.Number;
                XmlElement name = doc.CreateElement("Name");
                name.InnerXml = user.Name;

                usele.AppendChild(id);
                usele.AppendChild(number);
                usele.AppendChild(name);
            }

            doc.Save("User.xml");
        }
        public void ExportToWord()
        {
            word.Application newapp = new word.Application();
            word.Document newdoc;
            object nothing = System.Reflection.Missing.Value;
            newdoc = newapp.Documents.Add(ref nothing, ref nothing,ref nothing,ref nothing);
            newapp.Visible = true;
            var FileName = @"C:\test.doc";

            var wordTable = newdoc.Tables.Add(newdoc.Paragraphs.Last.Range,10,10,ref nothing);
            for (var i = 0; i < 10;i++)
            {
                wordTable.Cell(0, i + 1).Range.Text = i.ToString();
            }

            newdoc.SaveAsQuickStyleSet(FileName);
        }
    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
    }
}
