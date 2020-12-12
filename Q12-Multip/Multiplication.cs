namespace QuestionsAndAnswerss
{
    public class Multiplication
    {
        public static bool IsDigit(string number)
        {
            //at first we need to make sure the input is number .

            while (true)
           {
               foreach (var item in number)
               {
                   if ((int)item >58 || (int)item <47)
                       return false;
                   
                    else return true;
               }
           }
        }
        public static int DoMultiplication(string first , string second)
        {
            //-0 initialize Answer and set it to 0 
            var Answer = 0;

            // convert the strings to intgers by using ASCII Table .
            var firstNumber = ConvertToInt(first);
            var secondNumber = ConvertToInt(second);

            //-Repeat the addition of the first number by itself as much as the second number and save it in Answer
            for (int i = 0; i < secondNumber; i++)
            {
                Answer = Answer + firstNumber;
            }
            return Answer ;
        }

        public static int ConvertToInt(string input)
        {
            //-then convert the strings to intgers by using ASCII Table . 
            var x =0;
            while(true)
            if (IsDigit(input) == true)
            {
                foreach(var item in input)
                {
                    // *10 for add the new number || -48 the starting number from Ascii table 
                    x=x*10+ item-48 ;
                }
                return x ;
            }
        }
    }
}