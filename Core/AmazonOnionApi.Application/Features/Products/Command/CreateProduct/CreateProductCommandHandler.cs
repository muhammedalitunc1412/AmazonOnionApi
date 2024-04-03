using AmazonOnionApi.Application.Features.Products.Rules;
using AmazonOnionApi.Application.Interfaces.UnitOfWorks;
using AmazonOnionApi.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonOnionApi.Application.Features.Products.Command.CreateProduct
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommandRequest, Unit>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly ProductRules productRules;

        public CreateProductCommandHandler(IUnitOfWork unitOfWork, ProductRules productRules)
        {
            this.unitOfWork = unitOfWork;
            this.productRules = productRules;
        }
        public async Task<Unit> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
        {
            IList<Product> products = await unitOfWork.GetReadRepository<Product>().GetAllAsync();

            await productRules.ProductTitleMustNotBeSame(products, request.Title);

            Product product = new(request.Title, request.Description, request.BrandId, request.Price, request.Discount);

            await unitOfWork.GetWriteRepository<Product>().AddAsync(product);
            if (await unitOfWork.SaveAsync() > 0)
            {
                try
                {
                    if (request.CategoryIds.Count == 0)
                    {
                        return Unit.Value;
                    }

                    foreach (var categoryId in request.CategoryIds)
                    {
                        await unitOfWork.GetWriteRepository<ProductCategory>().AddAsync(new()
                        {
                            ProductId = product.Id,
                            CategoryId = categoryId
                        });
                    }

                    await unitOfWork.SaveAsync();
                }
                catch (Exception e)
                {

                }

            }

            return Unit.Value;
        }
    }
}