using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HundDataAPI.Controllers
{
    public class HundarController : Controller
    {

        [HttpGet]
        [ValidateAntiForgeryToken]
        public string Get(int id, IFormCollection collection)
        {

        }
    }
}
