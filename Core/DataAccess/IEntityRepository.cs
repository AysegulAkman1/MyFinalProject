using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //class : referans tip olabilir intleri engeller yani.
    //new() : newlenebilir olmalı.IEntety interface old için newlenemez.
    //IEntity : IEntity olabilir veya IEntity implemente eden bir nesne olabilir.
    public interface IEntityRepository<T> where T:class,IEntity,new() //T ya entity yada class olabilir.
    {
        //expression filtreleme yapar örn id'si 1 olanlari getir
        List<T> GetAll(Expression<Func<T,bool>> filter=null); //listedeki ürünlerin hepsini getir.null filtre
        //olmayabilirde demektir.
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity); //ekleme yap producta.
        void Update(T entity);
        void Delete(T entity);

    }
}
