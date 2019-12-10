﻿using OZamanDans.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OZamanDans.BLL.Abstract
{
    public interface IProductService : IBaseService<Product>
    {
        List<Product> GetProductsByCategory(int categoryID);
    }
}
