using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Runtime.Serialization;
namespace JsonWcfService
{
    public class GetKPI : IGetKPI
    {
        public List<KPI> GetAllKPIMethod()
        {
            List<KPI> mylist = new List<KPI>();

            using (SqlConnection conn = new SqlConnection("Server=URBANSCIENCE;Database=WSU;User Id=sa;Password=hello;"))
            {
                conn.Open();

                string cmdStr = String.Format("Select * from dbo.KPI");
                SqlCommand cmd = new SqlCommand(cmdStr, conn);
                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.HasRows)
                {
                    while (rd.Read())
                        mylist.Add(new KPI(rd.GetInt32(0), rd.GetString(1), rd.GetString(2)));
                }
                conn.Close();
            }

            return mylist;
        }
    }

    [DataContract]
    public class KPI
    {
        [DataMember]
        public int KPIID { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string Name { get; set; }

        public KPI(int KID, string Desc, string Nam)
        {
            KPIID = KID;
            Description = Desc;
            Name = Nam;
        }
    }
}