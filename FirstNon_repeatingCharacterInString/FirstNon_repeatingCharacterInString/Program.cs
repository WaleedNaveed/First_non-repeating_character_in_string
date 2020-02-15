using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstNon_repeatingCharacterInString
{
    class Program
    {
        static Dictionary<char, int> charCountMapping = new Dictionary<char, int>();

        static void FillDictionary(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (charCountMapping.ContainsKey(str[i]))
                    charCountMapping[str[i]]++;
                else
                    charCountMapping.Add(str[i], 1);
            }
        }

        static char? GetFirstNonRepeatingCharacter(string str)
        {
            if (string.IsNullOrEmpty(str))
                return null;
            FillDictionary(str);
            return charCountMapping.Where(x => x.Value == 1).FirstOrDefault().Key;
        }

        static void Main(string[] args)
        {
            string str = "WaleedNaveed";

            char? firstNonRepeatingChar = GetFirstNonRepeatingCharacter(str);

            if (firstNonRepeatingChar.HasValue)
                Console.WriteLine("First Non-Repeating character is : " + firstNonRepeatingChar.Value);
            else
                Console.WriteLine("Either string is null or there is no non-repeating character");

            Console.ReadKey();
        }
    }
}
