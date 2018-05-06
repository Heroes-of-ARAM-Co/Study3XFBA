using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace Study3XFBA
{
    class FileIO
    {
        public string test() { 
        var assembly = IntrospectionExtensions.GetTypeInfo(typeof(FileIO)).Assembly;
        Stream stream = assembly.GetManifestResourceStream("Study3XFBA.test.txt");
        string text = "";
            using (var reader = new System.IO.StreamReader(stream))
            {
                text = reader.ReadToEnd();
            }
            return text;
        }
   

        public string test(string text)
        {
            var assembly = IntrospectionExtensions.GetTypeInfo(typeof(FileIO)).Assembly;
            Stream stream = assembly.GetManifestResourceStream("Study3XFBA.test.txt");
         
            using (var reader = new StreamWriter(stream))
            {
                reader.WriteLine(text+"|||||NEWINPUT||||||");
            }
            return text;
        }
    }
}
