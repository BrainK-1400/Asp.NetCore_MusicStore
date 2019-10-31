using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MusicStore.Models;

namespace MusicStore.Controllers
{
    public class StoreController : Controller
    {
        private readonly MyContext _myContext;

        public StoreController(MyContext myContext)
        {
            _myContext = myContext;
        }
        public async Task<IActionResult> Index()
        {
            var Genres = await _myContext.Genres.ToListAsync();
            return View(Genres);
                    
        }
        public async Task<IActionResult> Browse(int genreId)
        {
            var genreModel =await  _myContext.Genres.Include("Albums").SingleAsync(g => g.GenreId == genreId);
            return View(genreModel);

        }
        public IActionResult Details(int id)
        {
            var album = _myContext.Albums.Find(id);
            var artist = _myContext.Artists;
            var genre = _myContext.Genres;
            ViewBag.GenreName = genre.Find(album.GenreId).Name;
            ViewBag.ArtistName = artist.Find(album.ArtistId).Name;
            return View(album);
        }
        
        
    }
}