using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.eShopWeb.ApplicationCore.FileSystem;
public class ResourceHolder
{
    private FileStream fs; // Noncompliant: dispose or close are never called

    public ResourceHolder(string path)
    {
        this.fs = new FileStream(path, FileMode.Open);
    }

    public void WriteToFile(string path, string text)
    {
        var fs = new FileStream(path, FileMode.Open); // Noncompliant: not disposed, returned or initialized with another disposable object
        var bytes = Encoding.UTF8.GetBytes(text);
        fs.Write(bytes, 0, bytes.Length);
    }
}
