using System.Runtime.InteropServices;

namespace MyNihongo.KanaConverter
{
	[StructLayout(LayoutKind.Sequential)]
	internal readonly ref struct YouonChar
	{
		public YouonChar(char @char, char? secondChar = null)
		{
			Char = @char;
			SecondChar = secondChar;
		}

		public char Char { get; }

		public char? SecondChar { get; }
	}
}
