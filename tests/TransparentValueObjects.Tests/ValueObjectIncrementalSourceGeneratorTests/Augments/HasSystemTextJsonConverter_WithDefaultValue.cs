using Xunit;

namespace TransparentValueObjects.Tests.ValueObjectIncrementalSourceGeneratorTests.Augments;

public class HasSystemTextJsonConverter_WithDefaultValue
{
    private const string Input =
"""
using TransparentValueObjects.Generated;
using TransparentValueObjects.Augments;

namespace TestNamespace;

[ValueObject<string>]
public readonly partial struct StringValueObject : IHasDefaultValue<StringValueObject>, IHasSystemTextJsonConverter
{
    public static StringValueObject DefaultValue => From("Hello World!");
}
""";

    private const string Output =
"""
// <auto-generated/>
#nullable enable
namespace TestNamespace;

[global::System.Diagnostics.DebuggerDisplay("{Value}")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage(Justification = "Auto-generated.")]
[global::System.Text.Json.Serialization.JsonConverter(typeof(SystemTextJsonConverter))]
readonly partial struct StringValueObject :
	global::TransparentValueObjects.Augments.IValueObject<global::System.String>,
	global::System.IEquatable<StringValueObject>,
	global::System.IEquatable<global::System.String>,
	global::System.IComparable<StringValueObject>
{
	public readonly global::System.String Value;

	public StringValueObject()
	{
		Value = DefaultValue.Value;
	}

	private StringValueObject(global::System.String value)
	{
		Value = value;
	}

	public static StringValueObject From(global::System.String value) => new(value);

	public override int GetHashCode() => Value.GetHashCode();

	public override string ToString() => Value.ToString();

	public bool Equals(StringValueObject other) => Equals(other.Value);
	public bool Equals(global::System.String? other) => Value.Equals(other);
	public bool Equals(StringValueObject other, global::System.Collections.Generic.IEqualityComparer<global::System.String> comparer) => comparer.Equals(Value, other.Value);
	public override bool Equals(object? obj)
	{
		if (obj is null) return false;
		if (obj is StringValueObject value) return Equals(value);
		if (obj is global::System.String innerValue) return Equals(innerValue);
		return false;
	}

	public static bool operator ==(StringValueObject left, StringValueObject right) => left.Equals(right);
	public static bool operator !=(StringValueObject left, StringValueObject right) => !left.Equals(right);

	public static bool operator ==(StringValueObject left, global::System.String right) => left.Equals(right);
	public static bool operator !=(StringValueObject left, global::System.String right) => !left.Equals(right);

	public static bool operator ==(global::System.String left, StringValueObject right) => right.Equals(left);
	public static bool operator !=(global::System.String left, StringValueObject right) => !right.Equals(left);

	public static explicit operator StringValueObject(global::System.String value) => From(value);
	public static explicit operator global::System.String(StringValueObject value) => value.Value;

	public static global::System.Type SystemTextJsonConverterType => typeof(SystemTextJsonConverter);
	public class SystemTextJsonConverter : global::System.Text.Json.Serialization.JsonConverter<StringValueObject>
	{
		private static global::System.Text.Json.Serialization.JsonConverter<global::System.String> GetInnerValueConverter(global::System.Text.Json.JsonSerializerOptions options)
		{
			var innerValueConverter = options.GetConverter(typeof(global::System.String));
			if (innerValueConverter is null) throw new global::System.Text.Json.JsonException($"Unable to find converter for type {typeof(global::System.String)}");
			return (global::System.Text.Json.Serialization.JsonConverter<global::System.String>) innerValueConverter;
		}

		public override StringValueObject Read(ref global::System.Text.Json.Utf8JsonReader reader, global::System.Type typeToConvert, global::System.Text.Json.JsonSerializerOptions options)
		{
			var innerValueConverter = GetInnerValueConverter(options);
			var innerValue = innerValueConverter.Read(ref reader, typeof(global::System.String), options);
			return innerValue == default ? DefaultValue : From(innerValue);
		}

		public override void Write(global::System.Text.Json.Utf8JsonWriter writer, StringValueObject value, global::System.Text.Json.JsonSerializerOptions options)
		{
			var innerValueConverter = GetInnerValueConverter(options);
			innerValueConverter.Write(writer, value.Value, options);
		}

		public override StringValueObject ReadAsPropertyName(ref global::System.Text.Json.Utf8JsonReader reader, global::System.Type typeToConvert, global::System.Text.Json.JsonSerializerOptions options)
		{
			var innerValueConverter = GetInnerValueConverter(options);
			var innerValue = innerValueConverter.ReadAsPropertyName(ref reader, typeof(global::System.String), options);
			return From(innerValue);
		}

		public override void WriteAsPropertyName(global::System.Text.Json.Utf8JsonWriter writer, StringValueObject value, global::System.Text.Json.JsonSerializerOptions options)
		{
			var innerValueConverter = GetInnerValueConverter(options);
			innerValueConverter.WriteAsPropertyName(writer, value.Value, options);
		}

	}

	public global::System.Int32 CompareTo(StringValueObject other) => Value.CompareTo(other);
}
""";

    [Fact]
    public void TestAugment()
    {
        TestHelpers.TestGenerator(Input, "StringValueObject.g.cs", Output);
    }
}
