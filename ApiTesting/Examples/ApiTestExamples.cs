using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ApiTesting.Examples
{
    [TestClass]
    public class ApiTestExamples
    {
        [TestMethod]
        public void RetrieveFirstUser_CheckStatusCode_ShouldEqualHttp200()
        {
            // Arrange
            RestClient client = new RestClient("http://jsonplaceholder.typicode.com/");
            RestRequest request = new RestRequest("/users/1", Method.GET);

            // Act
            IRestResponse response = client.Execute(request);

            // Assert
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }

        [TestMethod]
        public void RetrieveFirstUser_CheckContentType_ShouldEqualApplicationJson()
        {
            // Arrange
            RestClient client = new RestClient("http://jsonplaceholder.typicode.com/");
            RestRequest request = new RestRequest("/users/1", Method.GET);

            // Act
            IRestResponse response = client.Execute(request);

            // Assert
            Assert.AreEqual("application/json; charset=utf-8", response.ContentType);
        }

        [TestMethod]
        public void RetrieveFirstUser_CheckName_ShouldEqualLeanneGraham()
        {
            // Arrange
            RestClient client = new RestClient("http://jsonplaceholder.typicode.com/");
            RestRequest request = new RestRequest("/users/1", Method.GET);

            // Act
            IRestResponse response = client.Execute(request);

            // Assert
            dynamic jsonResponse = JsonConvert.DeserializeObject(response.Content);
            Assert.AreEqual("Leanne Graham", (string)jsonResponse.name);
        }
    }
}
