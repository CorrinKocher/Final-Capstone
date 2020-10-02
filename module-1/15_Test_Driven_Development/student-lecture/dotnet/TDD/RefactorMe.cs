using System;
using System.Collections.Generic;
using System.Text;

namespace TDD
{
    public class RefactorMe
    {
        public string FrontTimes(string input, int timesToRepeat)
        {
            string result = "";

            const int MaxCharacters = 3;
            
                for (int i = 0; i < timesToRepeat; i++)
                {
                    if(input.Length < MaxCharacters)
                    {
                        result += input;
                    }
                    else
                    {
                        result += input.Substring(0, MaxCharacters);
                    }
                   
                }
                return result;
            
        }
    }
}