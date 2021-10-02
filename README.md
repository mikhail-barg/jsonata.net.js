# jsonata.net.js
.Net implementation of JSONata query and transformation language (http://jsonata.org)

This is a C# wrapper over the `jsonata-es5.min.js` imported from [jsonata-c](https://github.com/qlyoung/jsonata-c/blob/master/src/jsonata-es5.min.js) repo by [qlyoung](https://github.com/qlyoung).
Which itself is a minimized/compiled version of original [JSONata js files](https://github.com/jsonata-js/jsonata). It's current version is 1.8.3.

The wrapper uses [Jint](https://github.com/sebastienros/jint) JS Engine for C#. 
Because this package does C#-JS interop, it's expected to be rather slow. I'm working on C#-native implementation of the engine.

[**Usage**](https://github.com/mikhail-barg/jsonata.net.js/blob/3563e702102cf675a63a048aaa5c9bb7c0fafc70/src/Jsonata.Net.TestApp/Program.cs#L12)
```
using Jsonata.Net.Js;
...
JsonataEngine jsonata = new JsonataEngine();
...
string result = jsonata.Execute("$.a", "{\"a\": \"b\"}");
Debug.Assert(result == "\"b\"");
```


