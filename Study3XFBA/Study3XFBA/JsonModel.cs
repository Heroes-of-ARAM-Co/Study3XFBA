using System;
using System.Collections.Generic;
using System.Text;

namespace Study3XFBA
{
    public class JsonModel
    {
        public string Title { get; set; }
        public int Id { get; set; }
        public List<SampleNode> ListOfSampleNodes {get;set;}
    }
    public class SampleNode
    {
        public string Properties { get; set; }
    }
}
