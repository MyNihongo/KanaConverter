namespace MyNihongo.KanaConverter;

/// <summary>
/// This model is created for try-convert methods so that expensive operations of throwing and catching exceptions are avoided.
/// </summary>
internal readonly ref struct ConversionResult
{
	private readonly StringBuilder? _stringBuilder;
	public readonly string? ErrorMessage;

	private ConversionResult(StringBuilder? stringBuilder, string? errorMessage)
	{
		_stringBuilder = stringBuilder;
		ErrorMessage = errorMessage;
	}

	public string GetValue() =>
		_stringBuilder?.ToString() ?? string.Empty;

	public static ConversionResult FromValue(StringBuilder? value) =>
		new(value, errorMessage: null);

	public static ConversionResult FromError(string errorMessage) =>
		new(stringBuilder: null, errorMessage);
}
