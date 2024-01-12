using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class Client
    {
        public  string IdClient { get; set; }
        public  string Name { get; set; }
        public  string Address { get; set; }
        public  bool IsActive { get; set; }
        public  List<int> DecimalList { get; set; } // []=>List
    }

    //через static,ArrayList
    //public class Client
    //{
    //    public string IdClient { get; private set; }
    //    public string Name { get; set; }
    //    public string Address { get; set; }
    //    public bool IsActive { get; private set; }
    //    public List<int> DecimalList { get; set; }

    //    public static List<Client> GetClientList()
    //    {
    //        List<Client> a = new List<Client>();
    //        a.Add(new Client { IdClient = "1", Name = "Руслан", Address = " Уродсвк", IsActive = true, DecimalList = new List<int> { 100, 300, 200 } });
    //        a.Add(new Client { IdClient = "2", Name = "Антон", Address = " Красивск", IsActive = false, DecimalList = new List<int> { 100, 300, 200 } });
    //        return (a);
    //    }
    //    public static Client[] GetClientArray()
    //    {
    //        //List
    //        return (GetClientList().ToArray());
    //        //ArrayList
    //      //return ((Client[])GetClientList().ToArray(typeof(Client)));
    //    }
    //}
}








