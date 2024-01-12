using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class Order
    {
        public string IdOrder { get; set; }
        public int IdClient { get; set; }
        public bool IsDelivered { get; set; }
        public int Price { get; set; }
        public decimal[] Decimal { get; set; }
    }

    //через static,ArrayList
    //public class Order
    //{
    //    public string IdOrder { get; private set; }
    //    public string IdClient { get; set; }
    //    public bool IsDelivered { get; set; }
    //    public int Price { get; private set; }
    //    public decimal[] Decimal { get; set; }

    //    public static List<Order> GetOrderList()
    //    {
    //        List<Order> a = new List<Order>();
    //        a.Add(new Order { IdOrder = "O1", IdClient = "1", IsDelivered = true, Price = 1000, Decimal = new decimal[] { 200, 300000, 100 } });
    //        a.Add(new Order { IdOrder = "O2", IdClient = "2", IsDelivered = false, Price = 2000, Decimal = new decimal[] { 200, 300000, 100 } });
    //        return (a);
    //    }
    //    public static Order[] GetOrderArray()
    //    {
    //        //List
    //        return (GetOrderArray().ToArray());
    //        //ArrayList
    //        //return ((Order[])GetOrderList().ToArray(typeof(Order)));
    //    }
    //}
}
