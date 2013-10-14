using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Runtime.Serialization;
using System.Linq;

namespace JsonWcfService
{
    public class Service : IService
    {
        public List<ValidateUserResult> ValidateUser(string Username, string Password)
        {
            List<ValidateUserResult> results;

            using (WSUDataContext ws = new WSUDataContext())
            {
                results = ws.ValidateUser(Username, Password).ToList();
            }

            return results;
        }


        public List<GetUserDealershipsResult> GetUserDealerships(int userID)
        {
            List<GetUserDealershipsResult> results;

            using (WSUDataContext ws = new WSUDataContext())
            {
                results = ws.GetUserDealerships(userID).ToList();
            }

            return results;
        }

        public List<AddActionPlanResult> AddActionPlan(int dealerID)
        {   //code to Create the Person goes here
             //{"PersonObject":{"FirstName":"Shirley","LastName":"Horn","Grammys":4}}
            List<AddActionPlanResult> results;
            using (WSUDataContext ws = new WSUDataContext())
            {
                results = ws.AddActionPlan(dealerID).ToList();
            }
            return results;
        }

        public bool ModifyActionPlan(int apID, string comment, int reaction)
        { 
            using (WSUDataContext ws = new WSUDataContext())
            {
                ws.ModifyActionPlan(apID, comment, reaction);
            }
            return true;
        }

        public bool AddActionPlanKPI(int apID, int kpID)
        {
            using (WSUDataContext ws = new WSUDataContext())
            {
                ws.AddActionPlanKPI(apID, kpID);
            }
            return true;
        }
        
        public bool ModifyActionPlanKPI(int apID, int kpID, string suggest, string action, string result, string comment, int reaction)
        {
            using (WSUDataContext ws = new WSUDataContext())
            {
                ws.ModifyActionPlanKPI(apID, kpID, suggest, action, result, comment, reaction);
            }
            return true;
        }

       
        public List<GetKPIValuesResult> GetAllKPIValuesPastYear(int dealerID, int kpiID)
        {
             List<GetKPIValuesResult> results;

            using( WSUDataContext ws = new WSUDataContext()) {
                results = ws.GetKPIValues(dealerID, kpiID).ToList();
            }

            return results;
        }

        public List<GetMostRecentKPIValuesResult> GetMostRecentKPIValues(int dealerID, int kpiID)
        {
            List<GetMostRecentKPIValuesResult> results;

            using (WSUDataContext ws = new WSUDataContext())
            {
                results = ws.GetMostRecentKPIValues(dealerID, kpiID).ToList();
            }

            return results;
        }

        public List<GetKPINameResult> GetKPIName(int kpiID)
        {
            List<GetKPINameResult> results;

            using (WSUDataContext ws = new WSUDataContext())
            {
                results = ws.GetKPIName(kpiID).ToList();
            }

            return results;
        }

        public List<GetDealershipKPIsResult> GetDealershipKPIs(int dealerID)
        {
            List<GetDealershipKPIsResult> results;

            using (WSUDataContext ws = new WSUDataContext())
            {
                results = ws.GetDealershipKPIs(dealerID).ToList();
            }

            return results;
        }

        public List<GetActionPlansResult> GetActionPlans(int dealerID)
        {
            List<GetActionPlansResult> results;

            using (WSUDataContext ws = new WSUDataContext())
            {
                results = ws.GetActionPlans(dealerID).ToList();
            }

            return results;
        }


        public List<GetActionPlanKPIsResult> GetActionPlanKPIs(int apID)
        {
            List<GetActionPlanKPIsResult> results;

            using (WSUDataContext ws = new WSUDataContext())
            {
                results = ws.GetActionPlanKPIs(apID).ToList();
            }

            return results;
        }

    //    public double GetDealershipKPI(string dealerID, string kpiID, string year, string month)
    //    {
    //        var result = 0.0;
    //        using (SqlConnection conn = new SqlConnection("Server=URBANSCIENCE;Database=WSU;User Id=sa;Password=hello;"))
    //        {
    //            conn.Open();
    //            string cmdStr = String.Format("Select MonthAmount from dbo.DealerKPIValue Where DealerID = {0} and KPIID = {1} and YEAR(Date) = YEAR({2}) and MONTH(Date) = MONTH({3})", dealerID, kpiID, year, month);
    //            SqlCommand cmd = new SqlCommand(cmdStr, conn);
    //            SqlDataReader rd = cmd.ExecuteReader();
                
    //            if (rd.HasRows)
    //            {
    //                while (rd.Read())
    //                {
    //                    result = rd.GetDouble(0);
    //                }
    //            }
    //            conn.Close();
    //        }

    //        return result;
    //    }

    //    public List<Double> GetRegionKPI(string areaID, string kpiID, string year, string month)
    //    {
    //        List<Double> mylist = new List<Double>();
    //        var total = 0.0;
    //        var count = 0;

    //        using (SqlConnection conn = new SqlConnection("Server=URBANSCIENCE;Database=WSU;User Id=sa;Password=hello;"))
    //        {
    //            conn.Open();
    //            string cmdStr = String.Format("Select MonthAmount from dbo.DealerKPIValue Where areaID = {0} and KPIID = {1} and YEAR(Date) = YEAR({2}) and MONTH(Date) = MONTH({3})", areaID, kpiID, year, month);
    //            SqlCommand cmd = new SqlCommand(cmdStr, conn);
    //            SqlDataReader rd = cmd.ExecuteReader();


    //            if (rd.HasRows)
    //            {
                    
    //                while (rd.Read())
    //                {
    //                    total += rd.GetDouble(1);
    //                    count += 1;
    //                }
    //            }
    //            conn.Close();
    //        }

    //        var regionTotal = total / count;
    //        mylist.Add(regionTotal);
    //        return mylist;
    //    }


    //    public List<Dealership> GetDealershipsForUser(string userID)
    //    {
    //        List<Dealership> mylist = new List<Dealership>();

    //        using (SqlConnection conn = new SqlConnection("Server=URBANSCIENCE;Database=WSU;User Id=sa;Password=hello;"))
    //        {
    //            conn.Open();

    //            string cmdStr = String.Format("Select * from dbo.Dealer");
    //            SqlCommand cmd = new SqlCommand(cmdStr, conn);
    //            SqlDataReader rd = cmd.ExecuteReader();

    //            if (rd.HasRows)
    //            {
    //                while (rd.Read())
    //                    mylist.Add(new Dealership(rd.GetInt32(0), rd.GetString(1), rd.GetString(2), rd.GetInt32(3)));
    //            }
    //            conn.Close();
    //        }

    //        return mylist;
    //    }

    //    public List<KPI> GetKPIInfo(string kpiID)
    //    {
    //        List<KPI> mylist = new List<KPI>();

    //        using (SqlConnection conn = new SqlConnection("Server=URBANSCIENCE;Database=WSU;User Id=sa;Password=hello;"))
    //        {
    //            conn.Open();

    //            string cmdStr = String.Format("Select * from dbo.KPI Where KPIID={0}", kpiID);
    //            SqlCommand cmd = new SqlCommand(cmdStr, conn);
    //            SqlDataReader rd = cmd.ExecuteReader();

    //            if (rd.HasRows)
    //            {
    //                while (rd.Read())
    //                    mylist.Add(new KPI(rd.GetInt32(0), rd.GetString(1), rd.GetString(2)));
    //            }
    //            conn.Close();
    //        }

    //        return mylist;
    //    }
    }


}

