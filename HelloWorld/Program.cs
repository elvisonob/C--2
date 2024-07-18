using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public List<string> GetOnlyUpperCaseWords(List<string> words)
        {
            //your code goes here
            List<string> result = new List<string>();
            foreach(var word in words)
            {
                bool isWordContains = true;
foreach(var word2 in word)
                {
                    if (char.IsUpper(word2))
                    {
                        continue;
                    }

                    if (isWordContains)
                    {
                        result.Add(word);
                    }
                }
            }
            return result;
        }
    }
}