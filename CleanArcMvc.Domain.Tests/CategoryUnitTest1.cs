using CleanArcMvc.Domain.Models;
using FluentAssertions;
using System;
using Xunit;

namespace CleanArcMvc.Domain.Tests
{
    public class CategoryUnitTest1
    {
        [Fact(DisplayName ="Create Category With Valid State")]
        public void CreateCategory_WithValidParameters_ResultObjectValidState()
        {
            Action action = () => new Category(1, "Teste");

            action.Should()
                .NotThrow<CleanArcMvc.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact(DisplayName = "Create Category With Negative Id")]
        public void CreateCategory_WithNegativeParameters_DomainExceptionInvalid()
        {
            Action action = () => new Category(-1, "Teste");

            action.Should()
                .Throw<CleanArcMvc.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid Id value.")
                ;
        }
    }
}
