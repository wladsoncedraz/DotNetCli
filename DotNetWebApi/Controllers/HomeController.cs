using Microsoft.AspNetCore.Mvc;

namespace DotNetWebApi.Controllers
{
    public class HomeController: Controller
    {
        [HttpGet("/")]
        public string SayHey(){
            return "Hey, world!";
        }
    }
}