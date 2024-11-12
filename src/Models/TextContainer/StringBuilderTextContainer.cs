namespace MyNihongo.KanaConverter;

internal sealed class StringBuilderTextContainer : ITextContainer
{
	private readonly StringBuilder _stringBuilder;

	public StringBuilderTextContainer(StringBuilder stringBuilder)
	{
		_stringBuilder = stringBuilder;
	}

	public char this[int index] => _stringBuilder[index];

	public int Length => _stringBuilder.Length;

	public bool IsEmpty => _stringBuilder.Length == 0;
}
