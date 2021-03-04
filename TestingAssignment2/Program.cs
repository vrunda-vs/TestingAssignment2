using System;

namespace TestingAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Harshil";
            string number = "15646";
            if (number.IsValidNumeric() == true)
                Console.WriteLine("\"" + number + "\" is not numaric value");
            else
                Console.WriteLine("\"" + number + "\" is not numaric value");
            Console.WriteLine("==================================================");
            if (num.ConvertStringToNumber() == null)
                Console.WriteLine("\"" + number + "\" can not convert in numeric type");
            else
                Console.WriteLine("\"" + number + "\" numeric value is : " + number.ConvertStringToNumber());
            Console.WriteLine("Input : \"" + input + "\" into Uppercase Letter : " + input.ConvertToUpper());
            input = "HARSHIL";
            Console.WriteLine("Input : \"" + input + "\" into Lowercase Letter : " + input.ConvertToLower());
            input = "harshil sheth";
            Console.WriteLine("Input : \"" + input + "\" into Titlecase Letter : " + input.ConvertToTitleCase());
            input = "harshil";
            Console.WriteLine("Check all the character of string is lower case or not : \"" + input + "\" : " + input.IsLower());
            input = "harshil sheth";
            Console.WriteLine("Input : \"" + input + "\" into Capitalize : " + input.ConvertToCapitalize());
            input = "HARSHIL";
            Console.WriteLine("Is input in uppercase : \"" + input + "\" : " + input.IsUpper());
            input = "harshil sheth";
            Console.WriteLine("No of words in the input : \"" + input + "\" : " + input.CountingWord());
            input = "Harshil Sheth";
            Console.WriteLine("Removing last character   : \"" + input + "\" : " + input.RemoveLastCharacterFrom());
            Console.WriteLine("==================================================");
        }
    }
}
