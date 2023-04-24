﻿using OOP_Cong.DAO;
using OOP_Cong.Enity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Cong.Demo
{
    internal class CategoryDaoDemo
    {
        CategoryDAO category = new CategoryDAO();
        public void insertTest()
        {
            category.insert(new Category());
        }
        public void updateTest() { 
            category.update(new Category(-1, "Dien thoai"));
        }
        public void deleteTest() {
            category.delete(-1);
        }
        public void findAll() {
            category.findAll("Dien thoai");
        }
        public void findById() { 
            category.findById(-1);
        }
    }
}