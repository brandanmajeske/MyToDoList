namespace MyToDoList.Migrations
{
    using MyToDoList.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MyToDoList.Models.MyToDoListDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MyToDoList.Models.MyToDoListDBContext context)
        {
            context.Items.AddOrUpdate( i => i.Title,
            new Item 
            {
                Title = "C# Training",
                Description = "Learn C# for use with the ASP.NET framework.",
                Deadline = DateTime.Parse("12/1/2013"),
                Complete = false
            }
            );
        }
    }
}
