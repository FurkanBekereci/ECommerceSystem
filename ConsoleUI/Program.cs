using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductTest();
            //CategoryTest();

        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            var result = categoryManager.GetAll();

            if (result.Success)
                result.Data.ForEach(c => Console.WriteLine(c.CategoryName));            
                
            Console.WriteLine(result.Message);
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            var result = productManager.GetAll();

            if(result.Success)
              result.Data.ForEach(r => Console.WriteLine($"{r.ProductName}" ));

            Console.WriteLine(result.Message);
        }
    }
}
