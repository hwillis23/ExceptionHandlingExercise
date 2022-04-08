using System;
using System.Collections.Generic;
using System.IO;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------------------------------------------------------
            // First create an char[], it must contain 6 numbers and 3 letters - name it arr -DONE 
            // Create a list called numbers that will hold integers -DONE
            // Create an string variable with an empty string initializer - name it str -DONE   

            // using a foreach loop, attempt to parse the elements in your char[] with int.Parse()
            // and Exceptions will be thrown 
            // Below we will set this up 
            // ------------------------------------------------------------------------------
            var arr = new char[] {'1','2','3','4','5','6','a','b','c'};
            var numbers = new List<int>();
            var str = ""; 

            foreach(var piece in arr)
            { 
                try
                {


                    str = piece.ToString();
                    var num = int.Parse(str);   //can only parse a string

                    numbers.Add(num);
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"Unable to parse: '{piece}'");
                }

            } 
            


            //TODO START HERE:

            // Make a foreach loop to iterate through your number array


                // Now create a try catch


                // Inside your try block
                // set your string variable to each array element in your char[] to .ToString()-DONE           //str = num.ToString();
                // Now, using int.Parse, parse your string variable and store in an int variable
                // Then add each int to your list    ///numbers.Add(num);

                // catch your Exception:
                // in the scope of your catch you can use the following, 

                //Console.WriteLine($"Unable to Parse '{character}'"); //character will be the name of each item in your collection -DONE



                //foreach (var num in numbers)
                //{
                //    Console.WriteLine(num);
                //}
        }
    }
}
