using System;

namespace coreOrmSqlite
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new DatabaseContext())
            {
    
            var product = new Product(){ Price = 100, Description = "Movie" };
            db.Products.Add(product);
            db.SaveChanges();

            foreach(var p in db.Products) 
            {
                Console.WriteLine("{0} {1} {2}", p.ProductId, p.Description, p.Price);
            }
    
            }
        }
    }
}
