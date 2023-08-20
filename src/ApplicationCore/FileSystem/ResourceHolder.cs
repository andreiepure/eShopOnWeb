using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.eShopWeb.ApplicationCore.FileSystem;
public class ResourceHolder
{
    public void WriteToFile(string path, string text)
    {
        var fs = new FileStream(path, FileMode.OpenOrCreate);
        var bytes = Encoding.UTF8.GetBytes(text);
        fs.Write(bytes, 0, bytes.Length);
        fs.Close();
    }
}
