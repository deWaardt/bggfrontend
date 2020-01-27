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
        public ActionResult Index(GameCategory? category, int? players, int? age, int? playtime)
        {
            var CategoryList = new List<GameCategory>();
            var CategoryQry = from c in db.Boardgames
                              orderby c.Category
                              select c.Category;
            CategoryList.AddRange(CategoryQry.Distinct());

            var PlayersList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var AgeList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };
            var PlaytimeList = new List<int> { 15, 30, 45, 60, 75, 90, 105, 120, 135, 150, 165, 180, 195, 210, 225, 240 };

            ViewBag.category = new SelectList(CategoryList);
            ViewBag.players = new SelectList(PlayersList);
            ViewBag.age = new SelectList(AgeList);
            ViewBag.playtime = new SelectList(PlaytimeList);

            var games = from g in db.Boardgames
                        select g;

            if (!String.IsNullOrEmpty(category.ToString()))
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
