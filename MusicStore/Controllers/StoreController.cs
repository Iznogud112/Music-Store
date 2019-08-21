using MusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicStore.Controllers
{
    public class StoreController : Controller
    {
        MusicStoreDb db = new MusicStoreDb();

        // GET: Store
        public ActionResult Index()
        {
            var genre = db.Genres.ToList();

            return View(genre);
        }

        //GET: Store/Browse?genre=
        public ActionResult Browse(string genre)
        {
            var browse = db.Genres.Include("Albums").Single(g => g.Name == genre);

            return View(browse);
        }

        //GET: Store/Details/id
        public ActionResult Details(int id)
        {
            var album = db.Albums.Find(id);

            return View(album);
        }

        // GET: /Store/GenreMenu
        [ChildActionOnly]
        public ActionResult GenreMenu()
        {
            var genres = db.Genres.ToList();
            return PartialView(genres);
        }
    }
}