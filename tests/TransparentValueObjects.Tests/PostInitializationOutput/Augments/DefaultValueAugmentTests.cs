using System.Threading.Tasks;
using VerifyXunit;
using Xunit;

namespace TransparentValueObjects.Tests.PostInitializationOutput.Augments;

[UsesVerify]
public class DefaultValueAugmentTests
{
    [Fact]
    public Task Test_Source()
    {
        return TestHelpers.VerifyPostInitializationOutput("DefaultValueAugment.g.cs");
    }
}
