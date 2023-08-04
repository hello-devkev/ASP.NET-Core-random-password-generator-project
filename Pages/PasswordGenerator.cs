// PasswordGenerator.cs
using System;
using System.Text;

namespace PasswordGeneratorProject
{
    public static class PasswordGenerator
    {
        private static readonly string Alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private static readonly string Numbers = "0123456789";
        private static readonly string SpecialCharacters = "!@#$%^&*()_-+=[]{}|:;<>,.?/";

        public static string GeneratePassword(int length, bool includeNumbers = true, bool includeSpecialChars = true)
        {
            StringBuilder result = new StringBuilder(length);
            string validChars = Alphabet;

            if (includeNumbers)
                validChars += Numbers;
            if (includeSpecialChars)
                validChars += SpecialCharacters;

            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                int index = random.Next(validChars.Length);
                result.Append(validChars[index]);
            }

            return result.ToString();
        }
    }
}

