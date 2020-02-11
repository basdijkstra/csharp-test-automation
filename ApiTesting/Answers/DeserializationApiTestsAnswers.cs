using ApiTesting.DataEntities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using RestSharp.Serialization.Json;

namespace ApiTesting.Answers
{
    [TestClass]
    public class DeserializationApiTestsAnswers
    {
        [TestMethod]
        public void GetLocationsForUS90210_CheckCountryAbbreviation_ShouldEqualUS()
        {
            // Exercise 1
            // Write a RestSharp test method that performs an HTTP GET on
            // base URL http://api.zippopotam.us and path us/90210
            // Deserialize the response into a new LocationResponse object
            // Check that the value of the CountryAbbreviation property equals 'US'

            // arrange
            RestClient client = new RestClient("http://api.zippopotam.us");
            RestRequest request = new RestRequest("us/90210", Method.GET);

            // act
            IRestResponse response = client.Execute(request);

            LocationResponse locationResponse =
                new JsonDeserializer().
                Deserialize<LocationResponse>(response);

            // assert
            Assert.AreEqual("US", locationResponse.CountryAbbreviation);
        }

        [TestMethod]
        public void GetLocationsForUS90210_CheckNameOfFirstPlace_ShouldEqualBeverlyHills()
        {
            // Exercise 2
            // Write a RestSharp test method that performs an HTTP GET on
            // base URL http://api.zippopotam.us and path us/90210
            // Deserialize the response into a new LocationResponse object
            // Check that the value of the first place in the list of places equals 'Beverly Hills'

            // arrange
            RestClient client = new RestClient("http://api.zippopotam.us");
            RestRequest request = new RestRequest("us/90210", Method.GET);

            // act
            IRestResponse response = client.Execute(request);

            LocationResponse locationResponse =
                new JsonDeserializer().
                Deserialize<LocationResponse>(response);

            // assert
            Assert.AreEqual("Beverly Hills", locationResponse.Places[0].PlaceName);
        }

        [TestMethod]
        public void GetLocationsForUS90210_CheckNumbeOfPlaces_ShouldEqual1()
        {
            // Exercise 3
            // Write a RestSharp test method that performs an HTTP GET on
            // base URL http://api.zippopotam.us and path us/90210
            // Deserialize the response into a new LocationResponse object
            // Check that the list of places contains exactly 1 place

            // arrange
            RestClient client = new RestClient("http://api.zippopotam.us");
            RestRequest request = new RestRequest("us/90210", Method.GET);

            // act
            IRestResponse response = client.Execute(request);

            LocationResponse locationResponse =
                new JsonDeserializer().
                Deserialize<LocationResponse>(response);

            // assert
            Assert.AreEqual(1, locationResponse.Places.Count);
        }
    }
}
