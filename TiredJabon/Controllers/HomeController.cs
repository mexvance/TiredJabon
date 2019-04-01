using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TiredJabon.Models;

namespace TiredJabon.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var request1 = GetReleases("https://opinionated-quotes-api.gigalixirapp.com/v1/quotes?tags=short&tmode=all");

            //var memes = JObject.Parse(request);
            var jObject = JObject.Parse(request1);
            var text0 = (string)jObject["quotes"][0]["quote"];
        /*ViewData["memes"] =*/
        //var data = (Memes)JsonConvert.DeserializeObject<Memes>((string)jObject["data"]["memes"]);
        /*Random rand = new Random();
        int num = rand.Next(jObject["quotes"]["quote"]);
        ViewData["memes"]= (string)jObject["data"]["memes"][num]["name"];
        ViewData["url"] = (string)jObject["data"]["memes"][num]["url"];*/
        //ViewData["memes"] = request;
        var url = "https://api.imgflip.com/caption_image?template_id=129242436&username=mexvance&password=Restapi1&text0="+ text0;
            var request = GetReleases(url);
            jObject = JObject.Parse(request);
            ViewData["url"] = (string)jObject["data"]["url"];
            return View();

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public string GetReleases(string url)
        {
            var client = new WebClient();
            //client.Headers.Add(RequestConstants.UserAgent, RequestConstants.UserAgentValue);

            var response = client.DownloadString(url);

            return response;
        }
    }
}
