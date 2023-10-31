using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }

            public static void runApp()
            {
            // Create arrays to store student names and their corresponding marks
            string[] studentNames = new string[5];
                studentNames[0]= "David";
                studentNames[1] = "Kathriene";
                studentNames[2] = "Charlie";
                studentNames[3] = "Tina";
                studentNames[4] = "Gracy";

            int[] studentMarks = new int[5];
            studentMarks[0]= 93;
            studentMarks[1] = 81;
            studentMarks[2] = 86;
            studentMarks[3] = 99;
            studentMarks[4] = 73;

                // Display the list of students and their marks
                Console.WriteLine("Student Names and Marks:");
            int i = 0;
            while(i < studentNames.Length) 
            { 
               
                    Console.WriteLine($"{studentNames[i]}: {studentMarks[i]}");
                i++;
                }
            }
        }

    }
