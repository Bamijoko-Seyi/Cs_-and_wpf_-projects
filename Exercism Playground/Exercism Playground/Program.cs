using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.DesignerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercism_Playground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a sentence to transform to pig latin:");
            string Sentence = Console.ReadLine();
            Sentence = Sentence.ToLower();
            Sentence = Sentence.Trim();
            char[] delimiters = { ' ', '\n', '\t' };
            string[] words = Sentence.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            List<string> transformedWords = new List<string>();
            foreach (string word in words)
            {
                //rule one
                char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
                if (vowels.Contains(word[0]) || word.Substring(0, 2) == "xr" || word.Substring(0, 2) == "yt")
                {
                    string transformedWord = "";
                    if (vowels.Contains(word[word.Length - 1]))
                    {
                        transformedWord = word + "yay";
                    }
                    else
                    {
                        transformedWord = word + "ay";
                    }
                    //Console.WriteLine("This is case one: " + transformedWord);
                    transformedWords.Add(transformedWord);
                    continue;
                }

                //rule two
                if (word.Length > 2 && word.Substring(1, 2) != "qu" && !word.Contains('y'))
                {
                    string tempConsonants = "";
                    int currentPos = 0;
                    for (int i = 0; i < word.Length; i++)
                    {
                        if (!"aeiouAEIOU".Contains(word[i]))
                        {
                            tempConsonants += word[i];
                            currentPos++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    //Console.WriteLine("This is case two: " + word.Substring(currentPos) + tempConsonants + "ay");
                    transformedWords.Add(word.Substring(currentPos) + tempConsonants + "ay");
                    continue;
                }

                //rule three
                if (word.Length > 2 && !"aeiouAEIOU".Contains(word[0]) && word.Substring(1, 2) == "qu") 
                {
                    Console.WriteLine("This is case three: " + word.Substring(3) + word.Substring(0, 3)+"ay");
                    transformedWords.Add(word.Substring(3) + word.Substring(0, 3) + "ay");
                    continue;
                }

                //rule four
                //wordlength of 2
                if (word.Length == 2 && word[1] == 'y')
                {
                    //Console.WriteLine("This is case four: " + 'y' + word[0] + "ay");
                    transformedWords.Add('y' + word[0] + "ay");
                    continue;
                }
                //cluster of consonants
                else {
                    string tempConsonants = "";
                    int currentPos = 0;
                    for (int i = 0; i < word.Length; i++)
                    {
                        if (!"aeiouAEIOU".Contains(word[i]))
                        {
                            tempConsonants += word[i];
                            currentPos++;
                        }
                        else if (word[i] == 'y')
                        {
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                    //Console.WriteLine("This is case four: " + 'y' + word.Substring(currentPos + 1) + tempConsonants + "ay");
                    transformedWords.Add('y' + word.Substring(currentPos + 1) + tempConsonants + "ay");
                        }


            }
            string joinedSentence = string.Join(" ", transformedWords);
            Console.WriteLine(joinedSentence);
            Console.ReadLine();
            int[] testArray = { 1, 2, 3, 4, 5 };
            
            

        }
        
        

    }


}
     
