﻿using Microsoft.Data.Entity;

namespace HomeWorld.Tracker.Web.Models
{
    public class TrackerDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
           base.OnModelCreating(builder);

            ConfigureEntities.ConfigurePerson(builder);
            ConfigureEntities.ConfigureCard(builder);
            ConfigureEntities.ConfigurePersonCard(builder);
        }

        public DbSet<Person> Person { get; set; }
        public DbSet<Card> Card { get; set; }
        public DbSet<PersonCard> PersonCard { get; set; }
    }
}