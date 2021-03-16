using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;


//bellekte veri varmiş gibi simüle etme
namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _product; //global degişkendir alt çizgi ile verilir.Ürünleri oluşturcaz
        public InMemoryProductDal()//constructor ürünleri oluşturacagiz
        {
            //oracle,sql serverden geliyormuş gibi
            _product = new List<Product> { 
                new Product{ProductId=1,CategoryId=1, UnitPrice=15, ProductName="bardak",UnitsInStock=15},
                new Product{ProductId=2,CategoryId=1, UnitPrice=500, ProductName="kamera",UnitsInStock=3},
                new Product{ProductId=3,CategoryId=2, UnitPrice=1500, ProductName="telefon",UnitsInStock=2},
                new Product{ProductId=4,CategoryId=2, UnitPrice=150, ProductName="klavye",UnitsInStock=65},
                new Product{ProductId=5,CategoryId=2, UnitPrice=85, ProductName="fare",UnitsInStock=1}
            
            };
        }
        public void Add(Product product)//businessten gelen ürünleri ekliyorum.
        {
            _product.Add(product);
        }

        public void Delete(Product product)
        {
            //LINQ - Language Integreted Query
            //Product productToDelete=null;
            //foreach (var p in _product)
            //{
            //    if (product.ProductId == p.ProductId)
            //    {
            //        productToDelete = p;
            //    }
            //}

            ///------LINQ İLE YAPILAN İŞLEM
            //her p için p nin id si parametreyle gönderdirdigime eşitle.foreach ile aynı işlevi yaptı
            Product productToDelete = _product.SingleOrDefault(p=>p.ProductId == product.ProductId);
            //her p için benim gönderdiğim product id ye eşit mi eşitse producttodelete'e eşitle.
            //her p benim listeyi dolaşmak için oluşturduğum p dir

            _product.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()//veritabanindaki datayi döndür
        {
            return _product;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            //where içindeki şarta uyanları tüm liste haline getirerek onu döndürür
            return _product.Where(p => p.CategoryId == categoryId).ToList();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            //gönderdiğim ürün id sine sahip olan listedeki ürünü bul.
            Product productToUpdate = _product.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName; //GÖNDERDİĞİM productu producttoupdata yapabilrsin
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;

        }
        
    }
}
