using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Xml;

namespace final_exam
{
    public partial class Form1 : Form
    {
        string dir = @"..\..\..\Test\";
        string filePath = @"..\..\..\Test\TextFile.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            var nameValue = fullName.Text;
            var cityValue = city.Text;
            var ageValue = age.Text;


            if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);

            FileStream file = new FileStream(filePath, FileMode.Append, FileAccess.Write);
            StreamWriter textOut = new StreamWriter(file);

            Regex rgxName = new Regex(@"^[a-zA-Z]{2}([a-zA-Z\s]){0,48}$");
            Regex rgxCity = new Regex(@"(Montreal)|(Toronto)|(Ottawa)");
            Regex rgxAge = new Regex(@"^[0-9]{2}$");

            if (rgxName.IsMatch(nameValue))
            {
                

                if (rgxCity.IsMatch(cityValue))
                {
                    if (rgxAge.IsMatch(ageValue.ToString()) || Convert.ToInt32(ageValue) < 18 ||
                    Convert.ToInt32(ageValue) > 65)
                    {
                        textOut.Write(nameValue + "|");
                        textOut.Write(cityValue + "|");
                        textOut.WriteLine(ageValue);
                    }
                    else
                    {
                        MessageBox.Show("Enter 3: a valid number!\n Should be between 18 and 65.");
                    }
                }
                else
                {
                    MessageBox.Show("Enter 2: a valid City!\n Montreal, Ottawa or Toronto.");
                }
            }
            else
            {
                MessageBox.Show("Enter 1: a valid name!\n 2 up to 50 characters.");
            }

            textOut.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(dir) == false)
            {
                Directory.CreateDirectory(dir);
            }
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader textIn = new StreamReader(fs);

            // create the XmlWriterSettings object
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true; settings.IndentChars = (" ");

            int i = 0;
            XmlWriter xmlOut = XmlWriter.Create(dir + "XML.xml", settings);

            

            // create the XmlWriter object using settings object (indent)
            xmlOut.WriteStartDocument(); // write the start of the document
            xmlOut.WriteStartElement("Root"); //start root element

            {
                while (textIn.Peek() != -1)
                {
                    string row = textIn.ReadLine();
                    string[] columns = row.Split('|');
                    xmlOut.WriteStartElement("Child"); //content element
                    xmlOut.WriteElementString("FullName", columns[0]);//adding element tag 1 + value
                    xmlOut.WriteElementString("City", columns[1]);//adding element tag 2 + value
                    xmlOut.WriteElementString("Age", columns[2]);//adding element tag 2 + value
                    xmlOut.WriteEndElement();
                    i++;
                }
            }
       
            xmlOut.WriteEndElement(); // write the end tag for the root element
            xmlOut.Close();// close the XmlWriter object
            textIn.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;
            settings.IgnoreComments = true;
            XmlReader xmlIn = XmlReader.Create(dir + "XML.xml", settings);
            string Value1 = "", Value2 = "", Value3 = "", tempStr = "";
            if (xmlIn.ReadToDescendant("Child"))
            {
                do
                {
                    xmlIn.ReadStartElement("Child");
                    Value1 = xmlIn.ReadElementContentAsString(); //<FullName>
                    Value2 = xmlIn.ReadElementContentAsString(); //<City>
                    Value3 = xmlIn.ReadElementContentAsString(); //<Age>
                    tempStr += "Full Name: " + Value1 + "\nCity: " + Value2 + "\nAge: " + Value3 + "\r\n\n";
                } while (xmlIn.ReadToNextSibling("Child"));
            }
            MessageBox.Show(tempStr);
            xmlIn.Close();
        }
    }
}
