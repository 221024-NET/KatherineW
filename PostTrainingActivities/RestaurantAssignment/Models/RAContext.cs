using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace RestaurantAssignment.Models;

public partial class RAContext : DbContext
{
    public RAContext()
    {
    }

    public RAContext(DbContextOptions<RAContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cuisine> Cuisines { get; set; }

    public virtual DbSet<MenuItem> MenuItems { get; set; }

    public virtual DbSet<Restaurant> Restaurants { get; set; }

    public virtual DbSet<RestaurantCuisine> RestaurantCuisines { get; set; }

    public virtual DbSet<RestaurantMenu> RestaurantMenus { get; set; }

    public virtual DbSet<Score> Scores { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:RestaurantAssignment");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cuisine>(entity =>
        {
            entity.HasKey(e => e.CuisineId).HasName("PK__Cuisines__0CF23CCA1DD38816");

            entity.Property(e => e.CuisineId).HasColumnName("cuisineId");
            entity.Property(e => e.CuisineName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("cuisineName");
        });

        modelBuilder.Entity<MenuItem>(entity =>
        {
            entity.HasKey(e => e.MenuItemId).HasName("PK__MenuItem__682A1068F3FF11EF");

            entity.Property(e => e.MenuItemId).HasColumnName("menuItemId");
            entity.Property(e => e.ItemName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("itemName");
            entity.Property(e => e.MenuCuisine).HasColumnName("menuCuisine");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("price");

            entity.HasOne(d => d.MenuCuisineNavigation).WithMany(p => p.MenuItems)
                .HasForeignKey(d => d.MenuCuisine)
                .HasConstraintName("FK__MenuItems__menuC__19AACF41");
        });

        modelBuilder.Entity<Restaurant>(entity =>
        {
            entity.HasKey(e => e.RestaurantId).HasName("PK__Restaura__09D80A30A7ECC426");

            entity.Property(e => e.RestaurantId).HasColumnName("restaurantId");
            entity.Property(e => e.City)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.Grade)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("grade");
            entity.Property(e => e.RestaurantName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("restaurantName");
            entity.Property(e => e.State)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("state");
            entity.Property(e => e.Street)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("street");
        });

        modelBuilder.Entity<RestaurantCuisine>(entity =>
        {
            entity.HasKey(e => e.RcId).HasName("PK__Restaura__CA284E516AD36E7D");

            entity.Property(e => e.RcId).HasColumnName("rcId");
            entity.Property(e => e.RcCuisineId).HasColumnName("rcCuisineId");
            entity.Property(e => e.RcRestaurantId).HasColumnName("rcRestaurantId");

            entity.HasOne(d => d.RcCuisine).WithMany(p => p.RestaurantCuisines)
                .HasForeignKey(d => d.RcCuisineId)
                .HasConstraintName("FK__Restauran__rcCui__2057CCD0");

            entity.HasOne(d => d.RcRestaurant).WithMany(p => p.RestaurantCuisines)
                .HasForeignKey(d => d.RcRestaurantId)
                .HasConstraintName("FK__Restauran__rcRes__1F63A897");
        });

        modelBuilder.Entity<RestaurantMenu>(entity =>
        {
            entity.HasKey(e => e.RmId).HasName("PK__Restaura__86BE1E94BA998E31");

            entity.Property(e => e.RmId).HasColumnName("rmId");
            entity.Property(e => e.RmMenuItemId).HasColumnName("rmMenuItemId");
            entity.Property(e => e.RmRestaurantId).HasColumnName("rmRestaurantId");

            entity.HasOne(d => d.RmMenuItem).WithMany(p => p.RestaurantMenus)
                .HasForeignKey(d => d.RmMenuItemId)
                .HasConstraintName("FK__Restauran__rmMen__24285DB4");

            entity.HasOne(d => d.RmRestaurant).WithMany(p => p.RestaurantMenus)
                .HasForeignKey(d => d.RmRestaurantId)
                .HasConstraintName("FK__Restauran__rmRes__2334397B");
        });

        modelBuilder.Entity<Score>(entity =>
        {
            entity.HasKey(e => e.ScoreId).HasName("PK__Scores__B56A0C8D0D4D50D7");

            entity.Property(e => e.ScoreId).HasColumnName("scoreId");
            entity.Property(e => e.Date)
                .HasColumnType("date")
                .HasColumnName("date");
            entity.Property(e => e.Score1).HasColumnName("score");
            entity.Property(e => e.ScoredRestaurantId).HasColumnName("scoredRestaurantId");

            entity.HasOne(d => d.ScoredRestaurant).WithMany(p => p.Scores)
                .HasForeignKey(d => d.ScoredRestaurantId)
                .HasConstraintName("FK__Scores__scoredRe__2EA5EC27");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
