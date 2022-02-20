namespace MyNihongo.KanaConverter;

public sealed class InvalidKanaException : Exception
{
	internal InvalidKanaException(string message)
		: base(message)
	{
	}
}