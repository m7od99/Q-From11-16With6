namespace QuestionsAndAnswerss {
    public class FindWord {

        public static int Find_Word (string first, string word) {
            //  -0 initialize index and set it 0 .
            var index = 0;
            for (int i = index; i < first.Length; i++) {
                if (first[i] == word[0]) {
                    index = i;
                    if (AllInIt (first, word, index) == true) {
                        return index;
                    }
                }
            }
            return -1;
            // -0 if yes return true and return index of first char else return -1
        }

        // -0 method to cheak if still character in string or not by minus index from length .
        public static bool IsStillCharacter (string input, int index) {
            if (input.Length - index > 1)
                return true;
            else return false;
        }

        // -0 method that cheak if all character of word in the string 
        public static bool AllInIt (string first, string second, int index) {
            var x = 0;
            while (IsStillCharacter (first, index) == true && IsStillCharacter (second, x)) {
                if (first[index + 1] != second[x + 1]) {
                    return false;
                }
                x++;
                index++;
            }
            return true;
        }

    }
}