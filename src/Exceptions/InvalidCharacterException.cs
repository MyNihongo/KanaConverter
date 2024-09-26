namespace MyNihongo.KanaConverter;

public sealed class InvalidCharacterException : Exception
{
	internal InvalidCharacterException(string message)
		: base(message)
	{
	}
}
