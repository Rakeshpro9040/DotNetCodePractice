using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CSharpPractice
{
    class InnerException
    {
        public static void InnerExceptionMain()
        {
            try
            {
                try
                {
                    Console.WriteLine("Enter First Number");
                    int FN = Convert.ToInt32(Console.ReadLine());


                    Console.WriteLine("Enter Second Number");
                    int SN = Convert.ToInt32(Console.ReadLine());


                    int Result = FN / SN;
                    Console.WriteLine("Result = {0}", Result);
                }
                catch (Exception ex)
                {
                    string filePath = @"C:\Rakesh_C_Docs\Misc\CSharpDotNet\Sample Files\Log1.txt";
                    if (File.Exists(filePath))
                    {
                        StreamWriter sw = new StreamWriter(filePath);
                        sw.WriteLine($"Excpetion Nmae: {ex.GetType().Name}");
                        sw.WriteLine($"Error Message: {ex.Message}");
                        sw.WriteLine($"Error Stack: {ex.StackTrace}");
                        sw.Close();
                        Console.WriteLine("There is a problem! Plese try later");
                    }
                    else
                    {
                        //To retain the original exception pass it as a parameter
                        //to the constructor, of the current exception
                        throw new FileNotFoundException(filePath + " Does not Exist", ex);
                    }
                }
            }
            catch (Exception ex)
            {
                //ex.Message will give the current exception message
                Console.WriteLine($"Current or Outer Exception = {ex.Message}");


                //Check if inner exception is not null before accessing Message property
                //else, you may get Null Reference Excception
                if (ex.InnerException != null)
                {
                    Console.WriteLine($"Inner Exception = {ex.InnerException.Message}");
                }
            }
        }
    }
}
