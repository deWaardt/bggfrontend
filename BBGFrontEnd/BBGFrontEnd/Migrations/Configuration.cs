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
                    Description = "De spellen-specialist van Amsterdam.",
                    Address = "Hartenstraat 14",
                    Location = "Amsterdam",
                    Phone = 0206381579,
                    OpenTime = new DateTime(2020, 1, 1, 10, 0, 0),
                    CloseTime = new DateTime(2020, 1, 1, 18, 0, 0),
                    OpenDays = new List<bool> { true, true, true, true, true, true, true }

                },

                new Shop
                {
                    ID = 2,
                    Name = "De Dobbelsteen",
                    Description = "De Dobbelsteen is een spellenspeciaalzaak met een zeer ruim assortiment aan bord- en kaartspellen. Daarnaast hebben we voor al deze spellen ook regelmatig activiteiten en toernooien.",
                    Address = "Schouwburgring 141",
                    Location = "Tilburg",
                    Phone = 0263702028,
                    OpenTime = new DateTime(2020, 1, 1, 9, 0, 0),
                    CloseTime = new DateTime(2020, 1, 1, 17, 0, 0),
                    OpenDays = new List<bool> { true, true, true, true, true, false, false }

                }

           );
        }
    }
}
