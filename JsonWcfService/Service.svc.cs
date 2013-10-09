using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Runtime.Serialization;

namespace JsonWcfService
{
    public class Service : IService
    {
        public List<DealerKPI> GetAllDealershipKPIMethod(string dealerID, string kpiID)
        {
            List<DealerKPI> mylist = new List<DealerKPI>();

            using (SqlConnection conn = new SqlConnection("Server=URBANSCIENCE;Database=WSU;User Id=sa;Password=hello;"))
            {
                conn.Open();
                string cmdStr = String.Format("Select KPIID, MonthAmount, Date from dbo.DealerKPIValue Where DealerID = {0} and KPIID = {1} and datediff(MONTH, Date, GETDATE()) <= 12", dealerID, kpiID);
                SqlCommand cmd = new SqlCommand(cmdStr, conn);
                SqlDataReader rd = cmd.ExecuteReader();
                

                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        //if (rd.GetValue(1) == null || rd.GetValue(2) == null)
                        //{
                            mylist.Add(new DealerKPI(rd.GetInt32(0), rd.GetDouble(1), rd.GetDateTime(2)));
                        //}
                        //else
                        //{
                        //    mylist.Add(new DealerKPI(rd.GetInt32(0), 0, new DateTime(2000, 1, 1)));
                        //}
                    }
                }
                conn.Close();
            }

            return mylist;
        }

        public List<Dealership> GetDealershipsForUserMethod(string userID)
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

        public List<KPI> GetKPIMethod(string kpiID)
        {
            List<KPI> mylist = new List<KPI>();

            using (SqlConnection conn = new SqlConnection("Server=URBANSCIENCE;Database=WSU;User Id=sa;Password=hello;"))
            {
                conn.Open();

                string cmdStr = String.Format("Select * from dbo.KPI Where KPIID={0}", kpiID);
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


}

