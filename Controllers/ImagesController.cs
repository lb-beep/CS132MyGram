public IActionResult FilterProducts([FromForm]ProductFilters filters)
        {
            IList<Product> productList =
                _dbContext.Products
                .Where(product =>
                                  (String.IsNullOrEmpty(filters.ProductName) ?
                                      1 == 1 : product.ProductName == filters.ProductName)&&
                                  (String.IsNullOrEmpty(filters.ProductDescription) ?
                                      1 == 1 : product.ProductDescription == filters.ProductDescription) &&
                                  (filters.ProductPrice == 0 ?
                                      1 == 1 : product.ProductPrice == filters.ProductPrice))
                .OrderBy(product => product.ProductPrice)
                .ToList();

            return View("GetAllProducts", productList);
        }
