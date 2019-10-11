using System;
using System.Data; // require for dataset

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DataSet dsCollege = new DataSet("CollegeDS");

            // Declare and create an object of type DataSet and name the object as CollegeDS.
            // Display the name of the DataSet object on the screen.

            Console.WriteLine("The name of the DataSet object : {0}\n", dsCollege.DataSetName);

            DataTable dtStudents = new DataTable("Students");
            DataTable dtCourses = new DataTable("Courses");
            DataTable dtStudentCourses = new DataTable("StudentCourses");

            // Add the three DataTable objects(Question 3) to the DataSet object

            dsCollege.Tables.Add("Students");
            dsCollege.Tables.Add("Courses");
            dsCollege.Tables.Add("StudentCourses");

            // Declare and create 3 DataTable objects and name the objects as Students, Courses,
            // and StudentCourses respectively.

            Console.WriteLine("The number of DataTable objects in the DataSet object : {0}\n", dsCollege.Tables.Count);

            Console.WriteLine("The names of the DataTable objects :\n{0}\n{1}\n{2}", dtStudents.TableName, dtCourses.TableName, dtStudentCourses.TableName);

            // Write a code segment to define DataColumn objects for the DataTable object Students 6
            // , name the DataColumn objects as StudentId, FirstName and LastName respectively
            // and specify the Data Type for each column.Set the DataColumn object StudentId as
            // primary key.

            Console.WriteLine("\n\nDataTable name : {0}", dtStudents.TableName);
            Console.WriteLine("DataColumn names and Data types : ");


            DataColumn dcStudentId = new DataColumn("StudentId", typeof(Int32));
            DataColumn dcFirstName = new DataColumn("FirstName", typeof(String));
            DataColumn dcLastName = new DataColumn("LastName", typeof(String));
            dtStudents.Columns.Add(dcStudentId);
            dtStudents.Columns.Add(dcFirstName);
            dtStudents.Columns.Add(dcLastName);
            dtStudents.PrimaryKey = new DataColumn[] { dcStudentId };


            dtStudents.Rows.Add(new Object[] { 1111111, "John", "Abbot" });
            dtStudents.Rows.Add(new Object[] { 2222222, "Mary", "Green" });
            dtStudents.Rows.Add(new Object[] { 3333333, "Thomas", "Moore" });

            foreach (DataColumn dc in dtStudents.Columns)
            {
                System.Console.WriteLine("{0} : {1}", dc.ColumnName, dc.DataType);
            }

            System.Console.WriteLine("\nTable Students :");

            foreach (DataRow dataRow in dtStudents.Rows)
            {
                foreach (var item in dataRow.ItemArray)
                {
                    Console.Write(item + "\t");
                }
                Console.WriteLine();
            }

            // course table

            Console.WriteLine("\n\n\nDataTable name : {0}", dtCourses.TableName);
            Console.WriteLine("DataColumn names and Data types : ");

            DataColumn dcCourseCode = new DataColumn("CourseCode", typeof(String));
            DataColumn dcCourseTitle = new DataColumn("CourseTitle", typeof(String));
            DataColumn dcTotalHours = new DataColumn("TotalHours", typeof(Int32));

            dtCourses.Columns.Add(dcCourseCode);
            dtCourses.Columns.Add(dcCourseTitle);
            dtCourses.Columns.Add(dcTotalHours);
            dtCourses.PrimaryKey = new DataColumn[] { dcCourseCode };


            dtCourses.Rows.Add(new Object[] { "420 - P16 - AS", "Structured Programming", 90 });
            dtCourses.Rows.Add(new Object[] { "420 - P25 - AS", "Introduction to Object Programing", 75 });
            dtCourses.Rows.Add(new Object[] { "420 - P34 - AS", "Advanced Object Programming", 60 });
            dtCourses.Rows.Add(new Object[] { "420 - P46 - AS", "Event Programming", 90 });
            dtCourses.Rows.Add(new Object[] { "420 - P55 - AS", "Internet Programming I", 75 });


            foreach (DataColumn dc in dtCourses.Columns)
            {
                System.Console.WriteLine("{0} : {1}", dc.ColumnName, dc.DataType);
            }

            System.Console.WriteLine("\nTable Courses : ");

            foreach (DataRow dataRow in dtCourses.Rows)
            {
                foreach (var item in dataRow.ItemArray)
                {
                    Console.Write(item + "\t");
                }
                Console.WriteLine();
            }


            // table student courses

            Console.WriteLine("\n\n\nDataTable name : ");
            Console.WriteLine("DataColumn name and Data type : ");


            DataColumn dcStudentIdSC = new DataColumn("StudentId", typeof(Int32));
            DataColumn dcCourseCodeSC = new DataColumn("CourseCode", typeof(String));

            dtStudentCourses.Columns.Add(dcStudentIdSC);
            dtStudentCourses.Columns.Add(dcCourseCodeSC);
            dtStudentCourses.PrimaryKey = new DataColumn[] { dcStudentIdSC, dcCourseCodeSC };

            dtStudentCourses.Rows.Add(new Object[] { 1111111, "420 - P16 - AS" });
            dtStudentCourses.Rows.Add(new Object[] { 2222222, "420 - P16 - AS" });
            dtStudentCourses.Rows.Add(new Object[] { 1111111, "420 - P25 - AS" });
            dtStudentCourses.Rows.Add(new Object[] { 2222222, "420 - P25 - AS" });
            dtStudentCourses.Rows.Add(new Object[] { 3333333, "420 - P34 - AS" });
            dtStudentCourses.Rows.Add(new Object[] { 3333333, "420 - P55 - AS" });

            ForeignKeyConstraint fk1 = new ForeignKeyConstraint(dtStudents.Columns["StudentId"], dtStudentCourses.Columns["StudentId"]);
            ForeignKeyConstraint fk2 = new ForeignKeyConstraint(dtCourses.Columns["CourseCode"], dtStudentCourses.Columns["CourseCode"]);

            fk1.DeleteRule = Rule.None;
            fk1.UpdateRule = Rule.Cascade;
            fk1.AcceptRejectRule = AcceptRejectRule.Cascade;

            dtStudentCourses.Constraints.Add(fk1);
            dtStudentCourses.Constraints.Add(fk2);


            foreach (DataColumn dc in dtStudentCourses.Columns)
            {
                System.Console.WriteLine("{0} : {1}", dc.ColumnName, dc.DataType);
            }

            System.Console.WriteLine("\nTable Courses : ");

            foreach (DataRow dataRow in dtStudentCourses.Rows)
            {
                foreach (var item in dataRow.ItemArray)
                {
                    Console.Write(item + "\t");
                }
                Console.WriteLine();
            }

            // Write a code segment to display all the courses registered by a given student.
            // For example: List all the courses for the student John Abbot.

            System.Console.WriteLine("\n\nCourse of StudentId 1111111");

            foreach (DataRow drSC in dtStudentCourses.Rows)
            {
                if (Convert.ToInt32(drSC["StudentId"]) == 1111111)
                {
                    foreach (DataRow drC in dtCourses.Rows)
                    {
                        if (drSC["CourseCode"] == drC["CourseCode"])
                        {
                            System.Console.WriteLine("{0} {1}", drC["CourseCode"], drC["CourseTitle"]);
                        }
                    }
                }

            }

        }
    }
}
