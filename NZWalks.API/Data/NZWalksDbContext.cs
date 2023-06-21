﻿using Microsoft.EntityFrameworkCore;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Data
{
  public class NZWalksDbContext : DbContext
  {
    public NZWalksDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
    {
    }
    //Server=localhost;Database=master;Trusted_Connection=True;
    public DbSet<Difficulty> difficulties { get; set; }
    public DbSet<Region> Regions { get; set; }
    public DbSet<Walk> Walks { get; set; }

  }
}
