namespace QuestionsAndAnswerss {
    public class Trim {
        // the method name 
        public static string TirmString (string input) {
            var first = 0;
            var end = input.Length;
           
            var x = "";
            // cheak first and end character if is whitespace 
            while (input[first] == ' ')first++;
            while(input[end-1] == ' ')end--;
    
            for (int i = first; i < end; i++) {
                x = x + input[i];
            }
            return x;

        }

    }
}