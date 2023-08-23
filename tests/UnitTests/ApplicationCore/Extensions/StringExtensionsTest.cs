using Microsoft.eShopWeb.ApplicationCore.Extensions;
using Xunit;

namespace Microsoft.eShopWeb.UnitTests.ApplicationCore.Extensions;

public class StringExtensionsTest
{
    [
        Theory,
        InlineData("a", true),
        InlineData("ah", true),
        InlineData("bah", true),
        InlineData("c", true),
        InlineData("d", true),
        InlineData("ew", true),
        InlineData("f", true),
        InlineData("g", true),
        InlineData("h", false),
        InlineData("i", false),
        InlineData("j", false),
        InlineData("k", false),
        InlineData("l", false),
        InlineData("m", false),
        InlineData("n", false),
        InlineData("o", false),
        InlineData("p", false),
        InlineData("q", false),
    ]
    public void ArtificialCoverage(string s, bool expectedResult) =>
        Assert.Equal(StringExtensions.IsNiceString1(s), expectedResult);

}
