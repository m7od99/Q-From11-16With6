namespace QuestionsAndAnswerss {
    public class UTF16 {
        public static void PrintHexAndBinary (char input) {
            var output = $"The Binary of {input} is : {ConvertToBinary(input)} , Hex is : {ConvertToHex(input)}";
            System.Console.WriteLine (output);
        }
        public static void PrintHexAndBinary (int input) {
            var toChar = ToCharArray (input);
            var output = "";
            foreach (var item in toChar) {
                output = $"The Binary of {item} is : {ConvertToBinary(item)} , Hex is : {ConvertToHex(item)}";
                System.Console.WriteLine (output);
            }
        }

        public static void PrintHexAndBinary (string input) {
            var toChar = ToCharArray (input);
            var output = "";
            foreach (var item in toChar) {
                output = $"The Binary of {item} is : {ConvertToBinary(item)} , Hex is : {ConvertToHex(item)}";
                System.Console.WriteLine (output);
            }
        }

        // -0 initialize method that hold name ToCharAraay that take string and return char array :
        public static char[] ToCharArray (string input) {
            //take every single character in the string as element in the array .
            var charArray = new char[input.Length];
            for (int i = 0; i < input.Length; i++) {
                charArray[i] = input[i];
            }
            return charArray;
        }

        public static char[] ToCharArray (int input) {
            var x = input.ToString ();
            var charArray = new char[x.Length];
            for (int i = 0; i < x.Length; i++) {
                charArray[i] = x[i];
            }
            return charArray;
        }

        //-0 initialize a mthod that hold name ConvertToBinary that take char and return the value of binary as string :
        public static string ConvertToBinary (char input) {
            var x = 0;
            var remainder = "";
            var number = ConvertToInt (input);
            // 1-in method we need to keep dividing the input by 2 and take the remainder until the input become smaller then 1 .
            while (number > 0) {
                x = number % 2;
                remainder = x.ToString () + remainder;
                number /= 2;
            }
            // 2-save the remainder from right and at the end adding it to 0^16 and return it 
            return remainder;
        }

        //-0 initialize a mthod that hold name ConvertToHex that take char and return the value of hexadecimal :
        public static string ConvertToHex (char input) {
            //  -initialize a string for save the remainder.
            var remainder = "";
            var number = ConvertToInt (input);
            var x = 0;

            // -keep dividing the input by 16 and take the remainder until the input become smaller then 0 .
            while (number > 0) {
                // -if the remainder bigger then 9 : return a for 10 , b for 11 , c for 12 , d for 13 , e for 14 ,f for 16 .
                switch (number % 16) {
                    case 10:
                        remainder = "a" + remainder;
                        break;

                    case 11:
                        remainder = "b" + remainder;
                        break;

                    case 12:
                        remainder = "c" + remainder;
                        break;

                    case 13:
                        remainder = "d" + remainder;
                        break;

                    case 14:
                        remainder = "e" + remainder;
                        break;

                    case 15:
                        remainder = "f" + remainder;
                        break;

                    default:
                        x = number % 16;
                        remainder = x.ToString () + remainder;
                        break;
                }
                number /= 16;
            }
            return remainder;
        }

        public static int ConvertToInt (char input) {
            return (int) input;
        }

    }

}