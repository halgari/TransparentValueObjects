using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using VerifyXunit;
using Xunit;

namespace TransparentValueObjects.Tests.PostInitializationOutput;

[UsesVerify]
[SuppressMessage("ReSharper", "InconsistentNaming")]
public class IValueObjectTests
{
    [Fact]
    public Task Test_Source()
    {
        return TestHelpers.VerifyPostInitializationOutput("IValueObject.g.cs");
    }
}
