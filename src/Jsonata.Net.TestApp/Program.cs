using Jsonata.Net.Js;
using System;
using System.Diagnostics;

namespace Jsonata.Net.TestApp
{
    internal sealed class Program
    {
        static void Main(string[] args)
        {
            JsonataEngine jsonata = new JsonataEngine();
            string result = jsonata.Execute("$.a", "{\"a\": \"b\"}");
            Debug.Assert(result == "\"b\"");
        }
    }
}
