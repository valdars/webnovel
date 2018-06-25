using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lib.Models
{
    public class Volume
    {
        public string Index { get; private set; }
        public string Name { get; private set; }
        public int ChapterCount { get; private set; }
        public IEnumerable<Chapter> Chapters;

        public Volume(JToken data)
        {
            Index = (string)data["index"];
            Name = (string)data["name"];
            ChapterCount = (int)data["chapterCount"];
            Chapters = ((JArray)data["chapterItems"]).Select(x => new Chapter(x));
        }
    }
}
