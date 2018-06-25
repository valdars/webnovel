using Lib.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace Lib
{
    public class Webnovels
    {
        private string _csrf;
        private HttpClient _httpClient;

        public Webnovels(string csrf, HttpClient httpClient)
        {
            _csrf = csrf;
            SetupHttpClient(httpClient);
        }

        private void SetupHttpClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        private string CreateUrl(string path, params (string, string)[] args)
        {
            var baseurl = "https://www.webnovel.com/apiajax/chapter/";
            var argList = new List<(string, string)>(args);
            argList.Add(("_csrfToken", _csrf));
            var argsString = String.Join("&", argList.Select(x => x.Item1 + "=" + x.Item2));
            var url = String.Format("{0}{1}?{2}", baseurl, path, argsString);
            return url;
        }

        public async void GetChapterList(string bookId)
        {
            var url = CreateUrl("GetChapterList", ("bookId", bookId));
            var result = await _httpClient.GetStringAsync(url);
            var obj = JObject.Parse(result);
            if((int)obj["code"] == 0)
            {
                var bookinfo = new BookInfo((JObject)obj["data"]["bookInfo"]);
                var volumes = ((JArray)obj["data"]["volumeItems"]).Select(x => new Volume(x));
            }
            var t = url;
        }
    }
}
