namespace BBGFrontEnd.Migrations
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using BGGConnectorLib;
    using System.Net;

    internal sealed class Configuration : DbMigrationsConfiguration<Models.BoardgameDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "BBGFrontEnd.Models.BoardgameDBContext";
        }

        protected override void Seed(Models.BoardgameDBContext context)
        {
            // Oplossing voor een bug in WebClient (wordt gebruikt door BGGConnectorLib).
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            var ids = Enumerable.Range(1, 50).ToArray();
            var things = BGGConnector.GetThings(ids);
            var boardgames = things.Items.Select(item => new Models.Boardgame
            {
                ID = item.Id,
                Name = item.Names.Where(name => name.Type == "primary").FirstOrDefault().Value,
                Description = item.Description,
                Category = item.Links.Where(link => link.Type == "boardgamecategory").FirstOrDefault().Value,
                MinPlayers = item.MinPlayers == null ? 0 : item.MinPlayers.Value,
                MaxPlayers = item.MaxPlayers == null ? 0 : item.MaxPlayers.Value,
                MinPlayTime = item.MinPlaytime == null ? 0 : item.MinPlaytime.Value,
                MaxPlayTime = item.MaxPlaytime == null ? 0 : item.MaxPlaytime.Value,
                MinAge = item.MinAge == null ? 0 : item.MinAge.Value,
                ThumbnailURL = item.Thumbnail,
            });

            context.Boardgames.AddOrUpdate(i => i.ID, boardgames.ToArray());
        }
    }
}
