using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;


namespace JsonWcfService
{
    [ServiceContract]
    public interface IGetDealershipKPI
    {
        [OperationContract]
        //attribute for returning JSON format
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped,
            UriTemplate = "json/dealershipkpi")]
        //method        

        List<DealershipKPI> GetAllDealershipKPIMethod();

    }

}