using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xamarin.Forms;

[assembly: Dependency(typeof(Study3XFBA.SaveAndLoad))]
namespace Study3XFBA
{
    
    public interface ISaveAndLoad
    {
        void Save(string filename, Json_Model json_Model);
        Json_Model Load(string filename);
    }

    public class SaveAndLoad : ISaveAndLoad
    {
        public void Save(string filename, Json_Model json_Model)
        {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var filePath = Path.Combine(documentsPath, filename);

           var jsonString = JsonConvert.SerializeObject(json_Model).ToString();
          System.IO.File.WriteAllText(filePath, jsonString);
        }

        // System.IO.File.WriteAllText(filePath, text);
    
        public Json_Model Load(string filename)
        {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var filePath = Path.Combine(documentsPath, filename);

            var fileContent = System.IO.File.ReadAllText(filePath);

            var json_Model = JsonConvert.DeserializeObject<Json_Model>(fileContent);

            return json_Model;
           
        }
    }
}
