using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal
    {
        List<Product> GetAll(); //listedeki ürünlerin hepsini getir
        void Add(Product product); //ekleme yap producta.
        void Update(Product product);
        void Delete(Product product);

        List<Product> GetAllByCategory(int categoryId);
    }
}
