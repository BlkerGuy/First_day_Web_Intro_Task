using Microsoft.AspNetCore.Mvc;

namespace First_day_Web_Intro_Task.Controllers
{
    public class HomeController : Controller
    {

        public ViewResult Index()
        {
            ViewResult viewResult = new ViewResult();
            viewResult.ViewName = "test";
            return viewResult;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

        //public string Index()
        //{
        //    return "Main Page";
        //}

        public JsonResult About()
        {
            JsonResult json = new JsonResult("About Page");
            json.StatusCode = 200;
            return json;
        }
        public ContentResult Blog()
        {
            ContentResult contentResult=new ContentResult();
            contentResult.Content = "Blog Page Just Test";
            contentResult.ContentType = "test";

            return contentResult;
        }

    }
}
