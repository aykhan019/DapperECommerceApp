﻿using ADO.NET_Lesson12.DataAccess.Abstractions;
using ADO.NET_Lesson12.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_Lesson12.DataAccess.Concretes
{
    public class CategoryRepository : ICategoryRepository
    {
        public void Add(Category data)
        {
            throw new NotImplementedException();
        }

        public void Delete(Category data)
        {       
            throw new NotImplementedException();
        }

        public Category Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Category data)
        {
            throw new NotImplementedException();
        }
    }
}
