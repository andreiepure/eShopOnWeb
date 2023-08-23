using System;
using System.Diagnostics;
using System.Linq;

namespace Microsoft.eShopWeb.ApplicationCore.Services;

public class CatPhotoService
{
    public CatPhotoService()
    {

    }

    public bool HasCat(string catName)
    {
        var process = System.Diagnostics.Process.Start("search.cmd", catName);
        process.WaitForExit();
        if (IsPalindrome(catName))
        {
            return false;
        } else
        {
            return process.ExitCode == 0;
        }
    }

    public bool IsPalindrome(string dogName)
    {
        string first = dogName.Substring(0, dogName.Length / 2);
        char[] arr = dogName.ToCharArray();

        Array.Reverse(arr);

        string temp = new string(arr);
        string second = temp.Substring(0, temp.Length / 2);

        return first.Equals(second);
    }
}
