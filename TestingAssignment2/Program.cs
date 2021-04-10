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
            
            //convert into uppercase
            Console.WriteLine("Input : \"" + input + "\" into Uppercase Letter : " + input.ConvertToUpper());
             //convert into lowercase
            input = "VRUNDA";
            Console.WriteLine("Input : \"" + input + "\" into Lowercase Letter : " + input.ConvertToLower());
             //convert into oppositecase
            input = "VRUndA savaLIya";
            Console.WriteLine("Convert Input : \"" + input + "\" into oppsite Letter : " + input.ConvertToOppositeCase());
            //convert into titlecase
            input = "VRUNDA";
            Console.WriteLine("Input : \"" + input + "\" into Titlecase Letter : " + input.ConvertToTitleCase());
            //check wherther string is in lowercase or not
            input = "vrunda";
            Console.WriteLine("Check all the character of string is lower case or not : \"" + input + "\" : " + input.IsLower());
            //convert into capitlize
            input = "vrunda savaliya";
            Console.WriteLine("Input : \"" + input + "\" into Capitalize : " + input.ConvertToCapitalize());
            //check whether string is uppercase  or not
            input = "VRUNDA";
            Console.WriteLine("Is input in uppercase : \"" + input + "\" : " + input.IsUpper());
            //countingword
            input = "vrunda savaliya";
            Console.WriteLine("No of words in the input : \"" + input + "\" : " + input.CountingWord());
            //removing last charecter 
            input = "Vrunda Savaliya";
            Console.WriteLine("Removing last character   : \"" + input + "\" : " + input.RemoveLastCharacterFrom());
            Console.WriteLine("==================================================");
        }
    }
}
