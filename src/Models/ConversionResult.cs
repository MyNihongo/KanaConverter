namespace MyNihongo.KanaConverter;

internal readonly ref struct ConversionResult
{
	private ConversionResult(string value, string? errorMessage)
	{
		Value = value;
		ErrorMessage = errorMessage;
	}

	public string Value { get; }

	public string? ErrorMessage { get; }

	public static ConversionResult FromValue(string value) =>
		new(value, null);

	public static ConversionResult FromError(string errorMessage) =>
		new(string.Empty, errorMessage);
}