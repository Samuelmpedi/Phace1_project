using System;
using System.IO;

namespace TeacherData
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Enter ID: ");
            //ENTER Input
            string T_IDNumber = Console.ReadLine();
            Console.WriteLine("Enter Name: ");
            //ENTER Input
            string T_Name = Console.ReadLine();
            Console.WriteLine("Enter Class and Section: ");
            //ENTER Input
            string T_Class = Console.ReadLine();


            string fileName = @"C:\Users\KABELO\Documents\LocalRepo\Phace1_project\Teacher.txt";

            try
            {

                // Check if file already exists. If yes, delete it.    
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }

                // Create a new file    
                using (StreamWriter fs = new StreamWriter(fileName)) 
                {
                    Console.WriteLine("\nThe following is information for teacher ID(" + T_IDNumber + ")");
                    // Add some text to file    
                    fs.WriteLine("The ID of the teacher is: " + T_IDNumber);
                    fs.WriteLine("The name of the teacher is: " + T_Name);
                    fs.WriteLine("The class and section of the teacher is: " + T_Class);                 
                }
                // Open the stream and read it back.    
                using (StreamReader sr = new StreamReader(fileName))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }



           
        }
    }
    
}
