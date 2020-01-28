using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BGGConnectorLib;

namespace BBGFrontEnd.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        public ActionResult GamePage(string ID = "1")
        {
            try
            {
                BGGConnectorLib.XMLModels.Things Game = BGGConnectorLib.BGGConnector.GetThings(new int[] { Int32.Parse(ID) });


                foreach (var item in Game.Items)
                {



                    Console.WriteLine("=========================");
                    Console.WriteLine($"ID: {item.Id}");
                    ViewData["Description"] = item.Description;
                    Console.WriteLine($"Type: {item.Type}");
                    //ViewData["Image"] = item.Thumbnail;
                    ViewData["Image"] = item.Image;
                    Debug.WriteLine(ViewData["Image"]);

                    foreach (var name in item.Names)
                    {
                        if (name.Type == "primary")
                        {
                            ViewData["GameName"] = name.Value;
                        }
                    }

                    Console.WriteLine($"Year Published: {item.YearPublished.Value}");
                    Console.WriteLine($"Min Players: {item.MaxPlayers.Value}");
                    Console.WriteLine($"Max Players: {item.MinPlayers.Value}");
                    Console.WriteLine($"Playing Time: {item.PlayingTime.Value}");
                    Console.WriteLine($"Min Playtime: {item.MinPlaytime.Value}");
                    Console.WriteLine($"Max Playtime: {item.MaxPlaytime.Value}");
                    Console.WriteLine($"Min Age: {item.MinAge.Value}");

                    foreach (var poll in item.Polls)
                    {
                        Console.WriteLine($"Poll: {poll.Name} {poll.Title} {poll.TotalVotes} ({poll.Results.Length} poll results)");
                    }

                    foreach (var link in item.Links)
                    {
                        Console.WriteLine($"Link: {link.Type} {link.Id} {link.Value}");
                    }
                }
            }
            catch (Exception E) { return null; }

            return View();
        }
    }
}