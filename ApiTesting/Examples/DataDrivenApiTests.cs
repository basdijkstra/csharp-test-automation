using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using System.Net;

namespace ApiTesting.Examples
{
    [TestClass]
    public class DataDrivenApiTests
    {
        [DataTestMethod]
        [DataRow("us", "90210", HttpStatusCode.OK)]
        [DataRow("nl", "3825", HttpStatusCode.OK)]
        [DataRow("ro", "400124", HttpStatusCode.NotFound)]
        public void RetrieveLocationData_CheckStatusCode_ShouldEqual(string countryCode, string zipCode, HttpStatusCode expectedStatusCode)
        {
            // Arrange
            RestClient client = new RestClient("http://api.zippopotam.us/");
            RestRequest request = new RestRequest($"{countryCode}/{zipCode}", Method.GET);

            // Act
            IRestResponse response = client.Execute(request);

            // Assert
            Assert.AreEqual(expectedStatusCode, response.StatusCode);
        }
    }
}
