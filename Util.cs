using System;
using System.Linq;
using System.Text.Encodings;

namespace QuestionsAndAnswerss {
    public class Util {

        public static bool TestIsTrim () {
            var x = RandomString ();
            x = Trim.TirmString (x);
            if (x[0] == ' ' || x[x.Length - 1] == ' ') {
                return false;
            }
            return true;
        }
        public static string RandomString () {
            var word = "";
            string alpha = " ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            for (int i = 0; i < 30; i++) {
                word = word + alpha[RandomChar ()];
            }
            return word;
        }
        public static int RandomChar () => new Random ().Next (0, 27);

        public static bool TestIfRevere () {
            var x = RandomString ();
            if (Reverse (x) == ReverseString.Reverse (x)) {
                return true;
            }
            return false;

        }
        public static string Reverse (string input) {
            return new string (input.Reverse ().ToArray ());
        }

        public static bool TestConvertInt () {
            var x = RandomNumber ();
            if (ConvertToString.ToString (x) == x.ToString ()) {
                return true;
            }
            return false;

        }

        public static int RandomNumber () => new Random ().Next (10000, 1000000);

        public static bool TestIsMultiplication () {
            var a = RandomNumber ();
            var b = RandomNumber ();
            if (a * b == Multiplication.Multi (a, b)) {
                return true;
            }
            return false;
        }

        public static bool TestFindWord () {
            var first = RandomString ();
            var second = CutString (first);
            if (FindWord.Find_Word (first, second) == first.IndexOf (second)) {
                return true;
            }
            return false;
        }
        public static string CutString (string x) {
            var word = "0";
            for (int i = 5; i < 11; i++) {
                word = word + x[i];
            }
            return word;
        }

        public static bool TestUTF16Hex () {
            var x = new Random ().Next (1, 254);
            var s = x.ToString ("x");
            if (UTF16.ConvertToHex ((char) x) == s) {
                return true;
            } else return false;
        }

        public static bool TestUTF16Binary () {
            var x = new Random ().Next (1, 254);
            var s = Convert.ToString ((char) x, 2);
            if (UTF16.ConvertToBinary ((char) x).ToString () == s) {
                return true;
            } else return false;
        }
       
    

       

    }
}