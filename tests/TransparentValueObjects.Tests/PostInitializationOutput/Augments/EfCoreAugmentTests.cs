using Xunit;

namespace TransparentValueObjects.Tests.PostInitializationOutput.Augments;

public class EfCoreAugmentTests
{
    private const string Expected = /*lang=csharp*/
"""
// <auto-generated/>

namespace TransparentValueObjects
{
    /// <summary>
    /// Augment to enable support for EF Core model configuration by generting a
    /// <c>ValueConverter<TValueObject, TInnerValue></c> and a <c>ValueComparer<TValueObject></c>.
    /// </summary>
    /// <remarks>
    /// This requires <c>Microsoft.EntityFrameworkCore</c>.
    /// </remarks>
	[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage(Justification = "Auto-generated")]
	public sealed class EfCoreAugment : global::TransparentValueObjects.IAugment { }
}
""";

    [Fact]
    public void Test_Source()
    {
        TestHelpers.TestPostInitializationOutput("EfCoreAugment.g.cs", Expected);
    }
}