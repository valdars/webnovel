using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lib.Models
{
    public class BookInfo
    {
        public string Id { get; private set; }
        public string Name { get; private set; }
        public int ChapterCount { get; private set; }

        public BookInfo(JObject data)
        {
            Id = (string)data["bookId"];
            Name = (string)data["bookName"];
            ChapterCount = (int)data["totalChapterNum"];
        }
    }
}
