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

            //var res = CustomerList.SelectMany(c => c.Orders, (customer, order) => new
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

            #region ordering operators - order, orderdesending, orderby, orderbydescending,thenby,thenbydescending,reverse


            //var res = ProductList.Order();
            //var res = ProductList.OrderDescending();
            //var res = ProductList.OrderByDescending(p=>p.UnitsInStock);
            //var res = ProductList.OrderBy(p=>p.UnitsInStock);//asending
            //var res = ProductList.OrderBy(p=>p.UnitsInStock).ThenBy(p=>p.UnitPrice);//asending

            //var res = from p in ProductList
            //          orderby p.UnitsInStock, p.UnitPrice
            //          select p;

            //var res = ProductList.Where(p => p.UnitsInStock == 0).Reverse();
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}





            #endregion

            #region Elements operators- immidate excuation

            //ProductList = new List<Product>();//empty
            //var res = ProductList.First();//maythrough an exception


            //var res = ProductList.First(p=>p.UnitsInStock==0);
            //var res = ProductList.Last(p=>p.UnitsInStock==0);

            //var res = ProductList.FirstOrDefault(new Product()
            //{
            //    ProductName="there is no product"
            //});



            //var res = ProductList.FirstOrDefault(p=>p.UnitsInStock==0);
            //var res = ProductList.FirstOrDefault(p=>p.UnitsInStock==0,new Product()
            //{
            //    ProductName = "there is no product"
            //});


            //var res = ProductList.LastOrDefault(p=>p.UnitsInStock==0);
            //var res = ProductList.LastOrDefault(p => p.UnitsInStock == 0, new Product()
            //{
            //    ProductName = "there is no product"
            //});



            //var res = ProductList.ElementAt(0);//may through an exception
            //var res = ProductList.ElementAtOrDefault(0);


            //var res = ProductList.Single();//Sequence contains more than one element ==>seq is more than one element,or ele


            //var res = ProductList.SingleOrDefault();
            //var res = ProductList.SingleOrDefault(p=>p.UnitsInStock==0);
            //var res = ProductList.SingleOrDefault(p=>p.UnitsInStock==0,new Product()
            //{
            //    ProductName="chai"
            //});


            //Console.WriteLine(res?.ProductName ?? "NA");


            //var res = ProductList.DefaultIfEmpty(new Product()
            //{
            //    ProductName="default"
            //});

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region aggregate operators - immidate excuation

            //var res = ProductList.Count();
            //var res = ProductList.Count(p => p.UnitsInStock == 0);//5

            //var res = ProductList.Count;


            //sum
            //var res = ProductList.Sum(p => p.UnitPrice);
            //Console.WriteLine(res);

            //avarage
            //var res = ProductList.Average(  p => p.UnitPrice);
            //Console.WriteLine(res);

            //max
            //var res = ProductList.Max( new unitinstockcomparer());
            //Console.WriteLine(res);     
            //var maxvalue = ProductList.Max(p=>p.UnitsInStock) ;//125
            //var res = ProductList.FirstOrDefault(p => p.UnitsInStock == maxvalue);


            //maxby
            //var res = ProductList.MaxBy(p => p.UnitPrice);



            //minby
            //var res = ProductList.MinBy(p => p.UnitPrice,new unitpricecomarer());
            //var res = ProductList.MaxBy(p => p.UnitPrice,new unitpricecomarer());



            //aggregate
            //List<string> names = ["ahmed", "mohamed"];
            //var res = names.Aggregate((a, b) => $"{a} ::: {b}");
            //Console.WriteLine(res);
            #endregion

            #region casting operators- immediate excuation


            //List<Product> list = ProductList.Where(p => p.UnitsInStock == 0).ToList();
            //Array list = ProductList.Where(p => p.UnitsInStock == 0).ToArray();
            //Dictionary<long,Product> dic = ProductList.Where(p => p.UnitsInStock == 0).ToDictionary(p=>p.ProductID);
            //HashSet<Product> dic = ProductList.Where(p => p.UnitsInStock == 0).ToHashSet();
            //foreach (var item in dic)
            //{
            //    Console.WriteLine(item);
            //}



            #endregion
        }
    }
}
