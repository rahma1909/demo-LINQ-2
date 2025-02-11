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


        }
    }
}
