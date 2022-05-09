using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ProiectII.Models
{
    public class AppDbContext: IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Part> Parts { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Audi" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "BMW" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Mercedes" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 4, CategoryName = "Volkswagen" });
            //seed pies

            modelBuilder.Entity<Part>().HasData(new Part
            {
                PartId = 1,
                Name = "CLAPETA CONTROL ADMISIE AER AUDI",
                Price = 12.95M,
                ShortDescription = "PIERBURG",
                LongDescription =
                    "Numar motor TECDOC: 26329 Mod de operare: electric Diametru[mm]: 48 Tensiune[V]: 12",
                CategoryId = 1,
                ImageUrl = "https://i.ibb.co/L0538Kz/clapeta-Admisie.jpg",
                InStock = true,
                Discount = true,
                ImageThumbnailUrl = "https://i.ibb.co/L0538Kz/clapeta-Admisie.jpg",
                
            });

            modelBuilder.Entity<Part>().HasData(new Part
            {
                PartId = 2,
                Name = "KIT DISTRIBUTIE AUDI A6 C7",
                Price = 18.95M,
                ShortDescription = "DAYCO",
                LongDescription =
                    "Agregate angrenate: agregat antrenat:arbore cu came pt.cod original(OE): 4L198119K Numar dinti: 145 Latime[mm]: 25 Lungime[mm]: 1381 Numarul de curele: 1 contine role: 3",
                CategoryId = 1,
                ImageUrl = "https://i.ibb.co/N6C8g0z/cureadistributie.jpg",
                InStock = true,
                Discount = false,
                ImageThumbnailUrl =
                    "https://i.ibb.co/N6C8g0z/cureadistributie.jpg",
               
            });

            modelBuilder.Entity<Part>().HasData(new Part
            {
                PartId = 3,
                Name = "VOLANTA AUDI A6 C7",
                Price = 18.95M,
                ShortDescription = "LuK",
                LongDescription =
                    "Numar motor TECDOC: 26329 Numarul gaurilor de fixare: 3",
                CategoryId = 1,
                ImageUrl = "https://i.ibb.co/4t6dxmf/volanta.jpg",
                InStock = true,
                Discount = false,
                ImageThumbnailUrl = "https://i.ibb.co/4t6dxmf/volanta.jpg",
                
            });

            modelBuilder.Entity<Part>().HasData(new Part
            {
                PartId = 4,
                Name = "SONDA LAMBDA BMW SERIA 5",
                Price = 15.95M,
                ShortDescription = "VEMO",
                LongDescription =
                    "Cod motor: B47 D20 A Execuție izolație cablu: cu izolație din plasă de fibre acoperite cu silicon Numar poli: 4 Culoare stecher: negru Numar de legaturi: 4 Forma carcasa stecher: oval",
                CategoryId = 2,
                ImageUrl = "https://i.ibb.co/LgPn9FM/sondalambda.jpg",
                InStock = true,
                Discount = false,
                ImageThumbnailUrl = "https://i.ibb.co/LgPn9FM/sondalambda.jpg",
                
            });

            modelBuilder.Entity<Part>().HasData(new Part
            {
                PartId = 5,
                Name = "PISTON BMW SERIA 5 ",
                Price = 13.95M,
                ShortDescription = "MAHLE",
                LongDescription =
                    "Alezaj piston [mm]: 84 Lungime[mm]: 65 Inaltime compresie[mm]: 42 Adancime oala 1[mm]: 14,5 Diametru oala[mm]: 47, Inaltime perete[mm]: 10 Bolt -?[mm]: 28",
                CategoryId = 2,
                ImageUrl = "https://i.ibb.co/pjmq7J2/piston.jpg",
                InStock = true,
                Discount = false,
                ImageThumbnailUrl =
                    "https://i.ibb.co/pjmq7J2/piston.jpg",
              
            });

            modelBuilder.Entity<Part>().HasData(new Part
            {
                PartId = 6,
                Name = "SUPAPA EGR BMW SERIA 5",
                Price = 17.95M,
                ShortDescription = "TRISCAN",
                LongDescription =
                    "Numar poli: 5 Mod de operare: electric Articol extins / Informatii de extindere: fara radiator EGR",
                CategoryId = 2,
                ImageUrl = "https://i.ibb.co/6rcDHHj/supapaegr.jpg",
                InStock = true,
                Discount = false,
                ImageThumbnailUrl = "https://i.ibb.co/6rcDHHj/supapaegr.jpg",
               
            });

            modelBuilder.Entity<Part>().HasData(new Part
            {
                PartId = 7,
                Name = "CULBUTOR SUPAPA MERCEDES-BENZ GLE",
                Price = 15.95M,
                ShortDescription = "FEBI BILSTEIN",
                LongDescription =
                    "Grosime [mm]: 34,7 Diametru exterior[mm]: 12 Mod de operare: hidraulic Partea de montare: Partea de admisie, Partea de evacuare Greutate[kg]: 0,018",
                CategoryId = 3,
                ImageUrl = "https://i.ibb.co/LZ9bPP4/culbutor.jpg",
                InStock = false,
                 Discount = false,
                ImageThumbnailUrl = "https://i.ibb.co/LZ9bPP4/culbutor.jpg",
                
            });

            modelBuilder.Entity<Part>().HasData(new Part
            {
                PartId = 8,
                Name = "FILTRU AER MERCEDES-BENZ GLE",
                Price = 12.95M,
                ShortDescription = "FEBI BILSTEIN",
                LongDescription =
                    "Numar articol par: 49667 Tip filtru: Insertie filtru Lungime[mm]: 306 Latime[mm]: 193 Înaltime[mm]: 97 Partea de montare: dreapta",
                CategoryId = 3,
                ImageUrl = "https://i.ibb.co/bss5dvq/filtruaer.jpg",
                InStock = true,
               Discount = true,
                ImageThumbnailUrl = "https://i.ibb.co/bss5dvq/filtruaer.jpg",
                
            });


            modelBuilder.Entity<Part>().HasData(new Part
            {
                PartId = 9,
                Name = "FILTRU ULEI MERCEDES-BENZ GLE",
                Price = 15.95M,
                ShortDescription = "DREISSNER",
                LongDescription =
                    "Tip filtru: Insertie filtru Înaltime[mm]: 95 Diametru interior[mm]: 31,7 Diametru exterior[mm]: 72 Greutate[kg]: 0,075",
                CategoryId = 3,
                ImageUrl = "https://i.ibb.co/1mCtryH/filtruulei.jpg",
                InStock = true,
                Discount = true,
                ImageThumbnailUrl = "https://i.ibb.co/1mCtryH/filtruulei.jpg",
                
            });

            modelBuilder.Entity<Part>().HasData(new Part
            {
                PartId = 10,
                Name = "COMPRESOR SISTEM DE SUPRAALIMENTARE VW GOLF",
                Price = 15.95M,
                ShortDescription = "NISSENS",
                LongDescription =
                    "Numar motor TECDOC: 27202, 27196 Mod de operare: comana cu subpresiune Varianta echipare: FIRST FIT",
                CategoryId = 4,
                ImageUrl = "https://i.ibb.co/6YknF4Y/turbocompresor.jpg",
                InStock = true,
                Discount = false,
                ImageThumbnailUrl = "https://i.ibb.co/6YknF4Y/turbocompresor.jpg",
               
            });

            modelBuilder.Entity<Part>().HasData(new Part
            {
                PartId = 11,
                Name = "PLANETARA VW GOLF VII",
                Price = 18.95M,
                ShortDescription = "MEYLE",
                LongDescription =
                    "pt. numar PR: 1PA, 1PE, 1PF, 2H4, 2H5 Partea de montare: Axa fata stanga Dantura exterioara parte roata: 36 Lungime[mm]: 487",
                CategoryId = 4,
                ImageUrl = "https://i.ibb.co/0DJcSNL/planetara.jpg",
                InStock = false,
                Discount = false,
                ImageThumbnailUrl =
                    "https://i.ibb.co/0DJcSNL/planetara.jpg",
               
            });
        }
    }
}
