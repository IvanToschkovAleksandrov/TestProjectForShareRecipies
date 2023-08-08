﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestProjectForShareRecipies.Data;

#nullable disable

namespace TestProjectForShareRecipies.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230808155830_change user seed data")]
    partial class changeuserseeddata
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "1",
                            ConcurrencyStamp = "75f11362-ef42-42bb-a46d-90b01c04883a",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "162bb2c2-b78b-4a43-9318-271e17ebd9b4",
                            RoleId = "1"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("TestProjectForShareRecipies.Data.Entities.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "162bb2c2-b78b-4a43-9318-271e17ebd9b4",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a72db372-7409-4b0a-82b5-bb09ae698bbe",
                            Email = "ivan.aleksandrov@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Ivan",
                            LastName = "Aleksandrov",
                            LockoutEnabled = false,
                            NormalizedEmail = "IVAN.ALEKSANDROV@GMAIL.COM",
                            NormalizedUserName = "IVAN.ALEKSANDROV@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEKTUwRpW9qM0fRC/CWdQ8HdC4+5zY3t6QvcDDESWqtv90CXON/4AEdgX1Bs7tj3k+Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "eeab65ad-27df-452e-956b-622a2d28e9f5",
                            TwoFactorEnabled = false,
                            UserName = "ivan.aleksandrov@gmail.com"
                        },
                        new
                        {
                            Id = "d5ab93a3-c7cf-4328-80f4-705121dfe864",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c4a0570a-361a-4470-883c-051a720a08e2",
                            Email = "petar.petrov@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Petar",
                            LastName = "Petrov",
                            LockoutEnabled = false,
                            NormalizedEmail = "PETAR.PETROV@GMAIL.COM",
                            NormalizedUserName = "PETAR.PETROV@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAECIxaHBcRZKTt/6o2oer07waFgN64sI+BEOHu+ztsPfyYO7MwNqDmMg6aQAI3DyVMQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "22325629-c9db-492e-99af-2ca4644fca9c",
                            TwoFactorEnabled = false,
                            UserName = "petar.petrov@gmail.com"
                        });
                });

            modelBuilder.Entity("TestProjectForShareRecipies.Data.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Desserts",
                            Picture = "https://unsplash.com/photos/idTwDKt2j2o"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Dinners",
                            Picture = "https://unsplash.com/photos/awj7sRviVXo"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Vegeterian",
                            Picture = "https://images.unsplash.com/photo-1606307305578-9f4121dde6d9?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MTR8fHZlZ2V0ZXJpYW4lMjBmb29kfGVufDB8fDB8fHww&auto=format&fit=crop&w=500&q=60"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Salads",
                            Picture = "https://images.unsplash.com/photo-1600335895229-6e75511892c8?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8Nnx8c2FsYWR8ZW58MHx8MHx8fDA%3D&auto=format&fit=crop&w=500&q=60"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Soups",
                            Picture = "https://images.unsplash.com/photo-1594756202469-9ff9799b2e4e?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8M3x8c291cHxlbnwwfHwwfHx8MA%3D%3D&auto=format&fit=crop&w=500&q=60"
                        });
                });

            modelBuilder.Entity("TestProjectForShareRecipies.Data.Entities.Ingredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("MeassureUnitId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("decimal(8,3)");

                    b.Property<int>("RecipeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MeassureUnitId");

                    b.HasIndex("RecipeId");

                    b.ToTable("Ingredients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MeassureUnitId = 3,
                            Name = "Chicken Legs",
                            Quantity = 350m,
                            RecipeId = 1
                        },
                        new
                        {
                            Id = 2,
                            MeassureUnitId = 3,
                            Name = "Onion",
                            Quantity = 50m,
                            RecipeId = 1
                        },
                        new
                        {
                            Id = 3,
                            MeassureUnitId = 3,
                            Name = "Carrot",
                            Quantity = 50m,
                            RecipeId = 1
                        },
                        new
                        {
                            Id = 4,
                            MeassureUnitId = 3,
                            Name = "Celery stalk",
                            Quantity = 50m,
                            RecipeId = 1
                        },
                        new
                        {
                            Id = 5,
                            MeassureUnitId = 3,
                            Name = "Frozen Peas and Corn",
                            Quantity = 150m,
                            RecipeId = 1
                        },
                        new
                        {
                            Id = 6,
                            MeassureUnitId = 3,
                            Name = "Fresh parsley",
                            Quantity = 5m,
                            RecipeId = 1
                        },
                        new
                        {
                            Id = 7,
                            MeassureUnitId = 3,
                            Name = "Salt",
                            Quantity = 5m,
                            RecipeId = 1
                        },
                        new
                        {
                            Id = 8,
                            MeassureUnitId = 3,
                            Name = "Lentil",
                            Quantity = 250m,
                            RecipeId = 2
                        },
                        new
                        {
                            Id = 9,
                            MeassureUnitId = 3,
                            Name = "Potato",
                            Quantity = 250m,
                            RecipeId = 2
                        },
                        new
                        {
                            Id = 12,
                            MeassureUnitId = 3,
                            Name = "Onion",
                            Quantity = 50m,
                            RecipeId = 2
                        },
                        new
                        {
                            Id = 10,
                            MeassureUnitId = 3,
                            Name = "Carrot",
                            Quantity = 50m,
                            RecipeId = 2
                        },
                        new
                        {
                            Id = 11,
                            MeassureUnitId = 3,
                            Name = "Celery Stalk",
                            Quantity = 50m,
                            RecipeId = 2
                        });
                });

            modelBuilder.Entity("TestProjectForShareRecipies.Data.Entities.MeassureUnit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.ToTable("MeassureUnits");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "kg"
                        },
                        new
                        {
                            Id = 2,
                            Name = "l"
                        },
                        new
                        {
                            Id = 3,
                            Name = "grams"
                        },
                        new
                        {
                            Id = 4,
                            Name = "ml"
                        },
                        new
                        {
                            Id = 5,
                            Name = "count"
                        });
                });

            modelBuilder.Entity("TestProjectForShareRecipies.Data.Entities.Recipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AuthorId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Desctiption")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Recipes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = "162bb2c2-b78b-4a43-9318-271e17ebd9b4",
                            CategoryId = 5,
                            Desctiption = "This chicken vegetable soup is so easy to make by cooking everything in one pot using a few ingredients that take less than one hour, making it perfect for busy midweek dinners.",
                            Name = "Chicken Soup",
                            Picture = "https://comfortablefood.com/wp-content/uploads/2022/08/Chicken-vegetable-soup-11-1440x1440.jpg"
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = "162bb2c2-b78b-4a43-9318-271e17ebd9b4",
                            CategoryId = 5,
                            Desctiption = "Lentil potato soup does not require much cooking equipment to prepare this dish, just a large pot for cooking the ingredients and a chopping board.",
                            Name = "Lentil Potato Soup",
                            Picture = "https://comfortablefood.com/wp-content/uploads/2021/11/featured-lentil-potato-soup.jpg"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("TestProjectForShareRecipies.Data.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("TestProjectForShareRecipies.Data.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TestProjectForShareRecipies.Data.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("TestProjectForShareRecipies.Data.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TestProjectForShareRecipies.Data.Entities.Ingredient", b =>
                {
                    b.HasOne("TestProjectForShareRecipies.Data.Entities.MeassureUnit", "MeassureUnit")
                        .WithMany()
                        .HasForeignKey("MeassureUnitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TestProjectForShareRecipies.Data.Entities.Recipe", "Recipe")
                        .WithMany("Ingredients")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MeassureUnit");

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("TestProjectForShareRecipies.Data.Entities.Recipe", b =>
                {
                    b.HasOne("TestProjectForShareRecipies.Data.Entities.ApplicationUser", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TestProjectForShareRecipies.Data.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("TestProjectForShareRecipies.Data.Entities.Recipe", b =>
                {
                    b.Navigation("Ingredients");
                });
#pragma warning restore 612, 618
        }
    }
}