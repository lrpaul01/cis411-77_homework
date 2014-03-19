using System;
using System.Data.Entity;
namespace PetStore.Models
{
    public class Pet
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string FDescription { get; set; }
        public string PDescription { get; set; }
        public DateTime DateReceived { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }

    public class PetDBContext : DbContext
    {
        public DbSet<Pet> Pets { get; set; }
    }
}