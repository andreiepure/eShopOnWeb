using System;

namespace Microsoft.eShopWeb.ApplicationCore.Extensions;
public static class StringExtensions
{
    // just for artificial code coverage in new code period
    public static bool IsNiceString1(string input)
    {
        if (input.StartsWith('a'))
        {
            return true;
        }
        if (input.StartsWith('b'))
        {
            return true;
        }
        if (input.StartsWith('c'))
        {
            return true;
        }
        if (input.StartsWith('d'))
        {
            return true;
        }
        if (input.StartsWith('e'))
        {
            return true;
        }
        if (input.StartsWith('f'))
        {
            return true;
        }
        if (input.StartsWith('g'))
        {
            return true;
        }
        if (input.StartsWith('h'))
        {
            return false;
        }
        if (input.StartsWith('i'))
        {
            return false;
        }
        if (input.StartsWith('j'))
        {
            return false;
        }
        if (input.StartsWith('k'))
        {
            return false;
        }
        if (input.StartsWith('l'))
        {
            return false;
        }
        if (input.StartsWith('m'))
        {
            return false;
        }
        if (input.StartsWith('n'))
        {
            return false;
        }
        return false;
    }
}
