namespace BBGFrontEnd.Migrations
{
    using BBGFrontEnd.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BBGFrontEnd.Models.ShopDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BBGFrontEnd.Models.ShopDBContext context)
        {
            context.Shops.AddOrUpdate(i => i.ID,
                new Shop
                {
                    ID = 1,
                    Name = "The Gamekeeper",
                    Description = "The Gamekeeper is de spellen-specialist van Amsterdam. Op onze site kan je van alles vinden over ons assortiment en natuurlijk waar je ons kan vinden. Spellen binnen ons assortiment kan je vinden in onze webshop.",
                    Address = "Hartenstraat 14",
                    Location = "Amsterdam",
                    Phone = 0206381579,
                    OpenTime = new DateTime(2020, 1, 1, 10, 0, 0),
                    CloseTime = new DateTime(2020, 1, 1, 18, 0, 0),
                    OpenDays = new List<bool> { true, true, true, true, true, true, true },
                    WebsiteUrl = "https://www.gamekeeper.nl",
                    ImageUrl = "https://www.gamekeeper.nl/wp-content/uploads/2018/02/The-Gamekeeper.jpg"
                },

                new Shop
                {
                    ID = 2,
                    Name = "De Dobbelsteen",
                    Description = "De Dobbelsteen is een spellenspeciaalzaak met een zeer ruim assortiment aan bord- en kaartspellen. Daarnaast hebben we voor al deze spellen ook regelmatig activiteiten en toernooien.",
                    Address = "Schouwburgring 141",
                    Location = "Tilburg",
                    Phone = 0135443700,
                    OpenTime = new DateTime(2020, 1, 1, 9, 0, 0),
                    CloseTime = new DateTime(2020, 1, 1, 17, 0, 0),
                    OpenDays = new List<bool> { true, true, true, true, true, false, false },
                    WebsiteUrl = "https://www.dedobbelsteen.com/",
                    ImageUrl = "https://www.centrumtilburg.com/wp-content/uploads/2015/08/20160609_Schouwburgring141_BasHaansFotografie_BHF154-887x476.jpg"
                },

                new Shop
                {
                    ID = 3,
                    Name = "Vlieg er uit",
                    Description = "Vlieg-er-uit bestaat al meer dan 23 jaar begonnen als echte vliegerwinkel, maar al heel gauw uitgebreid naar vele andere leuke hobby's zoals, Games, Bordspellen, Warhammer, Magic the Gathering, Yoyo's, Jongleren, Goochelen en nog vele andere.",
                    Address = "Brusselsestraat 70",
                    Location = "Maastricht",
                    Phone = 0433251653,
                    OpenTime = new DateTime(2020, 1, 1, 13, 0, 0),
                    CloseTime = new DateTime(2020, 1, 1, 18, 0, 0),
                    OpenDays = new List<bool> { true, true, true, true, true, true, false },
                    WebsiteUrl = "https://www.vliegeruit.com",
                    ImageUrl = "https://i.pinimg.com/736x/1f/33/94/1f3394025173d0c8e1135a734a08403d.jpg"
                },

                new Shop
                {
                    ID = 4,
                    Name = "Subcultures",
                    Description = "For us, playing games is the best thing out there. Even when you lose. In our store we have hundreds of games, for young and old, experts and beginners. We’d love to help you find something you like!",
                    Address = "Oudegracht 183",
                    Location = "Utrecht",
                    Phone = 0307371007,
                    OpenTime = new DateTime(2020, 1, 1, 11, 0, 0),
                    CloseTime = new DateTime(2020, 1, 1, 18, 0, 0),
                    OpenDays = new List<bool> { true, true, true, true, true, false, false },
                    WebsiteUrl = "https://www.subcultures.nl",
                    ImageUrl = "https://www.subcultures.nl/wp-content/uploads/2017/01/Welcome-at-subcultures.jpg"
                }

           );
        }
    }
}
