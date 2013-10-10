using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace JsonWcfService
{
    [DataContract]
    public class KPIValues
    {
        [DataMember]
        public double DealerValue { get; set; }
        [DataMember]
        public double RegionValue { get; set; }
        [DataMember]
        public double NationValue { get; set; }
        [DataMember]
        public DateTime Date { get; set; }
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

    //[DataContract]
    //public class KPI
    //{
    //    [DataMember]
    //    public int KPIID { get; set; }
    //    [DataMember]
    //    public string Description { get; set; }
    //    [DataMember]
    //    public string Name { get; set; }

    //    public KPI(int KID, string Desc, string Nam)
    //    {
    //        KPIID = KID;
    //        Description = Desc;
    //        Name = Nam;
    //    }
    //}

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

    [DataContract]
    public class DealerKPI
    {
        [DataMember]
        public int KPIID { get; set; }
        [DataMember]
        public double MonthAmount { get; set; }
        [DataMember]
        public DateTime Date { get; set; }

        public DealerKPI(int KPD, double MonAm, DateTime Dat)
        {
            KPIID = KPD;
            MonthAmount = MonAm;
            Date = Dat;
        }
    }
}