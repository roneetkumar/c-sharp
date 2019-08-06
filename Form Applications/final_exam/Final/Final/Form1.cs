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

/*
        Name: Roneet Kumar
        Date: 06/08/2019
        Final Exam
        This application allows the teacher to enter student information, validate the input data and save the valid data to a text file.
*/


namespace Final
{
    public partial class Form1 : Form
    {

        Grade gradeObj = new Grade();
        string dir = @"C:/Summer19/";
        DateTime dateObj = DateTime.Today;
        string stuName, courseNo, year;

        public Form1() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);

            this.Text =  "Roneet Kumar - 20181927 - " + dateObj.Date.ToString("dd/MM/yyyy");
        }

        class Grade
        {
            private double midTerm, final, project, total;

            public double MidTerm { get => midTerm; set => midTerm = value; }
            public double Final { get => final; set => final = value; }
            public double Project { get => project; set => project = value; }
            public double Total { get => total; set => total = value; }

            public double calculateTotalMarks() => MidTerm + Final + Project;

            public double marksPercentage(double marks, double total) => (marks / 100 * total);

            public char alphaGrade(double totalPerc)
            {
                if (totalPerc >= 90 && totalPerc <= 100)
                {
                    return 'A';
                }
                else if (totalPerc >= 80 && totalPerc < 90)
                {
                    return 'B';
                }
                else if (totalPerc >= 70 && totalPerc < 80)
                {
                    return 'C';
                }
                else if (totalPerc >= 60 && totalPerc < 70)
                {
                    return 'D';
                }
                else
                {
                    return 'F';
                }
            }
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            if (Convert.ToByte(MessageBox.Show("Do you want to quit ?", "Exit", MessageBoxButtons.YesNo)) == 6)
            {
                Application.Exit();
            }
        }

        private void Btn_calculateMarks_Click(object sender, EventArgs e)
        {
            stuName = txt_stuName.Text;
            courseNo = txt_courseNo.Text;
            year = txt_year.Text;

            Regex rgxStuName = new Regex(@"^[a-zA-Z\s]{4,30}$");
            Regex rgxCourseNo = new Regex(@"(420-P16-AS)|(420-DW1-AS)|(420-DW2-AS)");

            if (rgxStuName.IsMatch(stuName) && stuName != "Enter Your Name")
            {
                if (rgxCourseNo.IsMatch(courseNo))
                {
                    if (Convert.ToInt32(year) >= 2015 && Convert.ToInt32(year) <= dateObj.Year + 1)
                    {
                        gradeObj.MidTerm = Convert.ToDouble(txt_midTermMarks.Text);
                        gradeObj.Project = Convert.ToDouble(txt_projectMarks.Text);
                        gradeObj.Final = Convert.ToDouble(txt_finalMarks.Text);
                        double totalPercentage = (gradeObj.calculateTotalMarks() / 300 * 100);
                        txt_totalPercentage.Text = totalPercentage.ToString();
                        txt_midTermPercentage.Text = gradeObj.marksPercentage(gradeObj.MidTerm, 30).ToString();
                        txt_projectPercentage.Text = gradeObj.marksPercentage(gradeObj.Project, 30).ToString();
                        txt_finalPercentage.Text = gradeObj.marksPercentage(gradeObj.Final, 40).ToString();
                        txt_totalGrades.Text = gradeObj.alphaGrade(totalPercentage).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Enter a valid year!\nShould be between 2015 and 2020.");
                    }
                }
                else
                {
                    MessageBox.Show("Enter valid course number!\nlike 420-P16-AS, 420-DW1-AS or 420-DW2-AS");
                }
            }
            else
            {
                MessageBox.Show("Enter a valid name!\n4 up to 30 characters.");
            }
        }
       
        private void Btn_fileWrite_Click(object sender, EventArgs e)
        {
            FileStream file = new FileStream(dir + "Final.txt", FileMode.Append, FileAccess.Write);
            StreamWriter textOut = new StreamWriter(file);

            textOut.Write(stuName + "|");
            textOut.Write(courseNo + "|");
            textOut.Write(txt_session.SelectedItem + "|");
            textOut.Write(year + "|");
            textOut.Write(txt_midTermMarks.Text + "|");
            textOut.Write(txt_projectMarks.Text + "|");
            textOut.Write(txt_finalMarks.Text + "|");
            textOut.Write(txt_midTermPercentage.Text + "|");
            textOut.Write(txt_projectPercentage.Text + "|");
            textOut.Write(txt_finalPercentage.Text + "|");
            textOut.Write(txt_totalPercentage.Text + "|");
            textOut.WriteLine(txt_totalGrades.Text);
            textOut.Close();
        }

        private void Btn_xmlWrite_Click(object sender, EventArgs e)
        {
            FileStream xml = new FileStream(dir + "Final.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader textIn = new StreamReader(xml);

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true; settings.IndentChars = (" ");

            XmlWriter xmlOut = XmlWriter.Create(dir + "Final.xml", settings);

            xmlOut.WriteStartDocument();
            xmlOut.WriteStartElement("root");
            {
                while (textIn.Peek() != -1)
                {
                    string row = textIn.ReadLine();
                    string[] columns = row.Split('|');
                    xmlOut.WriteStartElement("grade");
                    xmlOut.WriteElementString("studentName", columns[0]);
                    xmlOut.WriteElementString("courseNumber", columns[1]);
                    xmlOut.WriteElementString("session", columns[2]);
                    xmlOut.WriteElementString("year", columns[3]);
                    xmlOut.WriteElementString("midTermMarks", columns[4]);
                    xmlOut.WriteElementString("projectMarks", columns[5]);
                    xmlOut.WriteElementString("finalMarks", columns[6]);
                    xmlOut.WriteElementString("midTermPercentage", columns[7]);
                    xmlOut.WriteElementString("projectPercentage", columns[8]);
                    xmlOut.WriteElementString("finalPercentage", columns[9]);
                    xmlOut.WriteElementString("totalPercentage", columns[10]);
                    xmlOut.WriteElementString("finalGrade", columns[11]);

                    xmlOut.WriteEndElement();
                }
            }
            xmlOut.WriteEndElement();
            xmlOut.Close();
            textIn.Close();
        }

        private void Btn_xmlRead_Click(object sender, EventArgs e)
        {
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;
            settings.IgnoreComments = true;
            XmlReader xmlIn = XmlReader.Create(dir + "Final.xml", settings);
            string Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8, Value9, Value10, Value11, Value12, tempStr;
            Value1 = Value2 = Value3 = Value4 = Value5 = Value6 = Value7 = Value8 = Value9 = Value10 = Value11 = Value12 = tempStr = "";
            if (xmlIn.ReadToDescendant("grade"))
            {
                do
                {
                    xmlIn.ReadStartElement("grade");
                    Value1 = xmlIn.ReadElementContentAsString();
                    Value2 = xmlIn.ReadElementContentAsString();
                    Value3 = xmlIn.ReadElementContentAsString();
                    Value4 = xmlIn.ReadElementContentAsString();
                    Value5 = xmlIn.ReadElementContentAsString();
                    Value6 = xmlIn.ReadElementContentAsString();
                    Value7 = xmlIn.ReadElementContentAsString();
                    Value8 = xmlIn.ReadElementContentAsString();
                    Value9 = xmlIn.ReadElementContentAsString();
                    Value10 = xmlIn.ReadElementContentAsString();
                    Value11 = xmlIn.ReadElementContentAsString();
                    Value12 = xmlIn.ReadElementContentAsString();
                    tempStr += "Student Name: " + Value1 + "\nCourse Number: " + Value2 + "\nSession: " + Value3 + "\nYear: " + Value4 + "\nMid Term Marks: " + Value5 + "\nProject Marks: " + Value6 + "\nFinal Marks: " + Value7 + "\nMid Term Percentage: " + Value8 + "\nProject Percentage: " + Value9 + "\nFinal Percentage: " + Value10 + "\nTotal Percentage: " + Value11 + "\nTotal Grade: " + Value12 + "\r\n\n";
                } while (xmlIn.ReadToNextSibling("grade"));
            }
            MessageBox.Show(tempStr);
            xmlIn.Close();
        }
    }
}
