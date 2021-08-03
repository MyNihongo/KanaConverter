using System.Text;

namespace MyNihongo.KanaConverter
{
	internal static class StringBuilderEx
	{
		public static void Append(this StringBuilder @this, in YouonChar youonChar)
		{
			@this.Append(youonChar.Char);

			if (youonChar.SecondChar.HasValue)
				@this.Append(youonChar.SecondChar.Value);
		}

		public static void Set(this StringBuilder @this, int index, in YouonChar youonChar)
		{
			@this[index] = youonChar.Char;

			if (youonChar.SecondChar.HasValue)
				@this.Append(youonChar.SecondChar.Value);
		}
	}
}
