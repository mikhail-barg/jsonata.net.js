using System;
using System.IO;
using System.Reflection;
using Jint;
using Jint.Native;

namespace Jsonata.Net.Js
{
    public sealed class JsonataEngine
    {
        private const string RESOURCE_NAME = "Jsonata.Net.Js.jsonata-es5.min.js";

        private readonly JsValue m_func;

        public JsonataEngine()
        {
            Assembly assembly = typeof(JsonataEngine).Assembly;
            string jsonata_js;
            using (StreamReader reader = new StreamReader(assembly.GetManifestResourceStream(RESOURCE_NAME)))
            {
                jsonata_js = reader.ReadToEnd();
            };

            Engine engine = new Engine()
                .Execute(jsonata_js)
                .Execute("function main_func(query, data_json) { return JSON.stringify(jsonata(query).evaluate(JSON.parse(data_json))); };")
            ;
            this.m_func = engine.GetValue("main_func");
        }

        public string Execute(string query, string jsonData)
        {
            JsValue result = this.m_func.Invoke(query, jsonData);
            return result.ToObject()?.ToString();
        }
    }
}
