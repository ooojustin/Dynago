using System;
using System.CodeDom.Compiler;
using System.IO;
using Microsoft.CSharp;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Reflection;

// Credits to Brian Ferguson (https://www.youtube.com/watch?v=j-loRgraJNo)
class Compiler
{ 
    public static List<string> Compile(string source, string output)
    {
        List<string> errorList = new List<string>();
        var results = CompileCsharpSource(new string[] { source }, output, new[] { "System.dll", "System.Core.dll" });
        if (results.Errors.Count == 0) return errorList;
        else
        {
            foreach (CompilerError error in results.Errors)
                errorList.Add(error.Line + ": " + error.ErrorText);
        }
        return errorList;
    }

    private static CompilerResults CompileCsharpSource(string[] sources, string output, params string[] references)
    {
        var parameters = new CompilerParameters(references, output);
        parameters.GenerateExecutable = true;
        parameters.CompilerOptions = "/platform:x86 /optimize- /unsafe";
        // ^ IMPORTANT!!! Compile as 32 bit (so we can access csgo modules) and DON'T OPTIMIZE! (more effective junk code)

        // modify.NET target version
        var providerOptions = new Dictionary<string, string>();
        providerOptions.Add("CompilerVersion", "v4.0");

        using (var provider = new CSharpCodeProvider(providerOptions))
            return provider.CompileAssemblyFromSource(parameters, sources);
    }
}