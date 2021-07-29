using System;

namespace MyNihongo.KanaConverter.Exceptions
{
	public sealed class InvalidKanaException : Exception
	{
		internal InvalidKanaException(char @char, string @string)
			: base($"Invalid kana character \"{@char}\" in \"{@string}\"")
		{
		}
	}
}
