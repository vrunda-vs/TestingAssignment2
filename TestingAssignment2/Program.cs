using System;

namespace TestingAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Vrunda";
            string number = "123456";
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
            input = "VRUNDA";
            Console.WriteLine("Input : \"" + input + "\" into Lowercase Letter : " + input.ConvertToLower());
            input = "vrunda savaliya";
            Console.WriteLine("Input : \"" + input + "\" into Titlecase Letter : " + input.ConvertToTitleCase());
            input = "vrunda";
            Console.WriteLine("Check all the character of string is lower case or not : \"" + input + "\" : " + input.IsLower());
            input = "vrunda savaliya";
            Console.WriteLine("Input : \"" + input + "\" into Capitalize : " + input.ConvertToCapitalize());
            input = "VRUNDA";
            Console.WriteLine("Is input in uppercase : \"" + input + "\" : " + input.IsUpper());
            input = "vrunda savaliya";
            Console.WriteLine("No of words in the input : \"" + input + "\" : " + input.CountingWord());
            input = "Vrunda Savaliya";
            Console.WriteLine("Removing last character   : \"" + input + "\" : " + input.RemoveLastCharacterFrom());
            Console.WriteLine("==================================================");
        }
    }
}
