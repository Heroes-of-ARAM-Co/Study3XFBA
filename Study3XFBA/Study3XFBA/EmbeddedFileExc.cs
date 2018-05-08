using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;


namespace Study3XFBA
{
    public class EmbeddedFileExc
    {
        public string FileExcerciseM()
        {
            var assembly = IntrospectionExtensions.GetTypeInfo(typeof(EmbeddedFileExc)).Assembly;
            Stream stream = assembly.GetManifestResourceStream("Study3XFBA.tuRobieDupe.txt");
            string text = "";
            
            string newtext = "tu nowy tekst";
            using (var writer = new StreamWriter(stream))
            {
                writer.WriteLine(newtext);
            }
            using (var reader = new System.IO.StreamReader(stream))
            {
                text = reader.ReadToEnd();

            }
            return text;
        }
    }
}