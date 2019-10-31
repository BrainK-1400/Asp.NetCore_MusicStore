using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MusicStore.Models;

namespace MusicStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly MyContext _myContext;

        public HomeController(MyContext myContext)
        {
            _myContext = myContext;
        }
        public async Task<IActionResult> Index()
        {
            var albums = await GetTopSellingAlbums(5);
            return View(albums);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        // Private Method(Temp)
        private Task<List<Album>> GetTopSellingAlbums(int counts)
        {
            return _myContext.Albums.OrderByDescending(a => a.OrderDetail.Count()).Take(counts).ToListAsync();
        }
    }
}
