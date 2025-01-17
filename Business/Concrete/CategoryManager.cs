﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;//bagımlılıgımı constructor ile yaptım.
        

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            //iş kodlarını yazarız
            return _categoryDal.GetAll();
        }

        public Category GetById(int cagetoryId)
        {
            return _categoryDal.Get(c=>c.CategoryId == cagetoryId);
        }
    }
}
