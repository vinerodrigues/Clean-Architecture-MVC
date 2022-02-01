using CleanArcMvc.Domain.Models;
using FluentAssertions;
using System;
using Xunit;

namespace CleanArcMvc.Domain.Tests
{
    public class ProductUnitTest1
    {
        [Fact(DisplayName ="Create Product With Valid Parameters")]
        public void CreateProduct_WithValidParameters_ResultObjectValid() {

            Action action = () => new Product("Teste", "Testendo obj", 9.99m, 7, "ImagemCasa.png");

            action.Should()
                .NotThrow<Domain.Validation.DomainExceptionValidation>();
        }

        [Fact(DisplayName = "Create Product With Valid Parameters")]
        public void CreateProduct_WithNullParameters_ResultObjectValid()
        {

            Action action = () => new Product("Teste", "Testendo obj", 9.99m, 7, null);

            action.Should()
                .NotThrow<NullReferenceException>();
        }

        [Fact(DisplayName = "Create Product With Id Parameters")]
        public void CreateProduct_WithIdParameters_ResultObjectValid()
        {

            Action action = () => new Product(1, "Teste", "Testendo obj", 9.99m, 7, null);

            action.Should()
                .NotThrow<NullReferenceException>();
        }
    }
}
