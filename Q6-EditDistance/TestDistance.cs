using System;
using System.Collections.Generic;
using System.IO;
namespace QuestionsAndAnswerss {
    public class TestDistance : Distance {
        public static void SaveWords () {
            var path = @"C:\Users\m7od9\Desktop\practice GitGithub\from11to16with6\Q6-EditDistance\words.text";
            File.AppendAllText (path, RandomWord () + Environment.NewLine);
        }
        public static string RandomWord () {
            var word = "";
            var alpha = " ABCDEFGHIJKLMNOPQRSTUVWXYZ abcdefghijklmnopqrstuvwxz";
            for (int i = 0; i < 10; i++) {
                word = word + alpha[new Random ().Next (0, 53)];
            }
            return word;
        }
        public static void WordTrees () {
            var alpha = " ABCDEFGHIJKLMNOPQRSTUVWXYZ abcdefghijklmnopqrstuvwxz";
            var path = @"C:\Users\m7od9\Desktop\practice GitGithub\from11to16with6\Q6-EditDistance\words.text";
            StreamReader streamReader = new StreamReader (path);
            var x = streamReader.ReadLine ();
            var s = "";
            for (int i = 0; i < 5; i++) {
                s = s + x[i];
                s = s + alpha[new Random ().Next (0, 53)];
            }
            streamReader.Close ();
            File.AppendAllText (path, s + Environment.NewLine);
        }
        public static string[] WordsList () {
            var path = @"C:\Users\m7od9\Desktop\practice GitGithub\from11to16with6\Q6-EditDistance\words.text";
            List<string> words = new List<string> ();
            using (StreamReader streamReader = new StreamReader (path)) {
                string line;
                while ((line = streamReader.ReadLine ()) != null) {
                    words.Add (line);
                }
            }
            return words.ToArray ();
        }
        public static bool TestInsertions()
        {
            var words = WordsList();
           for (int i = 0; i <= 10; i++)
           {
               if (Get_Insertions(words[0] ,words[i]).Length !=0 && words[i].Length - words[0].Length !=10)
               {
                   return false;
               }
           }
           return true;
        }
        public static bool TestDeletions()
        {
            var words = WordsList();
           for (int i = 0; i <= 10; i++)
           {
               if (Get_Deletions(words[i] ,words[0]).Length !=0 && words[i].Length - words[0].Length !=10)
               {
                   return false;
               }
           }
           return true;
        }
    }
}