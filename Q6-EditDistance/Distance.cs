using System.Collections.Generic;
using System.Linq;
namespace QuestionsAndAnswerss {
    public class Distance {
        public string Insertions { get; set; }
        public string Deletions { get; set; }
        public int Amount { get; set; }
        public static void Edit_Distance (string first, string second) {
            //0- initialize counter for insertions . set to 0 .
            var counterOfInsertions = 0;

            //0- initialize counter for deletions . set to 0 .
            var counterOFDeletions = 0;

            var edit = new Distance ();

            //  remove every common character between them .
            edit.Deletions = Distance.Get_Deletions (first, second);
            edit.Insertions = Distance.Get_Insertions (first, second);

            //  for each character in first string increment the counter of deletions.
            counterOFDeletions = edit.Deletions.Length;

            // for each character in second string increment the counter of insertions.
            counterOfInsertions = edit.Insertions.Length;

            edit.Amount = counterOFDeletions + counterOfInsertions;

            // return the amount of insertions and deletions
            Distance.Print_Result (edit);
        }

        public static string Get_Deletions (string first, string second) {
            var name = "";

            for (int i = 0; i < first.Length; i++) {
                if (second.IndexOf (first[i]) == -1) {
                    name = name + first[i];
                }
            }
            name = Distance.CheakCommon (second, first, name);
            return name;
        }

        public static string Get_Insertions (string first, string second) {
            var name = "";

            for (int i = 0; i < second.Length; i++) {
                if (first.IndexOf (second[i]) == -1) {
                    name = name + second[i];
                }
            }
            name = Distance.CheakCommon (first, second, name);

            return name;
        }

        public static string Get_Common (string first, string second) {
            var name = "";
            for (int i = 0; i < first.Length; i++) {
                if (second.IndexOf (first[i]) != -1) {
                    name = name + first[i];
                }
            }
            return name;
        }

        public static string CheakCommon (string first, string second, string word) {
            var common = Distance.Get_Common (first, second);
            var firstWord = 0;
            var secondWord = 0;
            var count = 0;

            for (int i = 0; i < common.Length; i++) {
                firstWord = Distance.Count_Character (first, common[i]);
                secondWord = Distance.Count_Character (second, common[i]);

                if (secondWord - firstWord > 0) {
                    count = secondWord - firstWord;
                    for (int a = 0; a < count; a++) {
                        word = common[i] + word;
                    }
                }
                count = 0;
                firstWord = 0;
                secondWord = 0;
            }
            return word;
        }

        public static int Count_Character (string word, char cha) {
            var count = 0;
            foreach (var item in word) {
                if (item == cha) {
                    count++;
                }
            }
            return count;
        }

        public static void Print_Result (Distance distance) {
            System.Console.WriteLine ($"The Deletions : {distance.Deletions}");
            System.Console.WriteLine ($"The Insertions : {distance.Insertions}");
            System.Console.WriteLine ($"The Amount : {distance.Amount}");
        }
    }
}