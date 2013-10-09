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
            UriTemplate = "json/dealershipkpi/?dealer={dealerID}&kpi={kpiID}")]

        List<DealerKPI> GetAllDealershipKPIMethod(string dealerID, string kpiID);

        [OperationContract]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped,
            UriTemplate = "json/kpi/?kpi={kpiID}")]

        List<KPI> GetKPIMethod(string kpiID);
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