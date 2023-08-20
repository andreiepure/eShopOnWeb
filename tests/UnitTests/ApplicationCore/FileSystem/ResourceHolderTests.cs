using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.eShopWeb.ApplicationCore.FileSystem;
using Xunit;

namespace Microsoft.eShopWeb.UnitTests.ApplicationCore.FileSystem;
public class ResourceHolderTests
{
    [Fact]
    public void WritesFileToDisk()
    {
        var underTest = new ResourceHolder();
        underTest.WriteToFile("test", "foo");
        
        Assert.True(File.Exists("test"));
    }
}
