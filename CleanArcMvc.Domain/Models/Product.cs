using CleanArcMvc.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArcMvc.Domain.Models
{
    public sealed class Product : Model
    {
        //saled garante que a model nao vão ser herdadas e com isso garantindo que o modelo esteja isolado
        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public int Stock { get; private set; }
        public string Image { get; private set; }

        public Product(string name, string description, decimal price, int stock, string image)
        {
            ValidateProduct(name,  description,  price,  stock,  image);
        }

        public Product(int id, string name, string description, decimal price, int stock, string image)
        {
            DomainExceptionValidation.When(id < 0, "Invalid Id value");
            
            Id = id;
            ValidateProduct(name, description, price, stock, image);
        }

        public void Update(string name, string description, decimal price, int stock, string image, int categoryId)
        {
            ValidateProduct(name, description, price, stock, image);
        }

        private void ValidateProduct(string name, string description, decimal price, int stock, string image) {
            Name = name;
            Description = description;
            Price = price;
            Stock = stock;
            Image = image;
        }

        public int CategoryId { get; set; }
        public Category Category { get; private set; }


    }
}
