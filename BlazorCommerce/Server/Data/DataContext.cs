
namespace BlazorCommerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Books",
                    Url = "books"
                },
                new Category
                {
                    Id = 2,
                    Name = "Movies",
                    Url = "movies"
                },
                new Category
                {
                    Id = 3,
                    Name = "Video Games",
                    Url = "video-games"
                }
                ); ;

            modelBuilder.Entity<Product>().HasData(
            new Product
             {
                 Id = 1,
                 Title = "Don Quijote de la Mancha",
                 Description = "Don Quijote de la Manchaa​ es una novela escrita por el español Miguel de Cervantes Saavedra. Publicada su primera parte con el título de El ingenioso hidalgo don Quijote de la Mancha a comienzos de 1605, es la obra más destacada de la literatura española y una de las principales de la literatura universal, además de ser la más leída después de la Biblia.1​2​ En 1615 apareció su continuación con el título de Segunda parte del ingenioso caballero don Quijote de la Mancha. El Quijote de 1605 se publicó dividido en cuatro partes; pero al aparecer el Quijote de 1615 en calidad de Segunda parte de la obra, quedó revocada de hecho la partición en cuatro secciones del volumen publicado diez años antes por Cervantes",
                 ImageUrl = "https://www.menteasombrosa.com/literatura/wp-content/uploads/2022/07/don-quijote-de-la-mancha.webp",
                 Price = 9.99m,
                 CategoryId = 1
            },
            new Product
            {
                Id = 2,
                Title = "Historia de dos ciudades",
                Description = "Historia de dos ciudades (título original, A Tale of Two Cities) es una novela del escritor británico Charles Dickens. En esta novela histórica se narra la vida en el siglo XVIII, en la época de la Revolución francesa. La historia se desarrolla en dos países: Inglaterra y Francia, y en las ciudades de Londres y París en la época de los albores de la Revolución francesa. La primera ciudad simbolizaría de algún modo la paz y la tranquilidad, la vida sencilla y ordenada; mientras la segunda representaría la agitación, el desafío y el caos, el conflicto entre dos mundos en una época en la que se anuncian drásticos cambios sociales.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/3/3c/Tales_serial.jpg",
                Price = 7.99m,
                CategoryId = 1
            },
            new Product
            {
                Id = 3,
                Title = "El Señor de los Anillos",
                Description = "El Señor de los Anillos (título original en inglés: The Lord of the Rings) es una novela de fantasía épica escrita por el filólogo y escritor británico J. R. R. Tolkien.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/7d/El_Se%C3%B1or_de_los_Anillos_lectura.jpg/417px-El_Se%C3%B1or_de_los_Anillos_lectura.jpg",
                Price = 6.99m,
                CategoryId = 1
            }

           );
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
