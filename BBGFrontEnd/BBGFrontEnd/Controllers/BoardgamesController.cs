using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BBGFrontEnd.Models;

namespace BBGFrontEnd.Controllers
{
    public class BoardgamesController : Controller
    {
        private BoardgameDBContext db = new BoardgameDBContext();

        // GET: Boardgames
        public ActionResult Index(int? players, int? age, int? playtime, bool? exact, string category = "", string query = "")
        {
            var CategoryList = db.Boardgames.Select(game => game.Category).Distinct();
            var PlayersList = db.Boardgames.SelectMany(game => new int[] { game.MinPlayers, game.MaxPlayers }).Distinct();
            var AgeList = db.Boardgames.Select(game => game.MinAge).Distinct();
            var PlaytimeList = db.Boardgames.SelectMany(game => new int[] { game.MinPlayTime, game.MaxPlayTime }).Distinct();

            ViewBag.category = new SelectList(CategoryList);
            ViewBag.players = new SelectList(PlayersList);
            ViewBag.age = new SelectList(AgeList);
            ViewBag.playtime = new SelectList(PlaytimeList);
            ViewBag.exact = exact;
            ViewBag.query = query;

            var games = from g in db.Boardgames select g;

            if (query != "")
            {
                if (exact == true)
                {
                    games = games.Where(game => game.Name == query);
                }
                else
                {
                    games = games.Where(game => game.Name.Contains(query));
                }
            }
            if (category != "")
            {
                games = games.Where(s => s.Category == category);
            }

            if (players != null)
            {
                games = games.Where(s => s.MinPlayers <= players).Where(s => s.MaxPlayers >= players);
            }

            if (age != null)
            {
                games = games.Where(s => s.MinAge <= age);
            }

            if (playtime != null)
            {
                games = games.Where(s => s.MinPlayTime <= playtime).Where(s => s.MaxPlayTime >= playtime);
            }

            return View(games);
        }

        // GET: Boardgames/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Boardgame boardgame = db.Boardgames.Find(id);
            if (boardgame == null)
            {
                return HttpNotFound();
            }
            return View(boardgame);
        }

        // GET: Boardgames/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Boardgames/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Description,Category,MinPlayers,MaxPlayers,PlayTime,MinAge,ThumbnailURL")] Boardgame boardgame)
        {
            if (ModelState.IsValid)
            {
                db.Boardgames.Add(boardgame);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(boardgame);
        }

        // GET: Boardgames/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Boardgame boardgame = db.Boardgames.Find(id);
            if (boardgame == null)
            {
                return HttpNotFound();
            }
            return View(boardgame);
        }

        // POST: Boardgames/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Description,Category,MinPlayers,MaxPlayers,PlayTime,MinAge,ThumbnailURL")] Boardgame boardgame)
        {
            if (ModelState.IsValid)
            {
                db.Entry(boardgame).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(boardgame);
        }

        // GET: Boardgames/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Boardgame boardgame = db.Boardgames.Find(id);
            if (boardgame == null)
            {
                return HttpNotFound();
            }
            return View(boardgame);
        }

        // POST: Boardgames/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Boardgame boardgame = db.Boardgames.Find(id);
            db.Boardgames.Remove(boardgame);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
