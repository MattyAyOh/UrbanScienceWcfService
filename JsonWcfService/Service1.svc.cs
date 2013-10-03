using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Runtime.Serialization;
namespace JsonWcfService
{
    public class Service1 : IService1
    {
        public string Testingstring()
        {
            string Yoyo = "testing";
            return Yoyo;
        }

    }

}