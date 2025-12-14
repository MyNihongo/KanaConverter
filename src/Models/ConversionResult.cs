namespace MyNihongo.KanaConverter;

/// <summary>
/// This model is created for try-convert methods so that expensive operations of throwing and catching exceptions are avoided.
/// </summary>
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
