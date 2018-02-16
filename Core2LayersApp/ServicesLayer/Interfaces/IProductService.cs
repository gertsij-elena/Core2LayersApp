using System;
using Core2LayersApp.Services.DTO;

namespace Core2LayersApp.Services.Interfaces
{
    public interface IProductService
    {
        //ProductDTO GetProductAvailable(ProductDTO productDTO);
        //ProductTypeCategoryDTO FilterProduct(ProductTypeCategoryDTO product, CategoryDTO category, TypeDTO type);
        ProductDTO GetProducts(ProductDTO productDTO);
    }
}
