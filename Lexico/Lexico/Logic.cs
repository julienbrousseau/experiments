using System;
namespace Lexico
{
	public class Logic
	{
		public Logic()
		{
		}

		public string GetNextWord(string wordToTest)
		{
			char[] word = wordToTest.ToCharArray();

			//   ...rw.   
			//   ...^
			//   ...i
			int i = word.Length - 1;
			var found = false;

			while ((!found) && (i-1 >= 0))
			{
				i--;

				if (word[i] < word[i + 1])
				{
					found = true;
				}
			}

			if (!found) return "no answer";

			var indexReorderingStart = i;

			i = 0;
			char[] resultWord = new char[word.Length];

			while (i < indexReorderingStart)
			{
				// First putting back the letters preceding the index
				resultWord[i] = word[i];
				i++;
			}

			// The key letter to put here
			var letterInPlace = word[indexReorderingStart];
			var indexNextGreaterLetter = indexReorderingStart+1;
			for (i = indexReorderingStart+1; i < word.Length; i++) { 
				if ((word[i] > letterInPlace) && (word[i] < word[indexNextGreaterLetter])) {
					indexNextGreaterLetter = i;
				}
			}

			// Swapping letters
			resultWord[indexReorderingStart] = word[indexNextGreaterLetter];
			word[indexNextGreaterLetter] = word[indexReorderingStart];

			char[] remainingLetters = new char[word.Length - (indexReorderingStart + 1)];
			i = indexReorderingStart + 1;
			while (i < word.Length)
			{
				remainingLetters[i-indexReorderingStart-1] = word[i];
				i++;
			}

			// ordering all that
			Array.Sort(remainingLetters);

			for (i = 0; i < remainingLetters.Length; i++)
			{
				resultWord[indexReorderingStart + 1 + i] = remainingLetters[i];
			}

			return new string(resultWord);

		}

	}
}

