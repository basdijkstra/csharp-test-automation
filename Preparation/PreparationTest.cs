using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using System.Net;

namespace Preparation
{
    [TestClass]
    public class PreparationTest
    {
        [TestMethod]
        public void InvokeZippopotamUs_CheckStatusCode_ShouldBeHttp200Ok()
        {
            // Arrange
            RestClient client = new RestClient("http://api.zippopotam.us");
            RestRequest request = new RestRequest("/us/90210", Method.GET);

            // Act
            IRestResponse response = client.Execute(request);

            // Assert
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
