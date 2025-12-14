namespace MyNihongo.KanaConverter;

internal sealed class StringTextContainer : ITextContainer
{
	private readonly string _text;

	public StringTextContainer(string text)
	{
		_text = text;
	}

	public char this[int index] => _text[index];

	public int Length => _text.Length;

	public bool IsEmpty => string.IsNullOrEmpty(_text);
}
