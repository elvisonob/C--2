using System;

namespace Coding.Exercise


{
    public class Exercise
    {
        public List<string> GetOnlyUpperCaseWords(List<string> words)
        {
            //your code goes here
            List<string> newArray = new List<string>();
            foreach (var word in words)
            {
                foreach (char word2 in word)
                {
                    if (char.IsUpper(word2))
                    {
                        newArray.Add(word);
                    };
                }
            }
            {

            }

            //if two or more words are same and they are already caps, return one of them




        }
    }
}

