using NUnit.Framework;
using System;
namespace Lexico.Tests
{
	[TestFixture]
	public class Test
	{
		[TestCase("ab", "ba")]
		[TestCase("bb", "no answer")]
		[TestCase("hefg", "hegf")]
		[TestCase("dhck", "dhkc")]
		[TestCase("dkhc", "hcdk")]
		[TestCase("bcdaog", "bcdgao")]
		[TestCase("dldmsym", "dldmyms")]
		[TestCase("aym", "may")]
		[TestCase("dldmszym", "dldmymsz")]
		public void TestNextWord(string word, string expected)
		{
			// ARRANGE
			var sut = new Logic();

			// ACT
			var result = sut.GetNextWord(word);

			// ASSERT
			Assert.AreEqual(expected, result);
		}
	}
}

