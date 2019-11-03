using System;

namespace Open_Lab_03._11
{
    public class Checker
    {
        public bool IsPalindrome(string str)
        {
            string a = "";
            for (int i = str.Length - 1; i >= 0; i--) 
            {
                a = a + str[i]; 
            }
            return a == str;
        } 
    }
}
