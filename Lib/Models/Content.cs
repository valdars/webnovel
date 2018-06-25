using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lib.Models
{
    public class Content
    {
        public string ChapterId { get; private set; }
        public string Name { get; private set; }
        public int Index { get; private set; }
        public string PreviousChapterId { get; private set; }
        public string NextChapterId { get; private set; }
        public int IsVip { get; private set; }
        public string Text { get; private set; }
        public int OrderIndex { get; private set; }

        public Content(JToken data)
        {
            ChapterId = (string)data["chapterId"];
            Name = (string)data["chapterName"];
            Index = (int)data["chapterIndex"];
            PreviousChapterId = (string)data["preChapterId"];
            NextChapterId = (string)data["nextChapterId"];
            IsVip = (int)data["isVip"];
            Text = (string)data["content"];
            OrderIndex = (int)data["orderIndex"];
        }
    }
}
