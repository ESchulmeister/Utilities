using System;

namespace Utilities
{
    interface IReader
    {
        string Read(string sKey);
        string[] Read(string sKey, params string[] aDelimiters);
    }
}
