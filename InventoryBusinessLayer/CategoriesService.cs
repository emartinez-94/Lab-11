﻿using AutoMapper;
using EFCore_DBLibrary;
using InventoryDatabaseLayer;
using InventoryModels.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryBusinessLayer
{
    public class CategoriesService : ICategoriesService
    {
        private readonly ICategoriesRepo _dbRepo;
        public CategoriesService(InventoryDbContext dbContext, IMapper mapper)
        {
            _dbRepo = new CategoriesRepo(dbContext, mapper);
        }
        public List<CategoryDto> ListCategoriesAndDetails()
        {
            return _dbRepo.ListCategoriesAndDetails();
        }
    }
}
