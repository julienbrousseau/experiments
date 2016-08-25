using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lexico {
    public class Program {
        static void Main(string[] args) {

			int numberCases = Convert.ToInt32(Console.ReadLine());

			var words = new string[numberCases];

			for (int i = 0; i < numberCases; i++)
			{
				words[i] = Console.ReadLine();
			}
			foreach (string word in words)
			{
				Console.WriteLine(new Logic().GetNextWord(word));
			}
        }
    }
}
