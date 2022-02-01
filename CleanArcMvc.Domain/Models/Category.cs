using CleanArcMvc.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArcMvc.Domain.Models
{
    public sealed class Category : Model
    {
        public string Name { get; private set; }

        public Category(string name)
        {
            ValidateCategory(name);
        }

        public Category(int id, string name)
        {
            DomainExceptionValidation.When(id < 0, "Invalid Id value.");
            Id = id;
            Name = name;
        }
        
        public void UpDate(string name)
        {
            ValidateCategory(name);
        }

        private void ValidateCategory(string name) {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Invalid name. Name is required");
            Name = name;
        }


        //Uma categoria pode possuir varios produtos  -- um coleção de produtos
        public ICollection<Product> Products { get; set; }

        //O que define se uma propriedade de navegação é o tipo para o qual ela está apontando não puder ser mapeado 
        //pelo banco de dados atual

    }
}
