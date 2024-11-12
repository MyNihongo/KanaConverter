namespace MyNihongo.KanaConverter;

internal interface ITextContainer
{
	char this[int index] { get; }

	int Length { get; }

	bool IsEmpty { get; }
}
