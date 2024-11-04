﻿using Sprint4.Models;
using Sprint4.Repositories;

namespace Sprint4.Services
{
    public class ProductService
    {
        private readonly ProductRepository _repository;

        public ProductService(ProductRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Product> ObterTodosProdutos()
        {
            return _repository.ObterTodos();
        }
    }
}
