using Moq;
using Sprint4.Models;
using Sprint4.Repositories;
using Sprint4.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Sprint4.Tests.Unit
{
    public class ProductServiceTests
    {
        [Fact]
        public void ObterTodosProdutos_RetornaListaDeProdutos()
        {
            // Arrange
            var mockRepo = new Mock<ProductRepository>();
            mockRepo.Setup(repo => repo.ObterTodos()).Returns(new List<Product>
            {
                new Product { Id = 1, Nome = "Produto 1", Preco = 10.0m },
                new Product { Id = 2, Nome = "Produto 2", Preco = 20.0m }
            });

            var service = new ProductService(mockRepo.Object);

            // Act
            var result = service.ObterTodosProdutos();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, ((List<Product>)result).Count);
        }
    }
}
