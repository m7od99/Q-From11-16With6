using System;
using System.Linq;


namespace QuestionsAndAnswerss
{
    class Program
    {
        static void Main(string[] args)
        {      

           Distance.Edit_Distance("love you" ,"ve k bal");

           Distance.Edit_Distance("lk", "love");

           Console.WriteLine(Multiplication.DoMultiplication("3", "2")); // 6
           Console.WriteLine(Multiplication.DoMultiplication("100", "5")); // 500
           Console.WriteLine(Multiplication.DoMultiplication("6", "6")); // 36
           Console.WriteLine(Multiplication.DoMultiplication("5", "5")); // 25

           UTF16.PrintHexAndBinary('M');
           UTF16.PrintHexAndBinary(91);
           UTF16.PrintHexAndBinary("dot.net");

           
           var s = ConvertToString.ToString(223201);
           System.Console.WriteLine(s);

           var c = "    who are you   "; 
           System.Console.WriteLine(Trim.TirmString(c)); //who are you



        }
       


    }
    
}
