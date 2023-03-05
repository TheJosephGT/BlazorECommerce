using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorCommerce.Server.Migrations
{
    public partial class ProductSending : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "Don Quijote de la Manchaa​ es una novela escrita por el español Miguel de Cervantes Saavedra. Publicada su primera parte con el título de El ingenioso hidalgo don Quijote de la Mancha a comienzos de 1605, es la obra más destacada de la literatura española y una de las principales de la literatura universal, además de ser la más leída después de la Biblia.1​2​ En 1615 apareció su continuación con el título de Segunda parte del ingenioso caballero don Quijote de la Mancha. El Quijote de 1605 se publicó dividido en cuatro partes; pero al aparecer el Quijote de 1615 en calidad de Segunda parte de la obra, quedó revocada de hecho la partición en cuatro secciones del volumen publicado diez años antes por Cervantes", "https://www.menteasombrosa.com/literatura/wp-content/uploads/2022/07/don-quijote-de-la-mancha.webp", 9.99m, "Don Quijote de la Mancha" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "Historia de dos ciudades (título original, A Tale of Two Cities) es una novela del escritor británico Charles Dickens. En esta novela histórica se narra la vida en el siglo XVIII, en la época de la Revolución francesa. La historia se desarrolla en dos países: Inglaterra y Francia, y en las ciudades de Londres y París en la época de los albores de la Revolución francesa. La primera ciudad simbolizaría de algún modo la paz y la tranquilidad, la vida sencilla y ordenada; mientras la segunda representaría la agitación, el desafío y el caos, el conflicto entre dos mundos en una época en la que se anuncian drásticos cambios sociales.", "https://upload.wikimedia.org/wikipedia/commons/3/3c/Tales_serial.jpg", 7.99m, "Historia de dos ciudades" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "El Señor de los Anillos (título original en inglés: The Lord of the Rings) es una novela de fantasía épica escrita por el filólogo y escritor británico J. R. R. Tolkien.", "https://upload.wikimedia.org/wikipedia/commons/thumb/7/7d/El_Se%C3%B1or_de_los_Anillos_lectura.jpg/417px-El_Se%C3%B1or_de_los_Anillos_lectura.jpg", 6.99m, "El Señor de los Anillos" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
