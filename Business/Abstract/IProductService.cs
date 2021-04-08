using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IDataResult<List<Product>> GetAllByCategoryId(int id);//category id ye göre getir.
        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);//min ile max arasındakileri getir
        IDataResult<List<ProductDetailDto>> GetProductDetails();
        IDataResult<Product> GetById(int productId);//tek başına ürün döndürür
        IResult Add(Product product);//birşey döndürme yok
    }
}
