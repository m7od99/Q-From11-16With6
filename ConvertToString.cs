namespace QuestionsAndAnswerss
{
    public class ConvertToString
    {
        public static void PrintDoubleAsString(double input)
        {
          System.Console.WriteLine(ToString(input));
        }
        public static string ToString(char input)
        {
            return $"{input}";
        }
        public static string ToString(char[] input)
        {
            var test ="";
            for (int i = 0; i < input.Length; i++)
            {
                test = test +ToString(input[i]);
            }
            return test ;
        }
        public static string ToString(int input)
        {
            return $"{input}";
        }
        public static string ToString(double input)
        {
            return $"{input}";
        }
    }
}