using MongoDB.Driver;
using Shopping.API.Models;

namespace Shopping.API.Data
{
    public class ProductContext
    {
        public IMongoCollection<Product> Product { get; }
        public ProductContext(IConfiguration configuration)
        {
            var client = new MongoClient(configuration["DatabaseSettings:ConnectionString"]);
            var database = client.GetDatabase(configuration["DatabaseSettings:DatabaseName"]);
            Product = database.GetCollection<Product>(configuration["DatabaseSettings:CollectionName"]);
            SeedData(Product);
        }

        private void SeedData(IMongoCollection<Product> product)
        {
            var _product = product.Find(x => true).Any();
            if (!_product)
            {
                product.InsertManyAsync(DefaultProduct());
            }
        }

        private IEnumerable<Product> DefaultProduct()
        {
            List<Product> _products = new List<Product>(){
            new Product() {
            title="Cleaning Mechanism",
            category="Home",
            description="Cleaning",
            price= 90.95m
            },
            new Product() {
            title="Bedding Thingamajig",
            category="Home",
            description="Cleaning",
            price= 90.95m
            },
            new Product() {
            title="Hair Care Paraphernalia",
            category="Home",
            description="Cleaning",
            price= 90.95m
            },
            new Product() {
            title="Movie Rig",
            category="Home",
            description="Cleaning",
            price= 90.95m
            },new Product() {
            title="Game Thingamajig",
            category="Home",
            description="Cleaning",
            price= 90.95m
            },new Product() {
            title="Womens Whatchamacallit",
            category="Home",
            description="Cleaning",
            price= 90.95m
            },new Product() {
            title="Camping Doodad",
            category="Home",
            description="Cleaning",
            price= 90.95m
            },new Product() {
            title="Tire Doodad",
            category="Home",
            description="Cleaning",
            price= 90.95m
            },new Product() {
            title="Toy Mechanism",
            category="Home",
            description="Cleaning",
            price= 90.95m
            },new Product() {
            title="Party Tool",
            category="Home",
            description="Cleaning",
            price= 90.95m
            },new Product() {
            title="Movie Component",
            category="Home",
            description="Cleaning",
            price= 90.95m
            },new Product() {
            title="Party Thingamajig",
            category="Home",
            description="Cleaning",
            price= 90.95m
            }
        };
            return _products;
    }
}
}