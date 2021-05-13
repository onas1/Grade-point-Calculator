using System;
using System.Collections.Generic;


namespace Grade_Point_Average_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Course_Model> Courses = new List<Course_Model>();

            double totalUnit = 0.0;
            double totalQualityPoints = 0.0;
            
            Console.Write("Hi, Welcome to GPA Calculator by Onas. Please enter your total course number :");
            try

            { int index = Convert.ToInt32(Console.ReadLine());

            
             for (int i = 0; i < index; i++)
                {
                    Course_Model course = new Course_Model(); //INSTANTIATING COURSE MODEL OBJECT
                    string course_Code;
                    int course_Score;
                    int course_Unit;

                    //COLLECTING USER INPUT
                    Console.Write("Enter Course Code: ");
                    course_Code = Console.ReadLine();
                    Console.Write("Enter Course Unit: ");
                    course_Unit = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Course Score: ");
                    course_Score = Convert.ToInt32(Console.ReadLine());

                    course.Code = course_Code;
                    course.Score = course_Score;
                    course.Unit = course_Unit;

                    // PUSHING course objects to Course
                    Courses.Add(course);

                }
            }
            catch (Exception)
            {

                Console.WriteLine(" For total No of Courses, Course Score and course unit, enter an integer While for Course Name and Code, enter a string:"); 
            }
            



            foreach (Course_Model course in Courses)
            {
                totalUnit += course.Unit;
                totalQualityPoints += course.Unit * course.Grade_unit(course.Grade(course.Score));
            }



            double getGPA = (double)totalQualityPoints / totalUnit;

            getGPA = Math.Round(getGPA, 2);

            

            Console.WriteLine("|-------------|-------------|----------|-----------|");
            Console.WriteLine("|COURSE & CODE| COURSE UNIT |GRADE     | GRADE UNIT| ");
            Console.WriteLine("|-------------|-------------|----------|-----------|");
            
        foreach (Course_Model course in Courses)
            {
          Console.WriteLine($"|{course.Code,-13}| {course.Unit, -12}| {course.Grade(course.Score), -9}|  {course.Grade_unit(course.Grade(course.Score)), -9}|");
            }
           Console.WriteLine("|-------------|-------------|----------|-----------|");
            Console.Write($"Your GPA is = {getGPA}");


        }


    }
}


          



        
              
        
            