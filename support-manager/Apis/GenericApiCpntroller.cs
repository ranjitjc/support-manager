using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.Data.Entity;
// using MusicStore.Models;
// using MusicStore.Infrastructure;

namespace support_manager.Apis
{
    [Route("api/generic")]
    public class GenericApiController : Controller
    {
        // private readonly MusicStoreContext _storeContext;

        // public GenresApiController(MusicStoreContext storeContext)
        // {
        //     _storeContext = storeContext;
        // }

        [HttpGet]
        public IActionResult GenericList()
        {
            string[] items = {
            "Responsive Web App boilerplate",
            "Iron Elements and Paper Elements",
            "End-to-end Build Tooling (including Vulcanize)",
            "Unit testing with Web Component Tester",
            "Routing with Page.js",
            "Offline support with the Platinum Service Worker Elements"
            };
            
            // var genres = await items.
            //     //.Include(g => g.Albums)
            //     .OrderBy(g => g.Name)
            //     .ToListAsync();

            return Json(items);
        }
    }
}