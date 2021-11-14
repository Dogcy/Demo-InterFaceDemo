using System;
using System.Collections.Generic;

namespace InterFaceTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List < IProductModel> cart = AddSampleData();
            CustomerModel customer = new CustomerModel();
            foreach (IProductModel prod in cart)
            {
                prod.ShipItem(customer);
                // 可以判斷是否使用指定的interface
                if(prod is IdigitalProductModel x)
                {
                    Console.WriteLine(x.TotalDownloadsLeft);
                }
                if((prod is IdigitalProductModel)&&(prod is IProductModel)  )
                {
                    Console.WriteLine(prod.Title);
                }
                if(prod is ITestModel itestModel)
                {
                    Console.WriteLine(itestModel.testInt);
                }
                //實體部分
                if (prod is PhysicalProductModel digital)
                {
                    //Console.WriteLine(digital.testInt);  無法判斷到
                }
                if(prod is DigitalProductModel digital2)
                {
                    Console.WriteLine(digital2.Title);//可判斷用了哪些屬性類別等
                }
            }
        }
        private static CustomerModel getCustomerModel()
        {
            return new CustomerModel
            {
                FirstName = "tim",
                LastName = "corey",
                City = "taipei",
                EmailAddress = "ccdjfoa;fg@gamil.com",
                PhoneNumber = "093234214",
                StreetAddress = "3300"
            };
        }
        private static List<IProductModel> AddSampleData()
        {
            List<IProductModel> output = new List<IProductModel>();
            output.Add(new PhysicalProductModel { Title = "Nerf Football" });
            output.Add(new PhysicalProductModel { Title = "basketball" });
            output.Add(new DigitalProductModel { Title = "lesson Source Code" });
            return output;
        }
    }
}
