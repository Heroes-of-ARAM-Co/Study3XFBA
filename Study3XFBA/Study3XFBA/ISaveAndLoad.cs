using System;
using System.Collections.Generic;
using System.Text;

namespace Study3XFBA
{
    public interface ISaveAndLoad
    {
        void SaveText(string filename, string text);
        string LoadText(string filename);
    }
}
