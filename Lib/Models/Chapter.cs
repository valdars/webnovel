using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lib.Models
{
    public class Chapter
    {
        public string Id { get; private set; }
        public string Name { get; private set; }
        public int Index { get; private set; }
        public int IsVip { get; private set; }
        public string Source { get; private set; }
        public int FeeType { get; private set; }

        public Chapter(JToken data)
        {
            Id = (string)data["id"];
            Name = (string)data["name"];
            Index = (int)data["index"];
            IsVip = (int)data["isVip"];
            Source = (string)data["source"];
            FeeType = (int)data["feeType"];
        }
    }
}
