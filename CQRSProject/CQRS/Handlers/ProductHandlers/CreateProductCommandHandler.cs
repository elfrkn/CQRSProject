﻿using CQRSProject.CQRS.Commands;
using CQRSProject.DAL;

namespace CQRSProject.CQRS.Handlers.ProductHandlers
{
    public class CreateProductCommandHandler
    {
        private readonly Context _context;

        public CreateProductCommandHandler(Context context)
        {
            _context = context;
        }
        public void Handle(CreateProductCommand command)
        {
            _context.Products.Add(new Product
            {
                ProductPrice = command.ProductPrice,
                ProductName = command.ProductName
            });
            _context.SaveChanges();
        }
    }
}
