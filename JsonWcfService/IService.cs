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
            UriTemplate = "json/validateuser/?user={username}&pass={password}")]

        List<ValidateUserResult> ValidateUser(string username, string password);

        [OperationContract]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped,
            UriTemplate = "json/userdealerships/?user={userID}")]

        List<GetUserDealershipsResult> GetUserDealerships(int userID);

        [OperationContract]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped,
            UriTemplate = "json/addactionplan/?dealer={dealerID}")]

         List<AddActionPlanResult> AddActionPlan(int dealerID);

        [OperationContract]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped,
            UriTemplate = "json/modactionplan/?ap={apID}&com={comment}&reac={reaction}")]

        bool ModifyActionPlan(int apID, string comment, int reaction);

        [OperationContract]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped,
            UriTemplate = "json/addactionplankpi/?ap={apID}&kp={kpID}")]

        bool AddActionPlanKPI(int apID, int kpID);

        [OperationContract]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped,
            UriTemplate = "json/modactionplankpi/?ap={apID}&kp={kpID}&sug={suggest}&act={action}&res={result}&com={comment}&reac={reaction}")]

        bool ModifyActionPlanKPI(int apID, int kpID, string suggest, string action, string result, string comment, int reaction);

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

        [OperationContract]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped,
            UriTemplate = "json/dealershipkpis/?dealer={dealerID}")]

        List<GetDealershipKPIsResult> GetDealershipKPIs(int dealerID);

        [OperationContract]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped,
            UriTemplate = "json/mostrecentkpi/?dealer={dealerID}&kpi={kpiID}")]

        List<GetMostRecentKPIValuesResult> GetMostRecentKPIValues(int dealerID, int kpiID);


        [OperationContract]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped,
            UriTemplate = "json/getaction/?dealer={dealerID}")]

        List<GetActionPlansResult> GetActionPlans(int dealerID);


        [OperationContract]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped,
            UriTemplate = "json/getactionkpi/?ap={apID}")]

        List<GetActionPlanKPIsResult> GetActionPlanKPIs(int apID);



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