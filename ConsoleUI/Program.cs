using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //DTO Data Transformation Object
            ProductTest();
            //CategoryTest();

        }

        private static void CategoryTest()
        {
         CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
         var result = categoryManager.GetAll();
            if (result.Success == true)
            {
                foreach (var category in result.Data)
                {
                    Console.WriteLine("{0} / {1}", category.CategoryId, category.CategoryName );
                }



            }
            else
            {
                Console.WriteLine(result.Message);
            }


        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            var result = productManager.GetProductDetails();
            if (result.Success==true)
            {
                    foreach (var product in result.Data)
                    {
                        Console.WriteLine("{0} / {1}", product.Productname, product.CategoryName);
                    }

            
               
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }
            


    }
}
