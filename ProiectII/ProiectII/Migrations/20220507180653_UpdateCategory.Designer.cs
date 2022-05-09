﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProiectII.Models;

namespace ProiectII.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220507180653_UpdateCategory")]
    partial class UpdateCategory
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.24")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

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
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ProiectII.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Audi"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "BMW"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Mercedes"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Volkswagen"
                        });
                });

            modelBuilder.Entity("ProiectII.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("AddressLine2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime>("OrderPlaced")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("OrderTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ProiectII.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("PartId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("OrderId");

                    b.HasIndex("PartId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("ProiectII.Models.Part", b =>
                {
                    b.Property<int>("PartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<bool>("Discount")
                        .HasColumnType("bit");

                    b.Property<string>("ImageThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("InStock")
                        .HasColumnType("bit");

                    b.Property<string>("LongDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PartId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Parts");

                    b.HasData(
                        new
                        {
                            PartId = 1,
                            CategoryId = 1,
                            Discount = true,
                            ImageThumbnailUrl = "https://i.ibb.co/L0538Kz/clapeta-Admisie.jpg",
                            ImageUrl = "https://i.ibb.co/L0538Kz/clapeta-Admisie.jpg",
                            InStock = true,
                            LongDescription = "Numar motor TECDOC: 26329 Mod de operare: electric Diametru[mm]: 48 Tensiune[V]: 12",
                            Name = "CLAPETA CONTROL ADMISIE AER AUDI",
                            Price = 12.95m,
                            ShortDescription = "PIERBURG"
                        },
                        new
                        {
                            PartId = 2,
                            CategoryId = 1,
                            Discount = false,
                            ImageThumbnailUrl = "https://i.ibb.co/N6C8g0z/cureadistributie.jpg",
                            ImageUrl = "https://i.ibb.co/N6C8g0z/cureadistributie.jpg",
                            InStock = true,
                            LongDescription = "Agregate angrenate: agregat antrenat:arbore cu came pt.cod original(OE): 4L198119K Numar dinti: 145 Latime[mm]: 25 Lungime[mm]: 1381 Numarul de curele: 1 contine role: 3",
                            Name = "KIT DISTRIBUTIE AUDI A6 C7",
                            Price = 18.95m,
                            ShortDescription = "DAYCO"
                        },
                        new
                        {
                            PartId = 3,
                            CategoryId = 1,
                            Discount = false,
                            ImageThumbnailUrl = "https://i.ibb.co/4t6dxmf/volanta.jpg",
                            ImageUrl = "https://i.ibb.co/4t6dxmf/volanta.jpg",
                            InStock = true,
                            LongDescription = "Numar motor TECDOC: 26329 Numarul gaurilor de fixare: 3",
                            Name = "VOLANTA AUDI A6 C7",
                            Price = 18.95m,
                            ShortDescription = "LuK"
                        },
                        new
                        {
                            PartId = 4,
                            CategoryId = 2,
                            Discount = false,
                            ImageThumbnailUrl = "https://i.ibb.co/LgPn9FM/sondalambda.jpg",
                            ImageUrl = "https://i.ibb.co/LgPn9FM/sondalambda.jpg",
                            InStock = true,
                            LongDescription = "Cod motor: B47 D20 A Execuție izolație cablu: cu izolație din plasă de fibre acoperite cu silicon Numar poli: 4 Culoare stecher: negru Numar de legaturi: 4 Forma carcasa stecher: oval",
                            Name = "SONDA LAMBDA BMW SERIA 5",
                            Price = 15.95m,
                            ShortDescription = "VEMO"
                        },
                        new
                        {
                            PartId = 5,
                            CategoryId = 2,
                            Discount = false,
                            ImageThumbnailUrl = "https://i.ibb.co/pjmq7J2/piston.jpg",
                            ImageUrl = "https://i.ibb.co/pjmq7J2/piston.jpg",
                            InStock = true,
                            LongDescription = "Alezaj piston [mm]: 84 Lungime[mm]: 65 Inaltime compresie[mm]: 42 Adancime oala 1[mm]: 14,5 Diametru oala[mm]: 47, Inaltime perete[mm]: 10 Bolt -?[mm]: 28",
                            Name = "PISTON BMW SERIA 5 ",
                            Price = 13.95m,
                            ShortDescription = "MAHLE"
                        },
                        new
                        {
                            PartId = 6,
                            CategoryId = 2,
                            Discount = false,
                            ImageThumbnailUrl = "https://i.ibb.co/6rcDHHj/supapaegr.jpg",
                            ImageUrl = "https://i.ibb.co/6rcDHHj/supapaegr.jpg",
                            InStock = true,
                            LongDescription = "Numar poli: 5 Mod de operare: electric Articol extins / Informatii de extindere: fara radiator EGR",
                            Name = "SUPAPA EGR BMW SERIA 5",
                            Price = 17.95m,
                            ShortDescription = "TRISCAN"
                        },
                        new
                        {
                            PartId = 7,
                            CategoryId = 3,
                            Discount = false,
                            ImageThumbnailUrl = "https://i.ibb.co/LZ9bPP4/culbutor.jpg",
                            ImageUrl = "https://i.ibb.co/LZ9bPP4/culbutor.jpg",
                            InStock = false,
                            LongDescription = "Grosime [mm]: 34,7 Diametru exterior[mm]: 12 Mod de operare: hidraulic Partea de montare: Partea de admisie, Partea de evacuare Greutate[kg]: 0,018",
                            Name = "CULBUTOR SUPAPA MERCEDES-BENZ GLE",
                            Price = 15.95m,
                            ShortDescription = "FEBI BILSTEIN"
                        },
                        new
                        {
                            PartId = 8,
                            CategoryId = 3,
                            Discount = true,
                            ImageThumbnailUrl = "https://i.ibb.co/bss5dvq/filtruaer.jpg",
                            ImageUrl = "https://i.ibb.co/bss5dvq/filtruaer.jpg",
                            InStock = true,
                            LongDescription = "Numar articol par: 49667 Tip filtru: Insertie filtru Lungime[mm]: 306 Latime[mm]: 193 Înaltime[mm]: 97 Partea de montare: dreapta",
                            Name = "FILTRU AER MERCEDES-BENZ GLE",
                            Price = 12.95m,
                            ShortDescription = "FEBI BILSTEIN"
                        },
                        new
                        {
                            PartId = 9,
                            CategoryId = 3,
                            Discount = true,
                            ImageThumbnailUrl = "https://i.ibb.co/1mCtryH/filtruulei.jpg",
                            ImageUrl = "https://i.ibb.co/1mCtryH/filtruulei.jpg",
                            InStock = true,
                            LongDescription = "Tip filtru: Insertie filtru Înaltime[mm]: 95 Diametru interior[mm]: 31,7 Diametru exterior[mm]: 72 Greutate[kg]: 0,075",
                            Name = "FILTRU ULEI MERCEDES-BENZ GLE",
                            Price = 15.95m,
                            ShortDescription = "DREISSNER"
                        },
                        new
                        {
                            PartId = 10,
                            CategoryId = 4,
                            Discount = false,
                            ImageThumbnailUrl = "https://i.ibb.co/6YknF4Y/turbocompresor.jpg",
                            ImageUrl = "https://i.ibb.co/6YknF4Y/turbocompresor.jpg",
                            InStock = true,
                            LongDescription = "Numar motor TECDOC: 27202, 27196 Mod de operare: comana cu subpresiune Varianta echipare: FIRST FIT",
                            Name = "COMPRESOR SISTEM DE SUPRAALIMENTARE VW GOLF",
                            Price = 15.95m,
                            ShortDescription = "NISSENS"
                        },
                        new
                        {
                            PartId = 11,
                            CategoryId = 4,
                            Discount = false,
                            ImageThumbnailUrl = "https://i.ibb.co/0DJcSNL/planetara.jpg",
                            ImageUrl = "https://i.ibb.co/0DJcSNL/planetara.jpg",
                            InStock = false,
                            LongDescription = "pt. numar PR: 1PA, 1PE, 1PF, 2H4, 2H5 Partea de montare: Axa fata stanga Dantura exterioara parte roata: 36 Lungime[mm]: 487",
                            Name = "PLANETARA VW GOLF VII",
                            Price = 18.95m,
                            ShortDescription = "MEYLE"
                        });
                });

            modelBuilder.Entity("ProiectII.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("PartId")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShoppingCartItemId");

                    b.HasIndex("PartId");

                    b.ToTable("ShoppingCartItems");
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProiectII.Models.OrderDetail", b =>
                {
                    b.HasOne("ProiectII.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProiectII.Models.Part", "Part")
                        .WithMany()
                        .HasForeignKey("PartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProiectII.Models.Part", b =>
                {
                    b.HasOne("ProiectII.Models.Category", "Category")
                        .WithMany("Pies")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProiectII.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("ProiectII.Models.Part", "Part")
                        .WithMany()
                        .HasForeignKey("PartId");
                });
#pragma warning restore 612, 618
        }
    }
}
