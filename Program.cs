using System;
using System.Linq;

namespace QuestionsAndAnswerss {
    class Program {
        static void Main (string[] args) {

            Distance.Edit_Distance ("love you", "ve k bal");

            Distance.Edit_Distance ("lk", "love");


            for (int i = 0; i < 10; i++) {
                Console.Write (Util.TestIsTrim () + " "); // true
            }
            Console.WriteLine ();

            for (int i = 0; i < 10; i++) {
                Console.Write (Util.TestIfRevere () + " "); // true
            }
            Console.WriteLine ();

            for (int i = 0; i < 10; i++) {
                Console.Write (Util.TestConvertInt () + " "); // true 
            }
            System.Console.WriteLine ();

            for (int i = 0; i < 10; i++) {
                Console.Write (Util.TestIsMultiplication () + " "); // true 
            }
            Console.WriteLine ();

            for (int i = 0; i < 10; i++) {
                Console.Write (Util.TestFindWord () + " "); // true
            }
            Console.WriteLine ();

            for (int i = 0; i < 10; i++) {
                Console.Write (Util.TestUTF16Hex () + " "); // true
            }
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                Console.Write (Util.TestUTF16Binary () + " "); // true
            }
            System.Console.WriteLine();

            Console.WriteLine(TestDistance.TestInsertions()); // true 
            Console.WriteLine(TestDistance.TestDeletions());
  
        }

    }

}