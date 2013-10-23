using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace MyToDoList.Models
{
    public class Item
    {
        public int ID { get; set; }
        
        [Required]
        public string Title { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        
        [DataType(DataType.DateTime)]
        public DateTime Deadline { get; set; }
        
        public bool Complete { get; set; }
    }
    public class MyToDoListDBContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
    }

} // end