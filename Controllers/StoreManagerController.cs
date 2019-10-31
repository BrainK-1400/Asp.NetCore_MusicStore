using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MusicStore.Models;

namespace MusicStore.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class StoreManagerController : Controller
    {
        private readonly MyContext _myContext;

        // GET: StoreManager
        public StoreManagerController(MyContext myContext)
        {
            _myContext = myContext;
        }
        public ActionResult Index()
        {
            var albums = _myContext.Albums.Include("Genre").Include("Artist");
            return View(albums.ToList());
        }

        // GET: StoreManager/Details/5
        public ActionResult Details(int id)
        {
            var album = _myContext.Albums.Find(id);
            var artist = _myContext.Artists;
            var genre = _myContext.Genres;
            ViewBag.Genre = genre.Find(album.GenreId).Name;
            ViewBag.Artist = artist.Find(album.ArtistId).Name;
            return View(album);
        }

        // GET: StoreManager/Create
        public ActionResult Create()
        {
            ViewBag.GenreId = new SelectList(_myContext.Genres, "GenreId", "Name");
            ViewBag.ArtistId = new SelectList(_myContext.Artists, "ArtistId", "Name");
            return View();
        }

        // POST: StoreManager/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Album album)
        {
            try
            {
                _myContext.Albums.Add(album);
                _myContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StoreManager/Edit/5
        public ActionResult Edit(int id)
        {
            var album = _myContext.Albums.Find(id);
            ViewBag.GenreId = new SelectList(_myContext.Genres, "GenreId", "Name", album.GenreId);
            ViewBag.ArtistId = new SelectList(_myContext.Artists, "ArtistId", "Name", album.ArtistId);
            return View(album);
            
        }

        // POST: StoreManager/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult  Edit(int id, Album album)
        {
            try
            {
                _myContext.Albums.Update(album);
                _myContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StoreManager/Delete/5
        public ActionResult Delete(int id)
        {
            var album = _myContext.Albums.Find(id);
            return View(album);
        }

        // POST: StoreManager/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                var album = _myContext.Albums.Remove(_myContext.Albums.Find(id));
                _myContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}