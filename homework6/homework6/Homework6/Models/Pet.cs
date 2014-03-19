using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace Homework6.Models
{
    public class Pet
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string DescriptionShort{ get; set; }
        public string DescriptionLong { get; set; }
        public DateTime DateReceived { get; set; }
        [Display(Name = "Date Received")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode =true )]
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
    public class PetDBContext : DbContext
    {
        public DbSet<Pet> Pets { get; set; }
    }
}