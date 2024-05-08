
using Xunit;
using Microsoft.eShopWeb.ApplicationCore.Services;

namespace Microsoft.eShopWeb.UnitTests.ApplicationCore.Services;

public class CatPhotoServiceTest
{
    [Fact]
    public async Task IsPalindromeFalse()
    {
        CatPhotoService service = new CatPhotoService();
        Assert.False(service.IsPalindrome("hannah"));
    }

    [Fact]
    public async Task IsPalindromeTrue()
    {
        CatPhotoService service = new CatPhotoService();
        Assert.True(service.IsPalindrome("noah"));
    }
}
