using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using RestSharp;
using System.Net;

namespace ApiTesting.Answers
{
    [TestClass]
    public class BasicApiTestsAnswers
    {
        [TestMethod]
        public void RetrieveDataForUS90210_CheckStatusCode_ShouldBeHttp200()
        {
            // Exercise 1
            // Write a test that performs the following steps:
            // 1. Create a new RestSharp client with base URL http://api.zippopotam.us
            //    path us/90210 and HTTP method GET
            // 2. Perform the created REST call and store the response in an IRestResponse
            // 3. Check that the statuscode of the response is equal to 200 OK (HttpStatusCode.OK)

            // arrange
            RestClient client = new RestClient("http://api.zippopotam.us");
            RestRequest request = new RestRequest("us/90210", Method.GET);

            // act
            IRestResponse response = client.Execute(request);

            // assert
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }

        [TestMethod]
        public void RetrieveDataForNL3825_CheckContentType_ShouldBeApplicationJson()
        {
            // Exercise 2
            // Write a test that performs the following steps:
            // 1. Create a new RestSharp client with base URL http://api.zippopotam.us
            //    path nl/3825 and HTTP method GET
            // 2. Perform the created REST call and store the response in an IRestResponse
            // 3. Check that the content type of the response is equal to application/json

            // arrange
            RestClient client = new RestClient("http://api.zippopotam.us");
            RestRequest request = new RestRequest("nl/3825", Method.GET);

            // act
            IRestResponse response = client.Execute(request);

            // assert
            Assert.AreEqual("application/json", response.ContentType);
        }

        [TestMethod]
        public void RetrieveDataForIT50123_CheckCountry_ShouldBeItaly()
        {
            // Exercise 3
            // Write a test that performs the following steps:
            // 1. Create a new RestSharp client with base URL http://api.zippopotam.us
            //    path it/50123 and HTTP method GET
            // 2. Perform the created REST call and store the response in an IRestResponse
            // 3. Check that the value of the 'country' field in the response is equal to 'Italy'

            // arrange
            RestClient client = new RestClient("http://api.zippopotam.us");
            RestRequest request = new RestRequest("it/50123", Method.GET);

            // act
            IRestResponse response = client.Execute(request);

            // assert
            dynamic jsonResponse = JsonConvert.DeserializeObject(response.Content);
            Assert.AreEqual("Italy", (string)jsonResponse.country);
        }
    }
}
