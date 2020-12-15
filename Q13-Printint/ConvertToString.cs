using System;
namespace QuestionsAndAnswerss {
    public class ConvertToString {
        // by using $ we can convert any value to string .
        public static void PrintDoubleAsString (double input) {
            System.Console.WriteLine (1);
        }
        public static string ToString (char input) {
            return $"{input}";
        }
        public static string ToString (char[] input) {
            var test = "";
            for (int i = 0; i < input.Length; i++) {
                test = test + ToString (input[i]);
            }
            return test;
        }
        public static string ToString (int input) {
            var x = ToIntArray (input);
            return new string (ToCharArray (x));
        }

        public static string ToString (double input) {

            return $"{input}";
        }

        public static int[] ToIntArray (int number) {
            var length = Length_OfNumber (number) + 1;
            var x = 0;
            var zero = Length_OfNumber (number);
            var copyNumber = number;
            var ints = new int[length];
            while (x < length) {
                copyNumber = Split_Numbers (copyNumber);
                number = number - copyNumber * Get_Power (10, Length_OfNumber (number));
                if (zero - Length_OfNumber (number) > 1) {
                    ints[x] = copyNumber;
                    x = x + zero - Length_OfNumber (number);
                    zero = Length_OfNumber (number);
                } else {
                    ints[x] = copyNumber;
                    x++;
                    zero = zero - 1;
                }

                copyNumber = number;
            }

            return ints;
        }
        public static int Get_Power (int number, int pow) {
            if (pow == 0) {
                return 0;
            } else if (pow == 1) {
                return number;
            }

            var x = number;
            for (int i = 1; i < pow; i++) {
                number = x * number;
            }
            return number;
        }
        public static int Length_OfNumber (int number) {
            var counter = 0;
            while (number >= 10) {
                number = number / 10;
                counter++;
            }
            return counter;
        }
        public static int Split_Numbers (int number) {
            while (number >= 10) {
                number = number / 10;
            }
            return number;
        }

        public static char[] ToCharArray (int[] numbers) {
            var x = 0;
            var chars = new char[numbers.Length];
            for (int i = 0; i < numbers.Length; i++) {
                x = numbers[i] + 48;
                chars[i] = (char) x;
            }
            return chars;
        }

    }
}