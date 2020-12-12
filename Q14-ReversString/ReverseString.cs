namespace QuestionsAndAnswerss
{
    public class ReverseString
    {
         public static string Reverse(string input)
        {
            var word = "" ;
            //by starting from last char in the input 
            for (int i = input.Length-1; i >= 0; i--)
            {
                word = word+input[i];
            }
            return word;
        }
    }
}