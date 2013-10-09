using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Runtime.Serialization;
namespace JsonWcfService
{
    public class GetDealerships : IGetDealerships
    {
        public List<Dealership> GetAllDealershipsMethod()
        {
            List<Dealership> mylist = new List<Dealership>();

            using (SqlConnection conn = new SqlConnection("Server=URBANSCIENCE;Database=WSU;User Id=sa;Password=hello;"))
            {
                conn.Open();

                string cmdStr = String.Format("Select * from dbo.Dealer");
                SqlCommand cmd = new SqlCommand(cmdStr, conn);
                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.HasRows)
                {
                    while (rd.Read())
                        mylist.Add(new Dealership(rd.GetInt32(0), rd.GetString(1), rd.GetString(2), rd.GetInt32(3)));
                }
                conn.Close();
            }

            return mylist;
        }

        public string Testingstring()
        {
            string Yoyo = "testing";
            return Yoyo;
        }

    }

    [DataContract]
    public class Dealership
    {
        [DataMember]
        public int DealerID { get; set; }
        [DataMember]
        public string Latitude { get; set; }
        [DataMember]
        public string Longitude { get; set; }
        [DataMember]
        public int AreaID { get; set; }
        public Dealership(int DID, string Lat, string Long, int AID)
        {
            DealerID = DID;
            Latitude = Lat;
            Longitude = Long;
            AreaID = AID;
        }
    }
}