using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Runtime.Serialization;

namespace JsonWcfService
{
    public class GetDealershipKPI : IGetDealershipKPI
    {
        public List<DealershipKPI> GetAllDealershipKPIMethod()
        {
            List<DealershipKPI> mylist = new List<DealershipKPI>();

            using (SqlConnection conn = new SqlConnection("Server=URBANSCIENCE;Database=WSU;User Id=sa;Password=hello;"))
            {
                conn.Open();
                //var DealaID = 10402116; TODO: String formatting
                string cmdStr = String.Format("Select * from dbo.DealerKPIValue Where DealerID = 10402116");
                SqlCommand cmd = new SqlCommand(cmdStr, conn);
                SqlDataReader rd = cmd.ExecuteReader();
                

                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        if (rd.GetValue(6) == null || rd.GetValue(5) == null || rd.GetValue(4) == null)
                        {
                            mylist.Add(new DealershipKPI(rd.GetInt32(0), rd.GetInt32(1), rd.GetInt32(2), rd.GetInt32(3), rd.GetDouble(4), rd.GetDouble(5), rd.GetDateTime(6)));
                        }
                        else
                        {
                            mylist.Add(new DealershipKPI(rd.GetInt32(0), rd.GetInt32(1), rd.GetInt32(2), rd.GetInt32(3), 0, 0, new DateTime(2000, 1, 1)));
                        }
                    }
                }
                conn.Close();
            }

            return mylist;
        }

    }

    [DataContract]
    public class DealershipKPI
    {
        [DataMember]
        public int DealerID { get; set; }
        [DataMember]
        public int Month { get; set; }
        [DataMember]
        public int Year { get; set; }
        [DataMember]
        public int KPIID { get; set; }
        [DataMember]
        public double MonthAmount { get; set; }
        [DataMember]
        public double YtdAmount { get; set; }
        [DataMember]
        public DateTime Date { get; set; }

        public DealershipKPI(int DID, int Mon, int Yr, int KPD, double MonAm, double YrAm, DateTime Dat)
        {
            DealerID = DID;
            Month = Mon;
            Year = Yr;
            KPIID = KPD;
            MonthAmount = MonAm;
            YtdAmount = YrAm;
            Date = Dat;
        }
    }
}