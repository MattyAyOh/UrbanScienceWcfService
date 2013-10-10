using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;


namespace JsonWcfService
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped,
            UriTemplate = "json/allkpi/?dealer={dealerID}&kpi={kpiID}")]

        List<GetKPIValuesResult> GetAllKPIValuesPastYear(int dealerID, int kpiID);

        [OperationContract]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped,
            UriTemplate = "json/kpiname/?kpi={kpiID}")]

        List<GetKPINameResult> GetKPIName(int kpiID);

        //[OperationContract]
        //[WebInvoke(Method = "GET",
        //    ResponseFormat = WebMessageFormat.Json,
        //    RequestFormat = WebMessageFormat.Json,
        //    BodyStyle = WebMessageBodyStyle.Wrapped,
        //    UriTemplate = "json/dealershipkpi/?dealer={dealerID}&kpi={kpiID}&y={year}&m={month}")]

        //double GetDealershipKPI(string dealerID, string kpiID, string year, string month);

        //[OperationContract]
        //[WebInvoke(Method = "GET",
        //    ResponseFormat = WebMessageFormat.Json,
        //    RequestFormat = WebMessageFormat.Json,
        //    BodyStyle = WebMessageBodyStyle.Wrapped,
        //    UriTemplate = "json/regionkpi/?area={areaID}&kpi={kpiID}&y={year}&m={month}")]

        //double GetRegionKPI(string areaID, string kpiID, string year, string month);

        //[OperationContract]
        //[WebInvoke(Method = "GET",
        //    ResponseFormat = WebMessageFormat.Json,
        //    RequestFormat = WebMessageFormat.Json,
        //    BodyStyle = WebMessageBodyStyle.Wrapped,
        //    UriTemplate = "json/nationkpi/?kpi={kpiID}&y={year}&m={month}")]

        //double GetNationKPI(string kpiID, string year, string month);

        //[OperationContract]
        //[WebInvoke(Method = "GET",
        //    ResponseFormat = WebMessageFormat.Json,
        //    RequestFormat = WebMessageFormat.Json,
        //    BodyStyle = WebMessageBodyStyle.Wrapped,
        //    UriTemplate = "json/kpi/?kpi={kpiID}")]

        //List<KPI> GetKPIInfo(string kpiID);
    }


    //[ServiceContract]
    //public interface IGetDealerships
    //{
    //    [OperationContract]
    //    [WebInvoke(Method = "GET",
    //        ResponseFormat = WebMessageFormat.Json,
    //        RequestFormat = WebMessageFormat.Json,
    //        BodyStyle = WebMessageBodyStyle.Wrapped,
    //        UriTemplate = "json/dealerships")]

    //    List<Dealership> GetAllDealershipsMethod();
    //}
}