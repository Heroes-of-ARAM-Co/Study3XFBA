using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;
using Xamarin.Forms;

[assembly: Dependency(typeof(Study3XFBA.SaveAndLoad))]
namespace Study3XFBA
{
    public interface ISaveAndLoad
    {
        void Save(string filename, JsonModel text);
        JsonModel Load(string filename);
    }
  

        public class SaveAndLoad : ISaveAndLoad
        {
            public void Save(string filename, JsonModel jsonModel)
            {
                var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                var filePath = Path.Combine(documentsPath, filename);
                var jsonInString =JsonConvert.SerializeObject(jsonModel).ToString();
                System.IO.File.WriteAllText(filePath, jsonInString);
            }
            public JsonModel Load(string filename)
            {
              var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
              var filePath = Path.Combine(documentsPath, filename);
              var text = System.IO.File.ReadAllText(filePath);
              var textInJson =  JsonConvert.DeserializeObject<JsonModel>(text);
              return textInJson;
        }
        }


 
    
}
