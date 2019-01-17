using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyAzureWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var account = CloudStorageAccount.Parse(@"DefaultEndpointsProtocol=https;AccountName=pierrestoragetest;AccountKey=8OBdp85+f+p3zZOJEqPKeO7BUCV42gJ7MqUhiWCpYheOnlr92Ag3SatcrALHmRPg2LvsKXbWYqv7J/x3dRbJTQ==;EndpointSuffix=core.windows.net");
            var container = account.CreateCloudBlobClient().GetContainerReference("cats");
            var blobs = container.ListBlobs().OfType<CloudBlockBlob>().ToList();
            return View(blobs);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}