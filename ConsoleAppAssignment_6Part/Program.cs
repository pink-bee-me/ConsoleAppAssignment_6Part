using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment_6Part
{
    class Program
    {
        static void Main(string[] args)
        {
            string tabulatorEdition = " This is the Educator Edition version 1.7 of The Information Tabulator ";
            string studentRegister = " The Student Log / Register ";
            string classInfo = " Class Info.: ";
            string avgHomeworkScoresModule = " The Average Daily Scores Module ";
            string avgQuizScoresModule = " The Average Quiz Scores Module ";
            string avgExamScoresModule = " The Average Exam Scores Module ";
            string gpaTracker = " Student GPA Tracker ";
            string runningSumFunction = " The Running Sum Function ";

            Console.WriteLine("\n\n\n\n\n\t\t\t\t\t\t\t\t The Information Tabulator" +
                "\n\n\t\t\t\t\t ... making all of your basic information compilation needs a breeze." +
                " \n\n\n\n\n Welcome! Please, introduce yourself (enter your name): ");
            string userName = Console.ReadLine();
            Console.WriteLine("\n\n" + tabulatorEdition);
            Console.WriteLine("\n\n Hello " + userName + " ! Let's get started !\n\n");
            Console.WriteLine("Enter Class Info (e.g., English_01; i.e., English, class period #1):");
            string classInfoInput = Console.ReadLine();
            Console.WriteLine("\n\n Step 1 - Entering STudents Into Student Log / Register" +
                "\n\n\n Suggestion: Consider Including Student's Middle Name or Initial to prevent issues (i.e., duplicate student entry, clarification in \"same name\" instances." +
                "\n NOTE: An area for additional input will be available in a different section of the module to further address these concerns." +
                "\n The following unique identifers (e.g., student SS#, Student Id, seating chart notation, etc.) are INCLUDED in a different section and NOT to be entered at this point.");

            List<string> preCheckForDupleStews = new List<String>( );
            List<string> registeredStews = new List<string>();

            while (true)
            {
                Console.WriteLine("\n\n Enter Student Name ( Fist Middle Last): ");
                string studentRegInput = Console.ReadLine();

                if (studentRegInput == "")
                {
                    break;
                }
                bool addNewStudent = Convert.ToInt32(studentRegInput.Length) < 4;

                if (addNewStudent) {

                    Console.WriteLine("Check format. Re-Enter Student Name: ");
                    Console.ReadLine();
                }
                else
                {
                 foreach (string student in registeredStews)
                    
                    {if registeredStews.Contains(addNewStudent))
                        {

                        }
                        preCheckForDupleStews.Add(studentRegInput);
                        bool dupleStew = registeredStews.Contains(string students in preCheckForDupleStews);// if false Add to the List registeredStews
              
                    if (dupleStew == true)
                {
                    Console.WriteLine("Check Entry: " + studentRegInput + "" +
                        "\n\n Possible Duplicate. Student already exists in Student Log/Register.");
                    Console.ReadLine();
                }
                else
                {
                    registeredStews.Add(studentRegInput);
                    Console.WriteLine("Successful Entry: " + studentRegInput);
                    Console.ReadLine();
                }
            }
    

                foreach (string student in registeredStews)
                {
                    Console.WriteLine( "\n\n "+ studentRegister + "\n\n " + registeredStews);

                }

                Console.ReadLine();


            }
        } }

