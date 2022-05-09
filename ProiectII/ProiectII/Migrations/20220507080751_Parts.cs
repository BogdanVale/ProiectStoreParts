using Microsoft.EntityFrameworkCore.Migrations;

namespace ProiectII.Migrations
{
    public partial class Parts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 2,
                columns: new[] { "CategoryId", "LongDescription", "Name", "ShortDescription" },
                values: new object[] { 1, "Agregate angrenate: agregat antrenat:arbore cu came pt.cod original(OE): 4L198119K Numar dinti: 145 Latime[mm]: 25 Lungime[mm]: 1381 Numarul de curele: 1 contine role: 3", "KIT DISTRIBUTIE AUDI A6 C7", "DAYCO" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 3,
                columns: new[] { "CategoryId", "LongDescription", "Name", "ShortDescription" },
                values: new object[] { 1, "Numar motor TECDOC: 26329 Numarul gaurilor de fixare: 3", "VOLANTA AUDI A6 C7", "LuK" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 4,
                columns: new[] { "CategoryId", "LongDescription", "Name", "ShortDescription" },
                values: new object[] { 2, "Cod motor: B47 D20 A Execuție izolație cablu: cu izolație din plasă de fibre acoperite cu silicon Numar poli: 4 Culoare stecher: negru Numar de legaturi: 4 Forma carcasa stecher: oval", "SONDA LAMBDA BMW SERIA 5", "VEMO" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 5,
                columns: new[] { "CategoryId", "LongDescription", "Name", "ShortDescription" },
                values: new object[] { 2, "Alezaj piston [mm]: 84 Lungime[mm]: 65 Inaltime compresie[mm]: 42 Adancime oala 1[mm]: 14,5 Diametru oala[mm]: 47, Inaltime perete[mm]: 10 Bolt -?[mm]: 28", "PISTON BMW SERIA 5 ", "MAHLE" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 6,
                columns: new[] { "CategoryId", "LongDescription", "Name", "ShortDescription" },
                values: new object[] { 2, "Numar poli: 5 Mod de operare: electric Articol extins / Informatii de extindere: fara radiator EGR", "SUPAPA EGR BMW SERIA 5", "TRISCAN" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 7,
                columns: new[] { "CategoryId", "LongDescription", "Name", "ShortDescription" },
                values: new object[] { 3, "Grosime [mm]: 34,7 Diametru exterior[mm]: 12 Mod de operare: hidraulic Partea de montare: Partea de admisie, Partea de evacuare Greutate[kg]: 0,018", "CULBUTOR SUPAPA MERCEDES-BENZ GLE", "FEBI BILSTEIN" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 8,
                columns: new[] { "LongDescription", "Name", "ShortDescription" },
                values: new object[] { "Numar articol par: 49667 Tip filtru: Insertie filtru Lungime[mm]: 306 Latime[mm]: 193 Înaltime[mm]: 97 Partea de montare: dreapta", "FILTRU AER MERCEDES-BENZ GLE", "FEBI BILSTEIN" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 9,
                columns: new[] { "CategoryId", "LongDescription", "Name", "ShortDescription" },
                values: new object[] { 3, "Tip filtru: Insertie filtru Înaltime[mm]: 95 Diametru interior[mm]: 31,7 Diametru exterior[mm]: 72 Greutate[kg]: 0,075", "FILTRU ULEI MERCEDES-BENZ GLE", "DREISSNER" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 10,
                columns: new[] { "CategoryId", "LongDescription", "Name", "ShortDescription" },
                values: new object[] { 4, "Numar motor TECDOC: 27202, 27196 Mod de operare: comana cu subpresiune Varianta echipare: FIRST FIT", "COMPRESOR SISTEM DE SUPRAALIMENTARE VW GOLF", "NISSENS" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 11,
                columns: new[] { "CategoryId", "LongDescription", "Name", "ShortDescription" },
                values: new object[] { 4, "pt. numar PR: 1PA, 1PE, 1PF, 2H4, 2H5 Partea de montare: Axa fata stanga Dantura exterioara parte roata: 36 Lungime[mm]: 487", "PLANETARA VW GOLF VII", "MEYLE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 2,
                columns: new[] { "CategoryId", "LongDescription", "Name", "ShortDescription" },
                values: new object[] { 2, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", "Blueberry Cheese Cake", "You'll love it!" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 3,
                columns: new[] { "CategoryId", "LongDescription", "Name", "ShortDescription" },
                values: new object[] { 2, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", "Cheese Cake", "Plain cheese cake. Plain pleasure." });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 4,
                columns: new[] { "CategoryId", "LongDescription", "Name", "ShortDescription" },
                values: new object[] { 1, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", "Cherry Pie", "A summer classic!" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 5,
                columns: new[] { "CategoryId", "LongDescription", "Name", "ShortDescription" },
                values: new object[] { 3, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", "Christmas Apple Pie", "Happy holidays with this pie!" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 6,
                columns: new[] { "CategoryId", "LongDescription", "Name", "ShortDescription" },
                values: new object[] { 3, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", "Cranberry Pie", "A Christmas favorite" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 7,
                columns: new[] { "CategoryId", "LongDescription", "Name", "ShortDescription" },
                values: new object[] { 1, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", "Peach Pie", "Sweet as peach" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 8,
                columns: new[] { "LongDescription", "Name", "ShortDescription" },
                values: new object[] { "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", "Pumpkin Pie", "Our Halloween favorite" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 9,
                columns: new[] { "CategoryId", "LongDescription", "Name", "ShortDescription" },
                values: new object[] { 1, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", "Rhubarb Pie", "My God, so sweet!" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 10,
                columns: new[] { "CategoryId", "LongDescription", "Name", "ShortDescription" },
                values: new object[] { 1, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", "Strawberry Pie", "Our delicious strawberry pie!" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 11,
                columns: new[] { "CategoryId", "LongDescription", "Name", "ShortDescription" },
                values: new object[] { 2, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", "Strawberry Cheese Cake", "You'll love it!" });
        }
    }
}
