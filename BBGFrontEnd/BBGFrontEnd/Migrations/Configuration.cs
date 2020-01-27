namespace BBGFrontEnd.Migrations
{
    using BBGFrontEnd.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BBGFrontEnd.Models.BoardgameDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "BBGFrontEnd.Models.BoardgameDBContext";
        }

        protected override void Seed(BBGFrontEnd.Models.BoardgameDBContext context)
        {
            context.Boardgames.AddOrUpdate(i => i.ID,
                new Boardgame
                {
                    ID = 1,
                    Name = "Gloomhaven",
                    Description = "Gloomhaven is a game of Euro-inspired tactical combat in a persistent world of shifting motives. Players will take on the role of a wandering adventurer with their own special set of skills and their own reasons for traveling to this dark corner of the world. Players must work together out of necessity to clear out menacing dungeons and forgotten ruins. In the process, they will enhance their abilities with experience and loot, discover new locations to explore and plunder, and expand an ever-branching story fueled by the decisions they make.",
                    Category = GameCategory.Adventure,
                    MinPlayers = 2,
                    MaxPlayers = 4,
                    MinPlayTime = 60,
                    MaxPlayTime = 120,
                    MinAge = 12,
                    ThumbnailURL = "https://cf.geekdo-images.com/imagepage/img/-nnzXSm6wDQvH5lckCzUtaaprGE=/fit-in/900x600/filters:no_upscale()/pic2437871.jpg"
                },
                new Boardgame
                {
                    ID = 2,
                    Name = "Pandemic Legacy: Season 1",
                    Description = "Pandemic Legacy is a co-operative campaign game, with an overarching story-arc played through 12-24 sessions, depending on how well your group does at the game. At the beginning, the game starts very similar to basic Pandemic, in which your team of disease-fighting specialists races against the clock to travel around the world, treating disease hotspots while researching cures for each of four plagues before they get out of hand.",
                    Category = GameCategory.Strategy,
                    MinPlayers = 2,
                    MaxPlayers = 4,
                    MinPlayTime = 60,
                    MaxPlayTime = 60,
                    MinAge = 13,
                    ThumbnailURL = "https://cf.geekdo-images.com/imagepage/img/vuhGm0iS67iW8Z1019HsPmijRUU=/fit-in/900x600/filters:no_upscale()/pic2452831.png"
                },
                new Boardgame
                {
                    ID = 3,
                    Name = "Terraforming Mars",
                    Description = "In the 2400s, mankind begins to terraform the planet Mars. Giant corporations, sponsored by the World Government on Earth, initiate huge projects to raise the temperature, the oxygen level, and the ocean coverage until the environment is habitable. In Terraforming Mars, you play one of those corporations and work together in the terraforming process, but compete for getting victory points that are awarded not only for your contribution to the terraforming, but also for advancing human infrastructure throughout the solar system, and doing other commendable things.",
                    Category = GameCategory.Strategy,
                    MinPlayers = 1,
                    MaxPlayers = 5,
                    MinPlayTime = 120,
                    MaxPlayTime = 120,
                    MinAge = 12,
                    ThumbnailURL = "https://cf.geekdo-images.com/imagepage/img/sgZLoyg3KKeHvyHel8tZ2TIkXRw=/fit-in/900x600/filters:no_upscale()/pic3536616.jpg"
                },
                new Boardgame
                {
                    ID = 4,
                    Name = "Twilight Imperium (Fourth Edition)",
                    Description = "Twilight Imperium (Fourth Edition) is a game of galactic conquest in which three to six players take on the role of one of seventeen factions vying for galactic domination through military might, political maneuvering, and economic bargaining. Every faction offers a completely different play experience, from the wormhole-hopping Ghosts of Creuss to the Emirates of Hacan, masters of trade and economics. These seventeen races are offered many paths to victory, but only one may sit upon the throne of Mecatol Rex as the new masters of the galaxy.",
                    Category = GameCategory.Strategy,
                    MinPlayers = 3,
                    MaxPlayers = 6,
                    MinPlayTime = 240,
                    MaxPlayTime = 480,
                    MinAge = 14,
                    ThumbnailURL = "https://cf.geekdo-images.com/imagepage/img/XBGDkMsumi49GDTyFNXTj3OP9QQ=/fit-in/900x600/filters:no_upscale()/pic3727516.jpg"
                },
                new Boardgame
                {
                    ID = 5,
                    Name = "Star Wars: Rebellion",
                    Description = "Star Wars: Rebellion is a board game of epic conflict between the Galactic Empire and Rebel Alliance for two to four players. Experience the Galactic Civil War like never before.In Rebellion, you control the entire Galactic Empire or the fledgling Rebel Alliance.You must command starships, account for troop movements, and rally systems to your cause.Given the differences between the Empire and Rebel Alliance, each side has different win conditions, and you'll need to adjust your play style depending on who you represent.",
                    Category = GameCategory.Thematic,
                    MinPlayers = 2,
                    MaxPlayers = 4,
                    MinPlayTime = 180,
                    MaxPlayTime = 240,
                    MinAge = 14,
                    ThumbnailURL = "https://cf.geekdo-images.com/imagepage/img/tFfwdX2zyujVuYPFyvSiQwVV03Y=/fit-in/900x600/filters:no_upscale()/pic4325841.jpg"
                },
                new Boardgame
                {
                    ID = 6,
                    Name = "Spirit Island",
                    Description = "Spirit Island is a complex and thematic cooperative game about defending your island home from colonizing Invaders. Players are different spirits of the land, each with its own unique elemental powers. Every turn, players simultaneously choose which of their power cards to play, paying energy to do so. Using combinations of power cards that match a spirit's elemental affinities can grant free bonus effects. Faster powers take effect immediately, before the Invaders spread and ravage, but other magics are slower, requiring forethought and planning to use effectively. In the Spirit phase, spirits gain energy, and choose how / whether to Grow: to reclaim used power cards, to seek for new power, or to spread presence into new areas of the island.",
                    Category = GameCategory.Fantasy,
                    MinPlayers = 1,
                    MaxPlayers = 4,
                    MinPlayTime = 90,
                    MaxPlayTime = 120,
                    MinAge = 13,
                    ThumbnailURL = "https://cf.geekdo-images.com/imagepage/img/q_b5Jw43Tnyw3hT8l2zMKmLOPvU=/fit-in/900x600/filters:no_upscale()/pic3615739.png"
                },
                new Boardgame
                {
                    ID = 7,
                    Name = "Concordia ",
                    Description = "Concordia is a peaceful strategy game of economic development in Roman times for 2-5 players aged 13 and up. Instead of looking to the luck of dice or cards, players must rely on their strategic abilities. Be sure to watch your rivals to determine which goals they are pursuing and where you can outpace them! In the game, colonists are sent out from Rome to settle down in cities that produce bricks, food, tools, wine, and cloth. Each player starts with an identical set of playing cards and acquires more cards during the game.",
                    Category = GameCategory.Economic,
                    MinPlayers = 2,
                    MaxPlayers = 5,
                    MinPlayTime = 100,
                    MaxPlayTime = 100,
                    MinAge = 13,
                    ThumbnailURL = "https://cf.geekdo-images.com/imagepage/img/RGEIRpbvMY1wk3oo7W5YxRluPO8=/fit-in/900x600/filters:no_upscale()/pic3453267.jpg"
                }
           );
        }
    }
}
