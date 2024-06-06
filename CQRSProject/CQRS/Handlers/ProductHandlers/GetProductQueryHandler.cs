﻿using CQRSProject.CQRS.Results;
using CQRSProject.DAL;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CQRSProject.CQRS.Handlers.ProductHandlers
{
    public class GetProductQueryHandler
    {
        private readonly Context _context;

        public GetProductQueryHandler(Context context)
        {
            _context = context;
        }

        public List<GetProductQueryResult> Handle()
        {
            var values = _context.Products.Select(x => new GetProductQueryResult
            {

                ProductId = x.ProductId,
                ProductName = x.ProductName,
                ProductPrice = x.ProductPrice

            });
            return values.ToList();
        }
    }
}
