using static demo.ListGenerator;
namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region filteration (restriction) operators - where ,typeof

            #region Where

            //Console.WriteLine(ListGenerator.CustomerList[0]);//test

            //the first overload of where
            //fluent syntax
            //var res = ProductList.Where(p => p.UnitsInStock == 0);

            /// var res = ProductList.Where(p => p.UnitsInStock == 0 && p.Category == "Meat/Poultry");

            //query experisson
            //var res = from p in ProductList
            //          where p.UnitsInStock == 0
            //          select p;


            //the second overload for where
            //indexed where

            //var res = ProductList.Where((p, I) => I < 10 && p.UnitsInStock == 0);

            //foreach (var p in res)
            //{
            //    Console.WriteLine(p); 
            //}

            #endregion

            #region OFtype


            //var res = ProductList.OfType<Product>();

            //foreach (var p in res)
            //{
            //    Console.WriteLine(p);
            //}



            #endregion
            #endregion

            #region transformation(projection) oper-select,selectmmany,zip

            #region select

            //var res = ProductList.Select((p) => p.ProductName);

            //var res = from p in ProductList
            //          select p.ProductName;


            ///var res = ProductList.Where(p => p.UnitsInStock > 0).Select((p) => $"{p.ProductID }  && {p.ProductName}");
            //*********************************************************

            //var res = from p in ProductList
            //          where p.UnitsInStock > 0
            //          select new product02()
            //          {
            //              ProductID = p.ProductID,
            //              ProductName = p.ProductName
            //          };

            //var res = from p in ProductList
            //          where p.UnitsInStock > 0
            //          select new 
            //          {
            //              p.ProductID,
            //               p.ProductName
            //          };

            //***************************************************************
            //query
            //var res = from p in ProductList
            //          where p.UnitsInStock > 0
            //          select new
            //          {
            //              p.ProductID,
            //              p.ProductName,
            //              newprice = p.UnitPrice - (p.UnitPrice * .2M)
            //          };

            //fluent
            //var res = ProductList.Where(p => p.UnitsInStock > 0).Select((p) => new
            //{
            //    p.ProductID,
            //    p.ProductName,
            //    newprice = p.UnitPrice - (p.UnitPrice * .2M)
            //});

            //indexed select
            //fluent synatx
            //var res = ProductList.Select((p, I) => new
            //{
            //    I,
            //    p.ProductName,
            //});



            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region selectmany


            //var res = CustomerList.SelectMany(c => c.Orders);

            //var res = from c in CustomerList
            //          from o in c.Orders
            //          select o;


            //*******************************************

            //var res = CustomerList.SelectMany(c => c.Orders,  (customer, order) =>new
            //{
            //    customer,
            //    order,
            //});

           //var res = from c in CustomerList
           //       from o in c.Orders
           //       select new
           //       {
           //           c,o
           //       };
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion



            #endregion


        }
    }
}
