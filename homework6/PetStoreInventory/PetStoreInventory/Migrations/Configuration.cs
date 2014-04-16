namespace PetStoreInventory.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using PetStoreInventory.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<PetStoreInventory.Models.PetDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PetStoreInventory.Models.PetDBContext context)
        {
            context.Pets.AddOrUpdate(i => i.Name,
                new Pet
                {
                     ID = 1609786,
                     Name = "Rusty",
                     FDescription = "He is an Irish Setter",
                     PDescription = "Setter",
                     DateReceived = DateTime.Parse("1999-5-7"),
                     Quantity = 2,
                     Price = 299.99M
                },

                 new Pet
                 {
                     ID = 1609786,
                     Name = "Rusty",
                     FDescription = "He is an Irish Setter",
                     PDescription = "Setter",
                     DateReceived = DateTime.Parse("1999-5-7"),
                     Quantity = 2,
                     Price = 299.99M
                 },

                 new Pet
                 {
                     ID = 1609786,
                     Name = "Rusty",
                     FDescription = "He is an Irish Setter",
                     PDescription = "Setter",
                     DateReceived = DateTime.Parse("1999-5-7"),
                     Quantity = 2,
                     Price = 299.99M
                 },

               new Pet
               {
                   ID = 1609786,
                   Name = "Rusty",
                   FDescription = "He is an Irish Setter",
                   PDescription = "Setter",
                   DateReceived = DateTime.Parse("1999-5-7"),
                   Quantity = 2,
                   Price = 299.99M
               }
           );
        }
    }
}
